using System;

public sealed class ConfigurationManager
{
    // Holds the single instance
    private static ConfigurationManager? instance;

    // Private constructor prevents external object creation
    private ConfigurationManager()
    {
        Console.WriteLine("Configuration Manager Initialized.");
    }

    // Returns the single instance
    public static ConfigurationManager GetInstance()
    {
        if (instance == null)
        {
            instance = new ConfigurationManager();
        }

        return instance;
    }

    // Business method
    public void DisplayConfiguration()
    {
        Console.WriteLine("\n===== Application Configuration =====");
        Console.WriteLine("Application : Cognizant Digital Nurture");
        Console.WriteLine("Version     : 1.0");
        Console.WriteLine("Environment : Development");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Getting First Instance...\n");

        ConfigurationManager config1 = ConfigurationManager.GetInstance();
        config1.DisplayConfiguration();

        Console.WriteLine("\nGetting Second Instance...\n");

        ConfigurationManager config2 = ConfigurationManager.GetInstance();

        if (Object.ReferenceEquals(config1, config2))
        {
            Console.WriteLine("Result : Only ONE instance exists.");
        }
        else
        {
            Console.WriteLine("Result : Multiple instances created.");
        }
    }
}