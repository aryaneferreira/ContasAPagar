using ContasAPagar.DTOs;
using ContasAPagar.Model;

namespace ContasAPagar.Repositories
{
    public interface IWeatherForecastRepository
    {
        IEnumerable<WeatherForecast> GetWeatherForecasts();

        void PostWeatherForecast(WeatherForecast weather);
    }
}
