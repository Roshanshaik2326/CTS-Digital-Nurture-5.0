using RepositoryDemo.Models;

namespace RepositoryDemo.Repositories
{
    public interface IStudentRepository
    {
        void AddStudent(Student student);

        List<Student> GetAllStudents();
    }
}