using System;

// Command Interface
public interface ICommand
{
    void Execute();
}

// Receiver
public class Chef
{
    public void CookBurger()
    {
        Console.WriteLine("Chef: Burger is prepared.");
    }

    public void CookPizza()
    {
        Console.WriteLine("Chef: Pizza is prepared.");
    }
}

// Concrete Command - Burger
public class BurgerCommand : ICommand
{
    private readonly Chef chef;

    public BurgerCommand(Chef chef)
    {
        this.chef = chef;
    }

    public void Execute()
    {
        chef.CookBurger();
    }
}

// Concrete Command - Pizza
public class PizzaCommand : ICommand
{
    private readonly Chef chef;

    public PizzaCommand(Chef chef)
    {
        this.chef = chef;
    }

    public void Execute()
    {
        chef.CookPizza();
    }
}

// Invoker
public class Waiter
{
    public void TakeOrder(ICommand command)
    {
        Console.WriteLine("Waiter: Order received.");
        command.Execute();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Command Pattern ===\n");

        Chef chef = new Chef();

        ICommand burger = new BurgerCommand(chef);
        ICommand pizza = new PizzaCommand(chef);

        Waiter waiter = new Waiter();

        waiter.TakeOrder(burger);
        waiter.TakeOrder(pizza);
    }
}