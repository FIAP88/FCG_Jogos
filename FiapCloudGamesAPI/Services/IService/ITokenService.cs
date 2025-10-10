using FCG_API_Jogos.Models;

namespace FCG_API_Jogos.Services.IService
{
    public interface ITokenService
    {
        Guid GetUsuarioId(string token);
        string GetUsuarioName(string token);
    }
}
