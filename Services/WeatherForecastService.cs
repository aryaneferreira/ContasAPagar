using ContasAPagar.DTOs;
using ContasAPagar.Model;
using ContasAPagar.Repositories;

namespace ContasAPagar.Services
{
    public class WeatherForecastService: IWeatherForecastService
    {
        private IWeatherForecastRepository _weatherForecastRepository;

        public WeatherForecastService(IWeatherForecastRepository repository) 
        {
            _weatherForecastRepository = repository;
        }
        public IEnumerable<WeatherForecast> GetWeatherForecasts()
        {
            return _weatherForecastRepository.GetWeatherForecasts();
        }

        public void PostWeatherForecast(WeatherForecast weather)
        {
            //WeatherForecast we = new WeatherForecast()
            //{
            //    Date = weatherDTO.Date,
            //    TemperatureC = weatherDTO.TemperatureC,
            //    TemperatureF = 32 + (int)(weatherDTO.TemperatureC / 0.5556),
            //    Summary = weatherDTO.Summary
            //};
            _weatherForecastRepository.PostWeatherForecast(weather);
        }
    }
}
