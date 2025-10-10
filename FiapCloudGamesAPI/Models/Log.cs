using FCG_API_Jogos.Entidades;

namespace FCG_API_Jogos.Models
{
    public class Log(string mensagem, string criadoPor) : EntidadeBase(criadoPor)
    {
        public string Mensagem { get; set; } = mensagem;
        public DateTime DataHora { get; set; } = DateTime.UtcNow;
    }
}
