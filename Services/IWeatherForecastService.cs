using ContasAPagar.DTOs;
using ContasAPagar.Model;

namespace ContasAPagar.Services
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> GetWeatherForecasts();
        void PostWeatherForecast(WeatherForecast weather);
    }
}
