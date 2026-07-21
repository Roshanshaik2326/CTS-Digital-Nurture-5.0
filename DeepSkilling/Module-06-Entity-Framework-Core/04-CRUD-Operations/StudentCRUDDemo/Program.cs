using StudentCRUDDemo.Data;
using StudentCRUDDemo.Models;

using var context = new AppDbContext();

// Create database if it doesn't exist
context.Database.EnsureCreated();

// --------------------
// CREATE
// --------------------
var student = new Student
{
    Name = "Roshan",
    Age = 20,
    Department = "Computer Science"
};

context.Students.Add(student);
context.SaveChanges();

Console.WriteLine("Student Added Successfully.");

// --------------------
// READ
// --------------------
Console.WriteLine("\nStudent Records:");

var students = context.Students.ToList();

foreach (var s in students)
{
    Console.WriteLine($"{s.Id} | {s.Name} | {s.Age} | {s.Department}");
}

// --------------------
// UPDATE
// --------------------
var updateStudent = context.Students.FirstOrDefault();

if (updateStudent != null)
{
    updateStudent.Department = "Information Technology";
    context.SaveChanges();

    Console.WriteLine("\nStudent Updated Successfully.");
}

// --------------------
// DELETE
// --------------------
var deleteStudent = context.Students.FirstOrDefault();

if (deleteStudent != null)
{
    context.Students.Remove(deleteStudent);
    context.SaveChanges();

    Console.WriteLine("Student Deleted Successfully.");
}