using System;

// Small Interface
public interface IWorkable
{
    void Work();
}

// Small Interface
public interface IEatable
{
    void Eat();
}

// Human can work and eat
public class Human : IWorkable, IEatable
{
    public void Work()
    {
        Console.WriteLine("Human is working.");
    }

    public void Eat()
    {
        Console.WriteLine("Human is eating.");
    }
}

// Robot only works
public class Robot : IWorkable
{
    public void Work()
    {
        Console.WriteLine("Robot is working.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Human human = new Human();
        human.Work();
        human.Eat();

        Console.WriteLine();

        Robot robot = new Robot();
        robot.Work();
    }
}