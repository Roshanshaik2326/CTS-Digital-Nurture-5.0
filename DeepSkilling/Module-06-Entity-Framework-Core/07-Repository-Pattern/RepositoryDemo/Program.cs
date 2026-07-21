using RepositoryDemo.Models;
using RepositoryDemo.Repositories;

IStudentRepository repository = new StudentRepository();

repository.AddStudent(new Student
{
    Name = "Roshan",
    Age = 20
});

Console.WriteLine("Student Added Successfully.\n");

var students = repository.GetAllStudents();

foreach (var student in students)
{
    Console.WriteLine($"{student.Id} | {student.Name} | {student.Age}");
}