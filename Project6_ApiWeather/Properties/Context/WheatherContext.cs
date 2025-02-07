using Microsoft.EntityFrameworkCore;

namespace Project6_ApiWeather.Properties.Context
{
    public class WheatherContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(server
        }
    }
}
