using FCG_API_Jogos.Entidades;

namespace FCG_API_Jogos.Models
{
    public class Permissao(string descricao, string criadoPor) : EntidadeBase(criadoPor)
    {
        public string Descricao { get; set; } = descricao;

        public ICollection<PerfilPermissao> PerfilPermissoes { get; set; } = [];
    }
}
