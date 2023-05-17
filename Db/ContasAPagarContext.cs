using ContasAPagar.Model;
using ContasAPagar.Models;
using Microsoft.EntityFrameworkCore;

namespace ContasAPagar.Db
{
    public class ContasAPagarContext : DbContext
    {
        public DbSet<WeatherForecast> WeatherForecasts { get; set;}
        public DbSet<User> Users { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS01;Database=ContasAPagarDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
