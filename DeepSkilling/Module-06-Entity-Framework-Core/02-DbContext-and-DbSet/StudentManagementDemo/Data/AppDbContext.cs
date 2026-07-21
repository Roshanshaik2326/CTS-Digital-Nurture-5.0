using Microsoft.EntityFrameworkCore;
using StudentManagementDemo.Models;

namespace StudentManagementDemo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost,1433;Database=StudentDB;User Id=sa;Password=YourPassword;TrustServerCertificate=True");
        }
    }
}