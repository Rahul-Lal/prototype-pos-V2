using Microsoft.EntityFrameworkCore;

namespace YourNamespace // Replace with your actual namespace
{
    public class POSDbContext : DbContext
    {
        public POSDbContext(DbContextOptions<POSDbContext> options)
            : base(options)
        {
        }

        // Define your DbSets here
        // Example:
        // public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure your model here
        }
    }
}