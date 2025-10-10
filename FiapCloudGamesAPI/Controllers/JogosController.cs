using FCG_API_Jogos.Entidades;
using FCG_API_Jogos.Services;
using FCG_API_Jogos.Context;
using FCG_API_Jogos.Entidades.Dtos;
using FCG_API_Jogos.Entidades.Requests;
using FCG_API_Jogos.Infra;
using FCG_API_Jogos.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using System.Text.Json;

namespace FCG_API_Jogos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [SwaggerTag("Gerenciamento de Jogos")]
    public class JogosController(
        AppDbContext context, 
        BaseLogger<Jogo> logger, 
        IHttpContextAccessor httpContext,
        IJogoElasticService elasticService,
        PagamentoApiService pagamentoApi) :
        BaseControllerCrud<Jogo>(context, logger, httpContext)
    {

        private readonly IJogoElasticService _elasticService = elasticService;
        private readonly PagamentoApiService _pagamentoApi = pagamentoApi;

        [HttpGet]
        [Authorize(Policy = "BuscarJogos")]
        [SwaggerOperation("Buscar todos os jogos")]
        public async Task<ActionResult<IEnumerable<JogoDto>>> GetPermissoes() => await GetAll<JogoDto>();

        [HttpGet("Buscar")]
        public async Task<IActionResult> Buscar([FromQuery] string termo)
        {
            var resultados = await _elasticService.BuscarAsync(termo);
            return Ok(resultados);
        }

        [HttpGet("{id}")]
        [Authorize(Policy = "BuscarJogoPorId")]
        [SwaggerOperation("Buscar jogo por ID")]
        public async Task<ActionResult<Jogo>> GetJogo(long id) => await GetById(id);

        [HttpPut("{id}")]
        [Authorize(Policy = "AtualizarJogo")]
        [SwaggerOperation("Atualizar jogo por ID")]
        public async Task<IActionResult> PutJogo(long id, Jogo jogoRequest)
        {
            Jogo atualizaJogo = ConvertTypes(jogoRequest);
            var result = await Update(id, atualizaJogo);
            await _elasticService.AtualizarAsync(atualizaJogo);
            return Ok(result);
        }

        [HttpPost("Indexar")]
        [Authorize(Policy = "CriarJogos")]
        [SwaggerOperation("Indexar Jogos")]
        public async Task<IActionResult> IndexarJogos()
        {
            var todosJogos = await _context.Jogos.Include(j => j.Categoria).Include(j => j.UsuariosDoJogo).ToListAsync();
            foreach(var jogo in todosJogos)
            {
                await _elasticService.IndexarAsync(jogo);
            }
            return Ok();
        }


        [HttpPost]
        [Authorize(Policy = "CriarJogos")]
        [SwaggerOperation("Criar novo jogo")]
        public async Task<ActionResult<Jogo>> PostJogo(JogoRequest jogoRequest)
        {
            Jogo novoJogo = ConvertTypes(jogoRequest);
            var result = await Create(novoJogo);
            await _elasticService.IndexarAsync(novoJogo);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        [Authorize(Policy = "DeletarJogo")]
        [SwaggerOperation("Deletar jogo por ID")]
        public async Task<IActionResult> DeleteJogo(long id)
        {
            var result = await Delete(id);
            await _elasticService.RemoverAsync(id.ToString());
            return Ok(result);
        }

        [HttpGet("MeusJogos")]
        [Authorize(Policy = "MeusJogos")]
        [SwaggerOperation("Buscar meus jogos")]
        public async Task<ActionResult<List<Jogo>>> GetMeusJogos()
        {
            var jogos = await _context.JogosUsuarios.IgnoreAutoIncludes().Include(ju => ju.Jogo)
                .Where(u => u.UsuarioId == IdUsuarioLogado)
                .Select(ju => ConvertTypes<JogoDto>(ju.Jogo))
            .ToListAsync();
            return Ok(jogos);
        }

        [HttpPost("ComprarJogo")]
        [Authorize(Policy = "AdicionarJogo")]
        [SwaggerOperation("Comprar jogo")]
        public async Task<IActionResult> ComprarJogo(long idJogo)
        {
            if(await _context.JogosUsuarios.AsNoTracking().CountAsync(j => j.UsuarioId == IdUsuarioLogado && j.JogoId == idJogo ) != 0)
                return BadRequest("Jogo já adicionado à sua lista de jogos.");

            var jogo = await _context.Jogos.FindAsync(idJogo);

            if (jogo == null)
                return BadRequest("Jogo não cadastrado no sistema.");

            var pagamentoResponse = await _pagamentoApi.CriarTransacaoAsync(new PagamentoRequest()
            {
                Valor = jogo.Preco,
                CorrelationId = new Guid(),
                ClienteId = IdUsuarioLogado,
                PedidoId = jogo.Id
            });
            if (pagamentoResponse.IsSuccessStatusCode)
            {
                string jsonResult = await pagamentoResponse.Content.ReadAsStringAsync();

                using var doc = JsonDocument.Parse(jsonResult);
                Guid pagamentoId = doc.RootElement.GetProperty("result").GetProperty("pagamentoId").GetGuid();

                await _context.JogosUsuarios.AddAsync(new JogoUsuario { UsuarioId = IdUsuarioLogado, JogoId = idJogo, PagamentoId = pagamentoId });
                await _context.SaveChangesAsync();
                var msgOK = $"Jogo com ID: {idJogo} para usuário com ID: {IdUsuarioLogado}, aguardando confirmação de pagamento, consultar pedido com Id {pagamentoId}";
                _logger.LogInformation(msgOK);
                return Ok(msgOK);
            }
            else
            {
                return StatusCode(500, "Não foi possivel realizar o pedido");
            }
        }

        [HttpPost("Sugerir")]
        public async Task<IActionResult> Sugerir()
        {
            var sugestoes = await _elasticService.SugerirJogosParaUsuarioAsync(IdUsuarioLogado);
            return Ok(sugestoes);
        }

        [HttpGet("Populares")]
        public async Task<IActionResult> MaisPopulares([FromQuery] int top = 5)
        {
            var metricas = await _elasticService.ObterTopJogosPorCategoriaAsync(top);
            return Ok(metricas);
        }

        [HttpGet("ConsultarPedido")]
        public async Task<IActionResult> ConsultarPedido([FromQuery] Guid pedido)
        {
            return Ok(await _pagamentoApi.ObterStatusTransacaoAsync(pedido));
        }
        protected override bool EntityExists(long id) => _context.Jogos.Any(e => e.Id == id);
    }
}
