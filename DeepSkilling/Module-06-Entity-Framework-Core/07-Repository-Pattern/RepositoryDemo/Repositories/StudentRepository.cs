using RepositoryDemo.Data;
using RepositoryDemo.Models;

namespace RepositoryDemo.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _context = new();

        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }
    }
}