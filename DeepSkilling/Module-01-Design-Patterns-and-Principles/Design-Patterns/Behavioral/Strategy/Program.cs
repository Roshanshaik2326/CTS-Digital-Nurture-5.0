using System;

// Strategy Interface
public interface IPaymentStrategy
{
    void Pay(double amount);
}

// Concrete Strategy - UPI
public class UpiPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid ₹{amount} using UPI.");
    }
}

// Concrete Strategy - Credit Card
public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid ₹{amount} using Credit Card.");
    }
}

// Concrete Strategy - PayPal
public class PayPalPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid ₹{amount} using PayPal.");
    }
}

// Context
public class PaymentContext
{
    private IPaymentStrategy strategy;

    public PaymentContext(IPaymentStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void SetStrategy(IPaymentStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void ProcessPayment(double amount)
    {
        strategy.Pay(amount);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Strategy Pattern ===\n");

        PaymentContext payment = new PaymentContext(new UpiPayment());
        payment.ProcessPayment(1500);

        payment.SetStrategy(new CreditCardPayment());
        payment.ProcessPayment(2500);

        payment.SetStrategy(new PayPalPayment());
        payment.ProcessPayment(3500);
    }
}