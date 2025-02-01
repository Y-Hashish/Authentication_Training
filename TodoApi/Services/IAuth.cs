using System.IdentityModel.Tokens.Jwt;
using Auth.Models;
using AuthProj.Models;
using TodoApi.Models;

namespace TodoApi.Services
{
    public interface IAuth
    {
        Task<AuthModel> Register(RegisterModel model);
        Task<AuthModel> GetToken(Getuser model);
    }
}
