using Microsoft.EntityFrameworkCore;
using RelationshipDemo.Models;

namespace RelationshipDemo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost,1433;Database=RelationshipDB;User Id=sa;Password=Roshan@230206;TrustServerCertificate=True");
        }
    }
}