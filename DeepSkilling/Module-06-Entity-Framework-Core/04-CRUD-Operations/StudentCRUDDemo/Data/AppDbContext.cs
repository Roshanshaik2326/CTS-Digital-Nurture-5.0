using Microsoft.EntityFrameworkCore;
using StudentCRUDDemo.Models;

namespace StudentCRUDDemo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost,1433;Database=StudentCRUDDB;User Id=sa;Password=Roshan@230206;TrustServerCertificate=True");
        }
    }
}