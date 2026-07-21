using Serilog;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .CreateLogger();

Log.Information("Application Started");
Log.Debug("Loading configuration...");
Log.Warning("Low disk space.");
Log.Error("Database connection failed.");
Log.Fatal("Unexpected system failure.");

Log.CloseAndFlush();

Console.WriteLine("Serilog demonstration completed.");