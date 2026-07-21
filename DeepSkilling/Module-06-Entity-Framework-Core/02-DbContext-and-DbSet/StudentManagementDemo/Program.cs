using StudentManagementDemo.Data;

Console.WriteLine("=================================");
Console.WriteLine(" Student Management System");
Console.WriteLine("=================================");

using var context = new AppDbContext();

Console.WriteLine("Database Connected Successfully.");

Console.WriteLine($"DbSet Available : {context.Students.GetType().Name}");