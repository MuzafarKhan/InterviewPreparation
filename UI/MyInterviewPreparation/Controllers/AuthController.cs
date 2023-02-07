using APIGateway.WebMobile.Client;
using CommonEntities.Auth;
using CommonEntities.Result;
using Microsoft.AspNetCore.Mvc;
using MyInterviewPreparation.Settings;
using static CommonEntities.Enums;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyInterviewPreparation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration config;
        public AuthController(IConfiguration _config)
        {
            this.config = _config;
        }
        [HttpPost]
        [Route("CreateToken")]
        public async Task<ServiceResultWithData<string>> CreateToken(UserInfo _userData)
        {
            ServiceResultWithData<string> result = new ServiceResultWithData<string>();

            var proxy2 = new APIGatewayWebMobileProxy(
                _config: this.config,
                aPIGatewayWebMobileClientMethodName:
                APIGatewayWebMobileClientMethodName.CreateToken);

            result.Data = await APIGatewayWebMobileClient.CreateToken(
                proxy2.apiUrl,
                _userData
                );
            return result;
        }


        [Route("RegisterUser")]
        [HttpPost]
        public async Task<ServiceResultWithData<string>> RegisterUser(UserInfo _userData)
        {
            ServiceResultWithData<string> result = new ServiceResultWithData<string>();

            var proxy2 = new APIGatewayWebMobileProxy(
                _config: this.config,
                aPIGatewayWebMobileClientMethodName:
                APIGatewayWebMobileClientMethodName.Register);

            result.Data = await APIGatewayWebMobileClient.Register(
                proxy2.apiUrl,
                _userData
                );
            return result;
        }
    }
}
