using Microsoft.EntityFrameworkCore;
using LINQDemo.Models;

namespace LINQDemo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost,1433;Database=LINQDemoDB;User Id=sa;Password=Roshan@230206;TrustServerCertificate=True");
        }
    }
}