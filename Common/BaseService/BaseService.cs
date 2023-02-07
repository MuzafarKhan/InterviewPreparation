using CommonEntities.Auth;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BaseService
{
    public class BaseService
    {

        public BaseService()
        {
                
        }
        public T GetConfigurationSetting<T>(string key, T value)
        {
            return InMemoryCache.InMemoryCache<T>.GetConfigurationSetting(key, value);
        }

        
        #region private Method
        public string GetToken(UserInfo user, string JwtKey, string JwtIssuer, string JwtAudience, string JwtSubject)
        {
            var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, JwtSubject),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("Id", user.Id.ToString()),
                        new Claim("Email", user.Email)
                    };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtKey));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                JwtIssuer,
                JwtAudience,
                claims,
                expires: DateTime.UtcNow.AddMinutes(10),
                signingCredentials: signIn);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        #endregion
    }
}