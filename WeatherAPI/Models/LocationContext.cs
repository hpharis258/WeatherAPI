using Microsoft.EntityFrameworkCore;

namespace WeatherAPI.Models
{
    public class LocationContext : DbContext
    {
        public LocationContext (DbContextOptions<LocationContext> options) : base(options) { }

        public DbSet<Location> Locations { get; set; } = null;
    }

}
