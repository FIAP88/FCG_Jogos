using System.ComponentModel.DataAnnotations.Schema;

namespace FCG_API_Jogos.Models
{
    public class JogoUsuario
    {
        public long UsuarioId { get; set; }
        [NotMapped]
        public Usuario Usuario { get; set; }

        public long JogoId { get; set; }

        public Jogo Jogo { get; set; }

        public Guid PagamentoId { get; set; }

        [NotMapped]
        public string Status { get; set; }
    }
}
