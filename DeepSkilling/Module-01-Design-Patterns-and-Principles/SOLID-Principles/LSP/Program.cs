using System;

// Base class
public abstract class Bird
{
    public abstract void Eat();
}

// Flying capability
public interface IFlyable
{
    void Fly();
}

// Sparrow can fly
public class Sparrow : Bird, IFlyable
{
    public override void Eat()
    {
        Console.WriteLine("Sparrow is eating.");
    }

    public void Fly()
    {
        Console.WriteLine("Sparrow is flying.");
    }
}

// Penguin cannot fly
public class Penguin : Bird
{
    public override void Eat()
    {
        Console.WriteLine("Penguin is eating.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Sparrow sparrow = new Sparrow();
        sparrow.Eat();
        sparrow.Fly();

        Console.WriteLine();

        Penguin penguin = new Penguin();
        penguin.Eat();
    }
}