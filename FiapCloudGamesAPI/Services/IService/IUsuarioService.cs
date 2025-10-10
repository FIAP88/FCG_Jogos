using FCG_API_Jogos.Models;

namespace FCG_API_Jogos.Services.IService
{
    public interface IUsuarioService
    {
        bool UsuarioIsAdmin(Usuario usuario);
        string NomeUsuario(Usuario usuario);
    }
}
