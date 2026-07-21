using Microsoft.EntityFrameworkCore;
using RelationshipDemo.Data;
using RelationshipDemo.Models;

using var context = new AppDbContext();

context.Database.EnsureCreated();

// Insert sample data
if (!context.Departments.Any())
{
    var department = new Department
    {
        DepartmentName = "Information Technology",
        Employees = new List<Employee>
        {
            new Employee
            {
                Name = "Roshan",
                Salary = 50000
            },
            new Employee
            {
                Name = "Rahul",
                Salary = 45000
            }
        }
    };

    context.Departments.Add(department);
    context.SaveChanges();
}

// Retrieve data with relationship
var departments = context.Departments
    .Include(d => d.Employees)
    .ToList();

foreach (var department in departments)
{
    Console.WriteLine($"\nDepartment: {department.DepartmentName}");

    foreach (var employee in department.Employees)
    {
        Console.WriteLine($"Employee: {employee.Name} | Salary: {employee.Salary}");
    }
}