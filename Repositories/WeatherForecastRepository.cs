using ContasAPagar.Db;
using ContasAPagar.Dto;
using ContasAPagar.Model;
using Microsoft.Data.SqlClient;

namespace ContasAPagar.Repositories
{
    public class WeatherForecastRepository: IWeatherForecastRepository
    {
        private readonly ContasAPagarContext _context;
        
        public WeatherForecastRepository(ContasAPagarContext context)
        {
            _context = context;
        }
        public IEnumerable<WeatherForecast> GetWeatherForecasts()
        {
            var resultado = new List<WeatherForecast>();
            resultado = _context.WeatherForecasts.ToList();

            return resultado;
        }

        public void PostWeatherForecast(WeatherForecastInputModel weather)
        {
            WeatherForecast _weather = new WeatherForecast()
            {
                WeatherForecastDate = weather.WeatherForecastDate,
                TemperatureC = weather.TemperatureC,
                TemperatureF = weather.TemperatureF,
                Summary = weather.Summary
            };
            _context.WeatherForecasts.Add(_weather);
            _context.SaveChanges();
        }
    }
}
