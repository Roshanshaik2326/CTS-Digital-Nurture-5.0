using MigrationDemo.Data;

Console.WriteLine("=================================");
Console.WriteLine(" Code First Migration Demo");
Console.WriteLine("=================================");

using var context = new AppDbContext();

Console.WriteLine("Database Connected Successfully.");
Console.WriteLine("Migration Ready.");