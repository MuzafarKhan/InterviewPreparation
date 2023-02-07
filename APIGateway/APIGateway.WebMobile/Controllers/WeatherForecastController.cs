using Microsoft.AspNetCore.Mvc;

namespace APIGateway.WebMobile.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecasteController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecasteController> _logger;

        public WeatherForecasteController(ILogger<WeatherForecasteController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecaste")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}