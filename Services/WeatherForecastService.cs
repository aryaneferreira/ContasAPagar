using ContasAPagar.Dto;
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

        public void PostWeatherForecast(WeatherForecastInputModel weather)
        {
            
            _weatherForecastRepository.PostWeatherForecast(weather);
        }
    }
}
