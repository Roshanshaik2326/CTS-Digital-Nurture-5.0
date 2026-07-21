using System;

Console.WriteLine("===== Logging Best Practices Demo =====");

// Informational log
Console.WriteLine("[INFO] Application started.");

// User action
Console.WriteLine("[INFO] User 'Roshan' logged in successfully.");

// Warning
Console.WriteLine("[WARNING] Password will expire in 5 days.");

// Error handling example
try
{
    int number = 10;
    int result = number / 0;
}
catch (Exception ex)
{
    Console.WriteLine($"[ERROR] {ex.Message}");
}

// Critical event
Console.WriteLine("[CRITICAL] Application terminated unexpectedly.");

// Completion message
Console.WriteLine("[INFO] Logging demo completed successfully.");