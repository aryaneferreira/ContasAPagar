using ContasAPagar.Dto;
using ContasAPagar.Model;
using ContasAPagar.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContasAPagar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherForecastService)
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet(Name = "GetWeatherForecasts")]
        public IEnumerable<WeatherForecast> GetWeatherForecasts()
        {
            return _weatherForecastService.GetWeatherForecasts();
        }

        [HttpPost(Name = "PostWeatherForecast")]
        public void PostWeatherForecast(WeatherForecastInputModel weather)
        {
            _weatherForecastService.PostWeatherForecast(weather);
        }
    }
}