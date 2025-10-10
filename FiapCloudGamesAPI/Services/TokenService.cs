using FCG_API_Jogos.Models;
using FCG_API_Jogos.Models.Configuration;
using FCG_API_Jogos.Services.IService;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AutenticacaoEAutorizacaoCorreto.Services
{
    public class TokenService : ITokenService
    {
        private readonly ConfigSecret _configSecret;

        private TokenValidationParameters GetValidationParameters(byte[] key) => new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            ValidateIssuer = false,
            ValidateAudience = false,
            ClockSkew = TimeSpan.Zero
        };


        public TokenService(IOptions<ConfigSecret> configSecret)
        {
            _configSecret = configSecret.Value;
        }

        public Guid GetUsuarioId(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configSecret.Secret);

            var validationParameters = GetValidationParameters(key);

            try
            {
                var principal = tokenHandler.ValidateToken(token, validationParameters, out SecurityToken validatedToken);
                var userIdClaim = principal.FindFirst(ClaimTypes.NameIdentifier);

                if (userIdClaim != null && Guid.TryParse(userIdClaim.Value, out Guid userId))
                {
                    return userId;
                }

                throw new SecurityTokenException("Invalid token: User ID not found.");
            }
            catch
            {
                throw new SecurityTokenException("Invalid token.");
            }
        }

        public string GetUsuarioName(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configSecret.Secret);

            var validationParameters = GetValidationParameters(key);

            try
            {
                var principal = tokenHandler.ValidateToken(token, validationParameters, out SecurityToken validatedToken);
                var userNameClaim = principal.FindFirst(ClaimTypes.Name);

                if (userNameClaim != null)
                {
                    return userNameClaim.Value;
                }

                throw new SecurityTokenException("Invalid token: User Name not found.");
            }
            catch
            {
                throw new SecurityTokenException("Invalid token.");
            }
        }
    }
}
