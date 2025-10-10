
namespace FCG_API_Jogos.Entidades.Dtos
{
    public class JogoElasticDto
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; } 
        public decimal Tamanho { get; set; } 
        public int Preco { get; set; } 

        public CategoriaElasticDto Categoria { get; set; }

        public int IdadeMinima { get; set; } 

        public bool Ativo { get; set; } 

        public int NumeroVendas { get; set; }

        public List<long> UsuariosId { get; set; }

        //public ICollection<Avaliacao> Avaliacoes { get; set; }
    }
}
