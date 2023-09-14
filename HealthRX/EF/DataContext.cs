using HealthRX.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthRX.EF
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
