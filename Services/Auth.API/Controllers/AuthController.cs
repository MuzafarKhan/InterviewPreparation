using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using CommonEntities.Auth;
using Auth.API.Service;
using BaseControllers;

namespace Auth.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : AuthApiBaseController
    {

        public IConfiguration _configuration;
        public IAuthService _authService;

        public AuthController(IConfiguration config, IAuthService authService)
        {
            _configuration = config;
            _authService = authService;
        }
        [HttpPost]
        [Route("CreateToken")]
        public async Task<IActionResult> CreateToken(UserInfo _userData)
        {
            var createTokenResult = await _authService.CreateToken(_userData);

            if (createTokenResult.IsError())
            {
                return BadRequest();
            }

            var response = new CreateTokenControllerResponse()
            {
                Payload = createTokenResult.Data
            };

            return Ok(response);
        }


        [Route("RegisterUser")]
        [HttpPost]
        public async Task<IActionResult> RegisterUser(UserInfo _userData)
        {
            var registerResponse = await _authService.RegisterUser(_userData);

            if (registerResponse.IsError())
            {
                return BadRequest();
            }

            var response = new RegisterControllerResponse()
            {
                Payload = registerResponse.Data
            };

            return Ok(response);
        }

        
    }
}

