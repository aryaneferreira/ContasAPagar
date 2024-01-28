using ContasAPagar.Dto;
using ContasAPagar.Model;

namespace ContasAPagar.Repositories
{
    public interface IWeatherForecastRepository
    {
        IEnumerable<WeatherForecast> GetWeatherForecasts();

        void PostWeatherForecast(WeatherForecastInputModel weather);
    }
}
