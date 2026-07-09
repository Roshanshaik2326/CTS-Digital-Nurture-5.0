using System;

// Product Interface
public interface IPayment
{
    void Pay();
}

// Concrete Products
public class CreditCardPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Payment completed using Credit Card.");
    }
}

public class UPIPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Payment completed using UPI.");
    }
}

public class PayPalPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Payment completed using PayPal.");
    }
}

// Factory
public class PaymentFactory
{
    public static IPayment CreatePayment(string paymentType)
    {
        return paymentType.ToLower() switch
        {
            "creditcard" => new CreditCardPayment(),
            "upi" => new UPIPayment(),
            "paypal" => new PayPalPayment(),
            _ => throw new ArgumentException("Invalid Payment Method")
        };
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Factory Method Pattern ===\n");

        IPayment payment1 = PaymentFactory.CreatePayment("upi");
        payment1.Pay();

        IPayment payment2 = PaymentFactory.CreatePayment("creditcard");
        payment2.Pay();

        IPayment payment3 = PaymentFactory.CreatePayment("paypal");
        payment3.Pay();
    }
}