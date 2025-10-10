using FCG_API_Jogos.Models;

namespace FCG_API_Jogos.Entidades.Requests
{
    public class AvaliacaoRequest : BaseRequest
    {
        public long IdUsuario { get; set; }

        public long IdJogo { get; set; }

        public int Nota { get; set; }

        public string Comentario { get; set; }
    }
}
