using System.IdentityModel.Tokens.Jwt;
using Auth.Models;
using TodoApi.Models;

namespace TodoApi.Services
{
    public interface IAuth
    {
        Task<AuthModel> Register(RegisterModel model);
        Task<JwtSecurityToken> CreateTokenAsync(ApplicationUser user);
    }
}
