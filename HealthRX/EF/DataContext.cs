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

        public DbSet<Product> Products { get; set; }

        public DbSet<Catagory> Catagories{ get; set; }
    }
}
