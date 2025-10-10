using FCG_API_Jogos.Models;

namespace FCG_API_Jogos.Services.IService
{
    public interface ITokenService
    {
        string GerarToken(Usuario usuario);

        long GetUsuarioId(string token);
    }
}
