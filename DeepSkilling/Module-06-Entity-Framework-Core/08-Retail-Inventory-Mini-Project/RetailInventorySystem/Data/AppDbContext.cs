using Microsoft.EntityFrameworkCore;
using RetailInventorySystem.Models;

namespace RetailInventorySystem.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost,1433;Database=RetailInventoryDB;User Id=sa;Password=Roshan@230206;TrustServerCertificate=True");
        }
    }
}