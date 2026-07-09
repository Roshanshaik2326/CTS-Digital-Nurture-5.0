using System;

// Component
public interface IOrder
{
    void ProcessOrder();
}

// Concrete Component
public class BasicOrder : IOrder
{
    public void ProcessOrder()
    {
        Console.WriteLine("Basic Order Created.");
    }
}

// Base Decorator
public abstract class OrderDecorator : IOrder
{
    protected IOrder order;

    public OrderDecorator(IOrder order)
    {
        this.order = order;
    }

    public virtual void ProcessOrder()
    {
        order.ProcessOrder();
    }
}

// Concrete Decorator - Gift Wrap
public class GiftWrapDecorator : OrderDecorator
{
    public GiftWrapDecorator(IOrder order) : base(order) { }

    public override void ProcessOrder()
    {
        base.ProcessOrder();
        Console.WriteLine("Gift Wrap Added.");
    }
}

// Concrete Decorator - Express Delivery
public class ExpressDeliveryDecorator : OrderDecorator
{
    public ExpressDeliveryDecorator(IOrder order) : base(order) { }

    public override void ProcessOrder()
    {
        base.ProcessOrder();
        Console.WriteLine("Express Delivery Added.");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Decorator Pattern ===\n");

        IOrder order = new BasicOrder();

        order = new GiftWrapDecorator(order);

        order = new ExpressDeliveryDecorator(order);

        order.ProcessOrder();
    }
}