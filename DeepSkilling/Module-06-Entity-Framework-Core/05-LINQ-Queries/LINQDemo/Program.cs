using LINQDemo.Data;
using LINQDemo.Models;

using var context = new AppDbContext();

context.Database.EnsureCreated();

// Insert sample data if table is empty
if (!context.Students.Any())
{
    context.Students.AddRange(
        new Student { Name = "Roshan", Age = 20, Department = "CSE" },
        new Student { Name = "Rahul", Age = 22, Department = "ECE" },
        new Student { Name = "Priya", Age = 21, Department = "CSE" },
        new Student { Name = "Anjali", Age = 23, Department = "IT" }
    );

    context.SaveChanges();
}

// WHERE
Console.WriteLine("Students from CSE:");
var cseStudents = context.Students
    .Where(s => s.Department == "CSE")
    .ToList();

foreach (var s in cseStudents)
{
    Console.WriteLine($"{s.Name} - {s.Department}");
}

// FIRSTORDEFAULT
var firstStudent = context.Students.FirstOrDefault();

Console.WriteLine($"\nFirst Student: {firstStudent?.Name}");

// ORDERBY
Console.WriteLine("\nStudents Ordered By Age:");

var orderedStudents = context.Students
    .OrderBy(s => s.Age)
    .ToList();

foreach (var s in orderedStudents)
{
    Console.WriteLine($"{s.Name} - {s.Age}");
}

// COUNT
Console.WriteLine($"\nTotal Students: {context.Students.Count()}");

// SELECT
Console.WriteLine("\nStudent Names:");

var names = context.Students
    .Select(s => s.Name)
    .ToList();

foreach (var name in names)
{
    Console.WriteLine(name);
}