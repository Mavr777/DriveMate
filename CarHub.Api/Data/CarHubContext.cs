using Microsoft.EntityFrameworkCore;
using CarHub.Api.Models;

namespace CarHub.Api.Data
{
    public class CarHubContext : DbContext
    {
        public CarHubContext(DbContextOptions<CarHubContext> options) : base(options)
        {
        }

        // This will represent our Cars table
        public DbSet<Car> Cars { get; set; }
    }
}
