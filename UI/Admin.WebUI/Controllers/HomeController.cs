using Admin.WebUI.Models;
using Admin.WebUI.Settings;
using APIGateway.Web.Client;
using CommonEntities.Result;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;
using static CommonEntities.Enums;

namespace Admin.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration config;

        public HomeController(ILogger<HomeController> logger , IConfiguration _config)
        {
            _logger = logger;
            this.config = _config;

        }

        public async Task<ServiceResultWithData<string>>  Index()
        {
            ServiceResultWithData<string> result = new ServiceResultWithData<string>();
            //APIGatewayWebClient _APIGatewayWebClient = new APIGatewayWebClient( _config: this.config, aPIGatewayWebClientMethodName: APIGatewayWebClientMethodName.WeatherForecast);
            //result.Data = await APIGatewayWebClient.WeatherForecast(
            //    _APIGatewayWebClient.apiUrl,
            //    new CommonEntities.Base.EmptyRequest() { }
            //    );
            return result;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}