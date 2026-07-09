using System;

// Product
public class Laptop
{
    public string Processor { get; set; } = "";
    public string RAM { get; set; } = "";
    public string Storage { get; set; } = "";

    public void Display()
    {
        Console.WriteLine("===== Laptop Configuration =====");
        Console.WriteLine($"Processor : {Processor}");
        Console.WriteLine($"RAM       : {RAM}");
        Console.WriteLine($"Storage   : {Storage}");
    }
}

// Builder
public class LaptopBuilder
{
    private readonly Laptop laptop = new Laptop();

    public LaptopBuilder SetProcessor(string processor)
    {
        laptop.Processor = processor;
        return this;
    }

    public LaptopBuilder SetRAM(string ram)
    {
        laptop.RAM = ram;
        return this;
    }

    public LaptopBuilder SetStorage(string storage)
    {
        laptop.Storage = storage;
        return this;
    }

    public Laptop Build()
    {
        return laptop;
    }
}

class Program
{
    static void Main()
    {
        Laptop gamingLaptop = new LaptopBuilder()
            .SetProcessor("Intel Core i7")
            .SetRAM("16 GB")
            .SetStorage("1 TB SSD")
            .Build();

        gamingLaptop.Display();
    }
}