using ContasAPagar.Db;
using ContasAPagar.Model;

namespace ContasAPagar.Repositories
{
    public class WeatherForecastRepository: IWeatherForecastRepository
    {
        private readonly ContasAPagarContext context = new ContasAPagarContext();
        public IEnumerable<WeatherForecast> GetWeatherForecasts()
        {
            return this.context.WeatherForecasts.ToList();
        }

        public void PostWeatherForecast(WeatherForecast weather)
        {
            using (var context = this.context)
            {

                context.WeatherForecasts.Add(weather);
                context.SaveChanges();
            }
        }
    }
}
