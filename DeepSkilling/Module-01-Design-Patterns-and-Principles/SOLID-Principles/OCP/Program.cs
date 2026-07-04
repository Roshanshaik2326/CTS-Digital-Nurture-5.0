using System;


public abstract class Customer
{
    public abstract double GetDiscount(double amount);
}

public class RegularCustomer : Customer
{
    public override double GetDiscount(double amount)
    {
        return amount * 0.10;
    }
}

public class PremiumCustomer : Customer
{
    public override double GetDiscount(double amount)
    {
        return amount * 0.20;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Customer regular = new RegularCustomer();
        Customer premium = new PremiumCustomer();

        Console.WriteLine($"Regular Customer Discount: {regular.GetDiscount(1000)}");

        Console.WriteLine($"Premium Customer Discount: {premium.GetDiscount(1000)}");
    }
}