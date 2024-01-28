using ContasAPagar.Model;
using ContasAPagar.Models;
using Microsoft.EntityFrameworkCore;

namespace ContasAPagar.Db
{
    public class ContasAPagarContext : DbContext
    {
        public DbSet<WeatherForecast> WeatherForecasts { get; set;}
        public DbSet<TipoTransacao> TiposTransacao { get; set; }
        public ContasAPagarContext(DbContextOptions<ContasAPagarContext> options) : base(options) { }
    }
}
