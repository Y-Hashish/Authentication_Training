using System.Net.WebSockets;
using Auth.Models;
using AuthProj.Models;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Services;

namespace AuthProj.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IAuth auth;
        public AuthController(IAuth auth)
        {
            this.auth = auth;
        }
        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync(RegisterModel model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var resutl = await auth.Register(model);
            if(!resutl.IsAuth)
            {
                return BadRequest(resutl.Message);
            }
            return Ok(resutl);
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync(Getuser model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var resutl = await auth.GetToken(model);
            if(!resutl.IsAuth)
                return BadRequest(resutl.Message);
            return Ok(resutl);  
        }
    }
}
