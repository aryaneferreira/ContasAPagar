using ContasAPagar.Dto;
using ContasAPagar.Model;

namespace ContasAPagar.Services
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> GetWeatherForecasts();
        void PostWeatherForecast(WeatherForecastInputModel weather);
    }
}
