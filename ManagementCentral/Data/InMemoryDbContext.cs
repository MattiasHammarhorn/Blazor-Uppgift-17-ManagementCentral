using ManagementCentral.Models;
using Microsoft.EntityFrameworkCore;

namespace ManagementCentral.Data
{
    public class InMemoryDbContext : DbContext
    {
        public InMemoryDbContext(DbContextOptions<InMemoryDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Device> Devices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
