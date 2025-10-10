using FCG_API_Jogos.Context;
using FCG_API_Jogos.Models;
using FCG_API_Jogos.Services.IService;

namespace FCG_API_Jogos.Services
{
    public class UsuarioService
	{
        public bool UsuarioIsAdmin(Usuario usuario) => usuario.PerfilId == 1;

        public string ObterHashSenha(string senha)
        {
            return senha;
        }

    }
}
