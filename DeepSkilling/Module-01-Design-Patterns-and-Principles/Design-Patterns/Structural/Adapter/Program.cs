using System;

// Existing Service
public class StripePayment
{
    public void MakeStripePayment()
    {
        Console.WriteLine("Payment completed using Stripe.");
    }
}

// Target Interface
public interface IPaymentGateway
{
    void Pay();
}

// Adapter
public class StripeAdapter : IPaymentGateway
{
    private readonly StripePayment stripePayment = new StripePayment();

    public void Pay()
    {
        stripePayment.MakeStripePayment();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Adapter Pattern ===\n");

        IPaymentGateway payment = new StripeAdapter();

        payment.Pay();
    }
}