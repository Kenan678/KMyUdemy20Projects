using Microsoft.EntityFrameworkCore;
using Project6_ApiWeather.Properties.Entities;

namespace Project6_ApiWeather.Properties.Context
{
    public class WheatherContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        
            optionsBuilder.UseSqlServer("Server=AZLOTO_217\\SQLEXPRESS;Database=Db6Project20;User Id=kanan;Password=1;TrustServerCertificate=True;");


        }
        public DbSet<City> Cities { get; set; } 
    }

} 
  