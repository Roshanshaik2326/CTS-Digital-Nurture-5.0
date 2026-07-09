using System;
using System.Collections.Generic;

// Observer Interface
public interface IInvestor
{
    void Update(string stockName, double price);
}

// Concrete Observer
public class Investor : IInvestor
{
    private readonly string name;

    public Investor(string name)
    {
        this.name = name;
    }

    public void Update(string stockName, double price)
    {
        Console.WriteLine($"{name} received update: {stockName} price is ₹{price}");
    }
}

// Subject
public class Stock
{
    private readonly List<IInvestor> investors = new();

    public string Name { get; }

    public Stock(string name)
    {
        Name = name;
    }

    public void Subscribe(IInvestor investor)
    {
        investors.Add(investor);
    }

    public void Unsubscribe(IInvestor investor)
    {
        investors.Remove(investor);
    }

    public void SetPrice(double price)
    {
        Console.WriteLine($"\nStock Price Updated: {Name} = ₹{price}\n");

        foreach (var investor in investors)
        {
            investor.Update(Name, price);
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Observer Pattern ===");

        Stock tcs = new Stock("TCS");

        Investor investor1 = new Investor("Roshan");
        Investor investor2 = new Investor("Rahul");
        Investor investor3 = new Investor("Priya");

        tcs.Subscribe(investor1);
        tcs.Subscribe(investor2);
        tcs.Subscribe(investor3);

        tcs.SetPrice(3850.75);
    }
}