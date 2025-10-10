using FCG_API_Jogos.Entidades.Dtos;
using FCG_API_Jogos.Models;
using Nest;

namespace FCG_API_Jogos.Services
{
    public interface IJogoElasticService
    {
        Task IndexarAsync(Jogo jogo);
        Task<IEnumerable<JogoElasticDto>> BuscarAsync(string termo);
        Task RemoverAsync(string id);
        Task AtualizarAsync(Jogo jogo);

        Task<List<JogoElasticDto>> SugerirJogosParaUsuarioAsync(long usuarioId);
        Task<IDictionary<string, List<JogoElasticDto>>> ObterTopJogosPorCategoriaAsync(int topN = 3);

    }

    public class JogoElasticService : IJogoElasticService
    {
        private readonly IElasticClient _client;

        public JogoElasticService(IElasticClient client)
        {
            _client = client;
        }

        public async Task IndexarAsync(Jogo jogo)
        {
            await _client.IndexDocumentAsync(GetJogoElasticDto(jogo));
        }

        public async Task<IEnumerable<JogoElasticDto>> BuscarAsync(string termo)
        {
            var countResponse = await _client.CountAsync<JogoElasticDto>();

            var response = await _client.SearchAsync<JogoElasticDto>(s => s
                .Query(q => q
                    .MultiMatch(mm => mm
                        .Query(termo)
                        .Fields(f => f
                            .Field(ff => ff.Nome)
                            .Field(ff => ff.Descricao)
                            .Field(ff => ff.Categoria.Descricao)
                        )
                    )
                )
                .Size(20)
            );

            return response.Documents;
        }

        public async Task RemoverAsync(string id)
        {
            var response = await _client.DeleteAsync<JogoElasticDto>(id);

            if (!response.IsValid)
            {
                throw new Exception($"Erro ao remover jogo do Elasticsearch: {response.ServerError?.Error?.Reason}");
            }
        }

        public async Task AtualizarAsync(Jogo jogo)
        {
            var jogodto = GetJogoElasticDto(jogo);

            var response = await _client.UpdateAsync<JogoElasticDto>(jogodto.Id, u => u
                .Doc(jogodto)               // substitui o documento pelos novos dados
                .DocAsUpsert(true)       // se não existir, cria
                .RetryOnConflict(3)      // tenta novamente em caso de conflito
            );

            if (!response.IsValid)
            {
                throw new Exception($"Erro ao atualizar jogo no Elasticsearch: {response.ServerError?.Error?.Reason}");
            }
        }

        public async Task<List<JogoElasticDto>> SugerirJogosParaUsuarioAsync(long usuarioId)
        {
            // 1️⃣ Buscar jogos que o usuário atual já possui
            var jogosDoUsuarioResponse = await _client.SearchAsync<JogoElasticDto>(s => s
                .Query(q => q
                    .Terms(t => t.Field(f => f.UsuariosId).Terms(usuarioId))
                )
                .Size(1000)
            );

            var jogosIds = jogosDoUsuarioResponse.Documents.Select(j => j.Id).ToList();

            if (!jogosIds.Any())
                return new List<JogoElasticDto>();

            // 2️⃣ Encontrar outros usuários que jogaram os mesmos jogos
            var outrosUsuariosResponse = await _client.SearchAsync<JogoElasticDto>(s => s
                .Query(q => q
                    .Terms(t => t.Field(f => f.Id).Terms(jogosIds))
                )
                .Source(sf => sf.Includes(f => f.Field(ff => ff.UsuariosId)))
                .Size(1000)
            );

            // Agrupar todos os IDs de usuários que jogaram qualquer um dos mesmos jogos
            var todosOutrosUsuarios = outrosUsuariosResponse.Documents
                .SelectMany(j => j.UsuariosId)
                .Where(id => id != usuarioId)
                .ToList();

            // Contar quantos jogos em comum cada usuário tem
            var topOutrosUsuarios = todosOutrosUsuarios
                .GroupBy(id => id)
                .Select(g => new { UsuarioId = g.Key, JogosEmComum = g.Count() })
                .OrderByDescending(x => x.JogosEmComum)
                .Take(5)
                .Select(x => x.UsuarioId)
                .ToList();

            if (!topOutrosUsuarios.Any())
                return new List<JogoElasticDto>();

            // 3️⃣ Buscar jogos que esses usuários jogaram, excluindo os já jogados
            var recomendacoesResponse = await _client.SearchAsync<JogoElasticDto>(s => s
                .Query(q => q
                    .Bool(b => b
                        .Must(m => m.Terms(t => t.Field(f => f.UsuariosId).Terms(topOutrosUsuarios)))
                        .MustNot(mn => mn.Terms(t => t.Field(f => f.Id).Terms(jogosIds)))
                    )
                )
                .Aggregations(a => a
                    .Terms("jogos_recomendados", t => t
                        .Field(f => f.Id)
                        .Size(10)
                    )
                )
                .Size(3)
            );

            // 4️⃣ Extrair IDs dos jogos mais frequentes
            var buckets = recomendacoesResponse.Aggregations.Terms("jogos_recomendados")?.Buckets;
            if (buckets == null || !buckets.Any())
                return new List<JogoElasticDto>();

            var jogosRecomendadosIds = buckets.Select(b => Convert.ToInt64(b.Key)).ToList();

            // 5️⃣ Buscar detalhes desses jogos
            var jogosRecomendadosResponse = await _client.SearchAsync<JogoElasticDto>(s => s
                .Query(q => q
                    .Terms(t => t.Field(f => f.Id).Terms(jogosRecomendadosIds))
                )
                .Sort(srt => srt.Descending(f => f.NumeroVendas)) // 🔥 ordenar por popularidade
                .Size(3) // pegar só os 3 mais vendidos
            );

            return jogosRecomendadosResponse.Documents.ToList();
        }

        // 6️⃣ Agregações — métricas de popularidade
        public async Task<IDictionary<string, List<JogoElasticDto>>> ObterTopJogosPorCategoriaAsync(int topN = 3)
        {
            var response = await _client.SearchAsync<JogoElasticDto>(s => s
                .Size(0) // não queremos os hits globais, só agregações
                .Aggregations(a => a
                    .Terms("categorias", t => t
                        .Field(f => f.Categoria.Descricao.Suffix("keyword"))
                        .Size(100) // número máximo de categorias que queremos
                        .Aggregations(aa => aa
                            .TopHits("top_jogos", th => th
                                .Sort(srt => srt.Descending(f => f.NumeroVendas))
                                .Size(topN) // top N jogos por categoria
                            )
                        )
                    )
                )
            );

            if (!response.IsValid)
                throw new Exception(response.ServerError?.ToString() ?? "Erro desconhecido no Elasticsearch");

            // Resultado final: categoria -> lista de jogos
            var result = new Dictionary<string, List<JogoElasticDto>>();

            var categorias = response.Aggregations.Terms("categorias");

            foreach (var bucket in categorias.Buckets)
            {
                var topHits = bucket.TopHits("top_jogos");

                var jogos = topHits.Documents<JogoElasticDto>().ToList();

                result[bucket.Key] = jogos;
            }

            return result;
        }

        private static JogoElasticDto GetJogoElasticDto(Jogo j)
        {
            return new JogoElasticDto
            {
                Id = j.Id,
                Nome = j.Nome,
                Descricao = j.Descricao,
                Tamanho = j.Tamanho,
                Preco = j.Preco,
                IdadeMinima = j.IdadeMinima,
                Ativo = j.Ativo,
                NumeroVendas = j.NumeroVendas,
                Categoria = new CategoriaElasticDto { Descricao = j.Categoria.Descricao, },
                UsuariosId = j.UsuariosDoJogo.Select(uj => uj.UsuarioId).ToList(),
                
            };
        }
    }
}
