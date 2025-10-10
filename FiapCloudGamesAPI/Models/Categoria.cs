using FCG_API_Jogos.Entidades;
using System.Text.Json.Serialization;

namespace FCG_API_Jogos.Models
{
    public class Categoria(string descricao, string criadoPor) : EntidadeBase(criadoPor)
    {
        public string Descricao { get; set; } = descricao;
        [JsonIgnore]
        public ICollection<Jogo> Jogos { get; set; }
      
    }
}
