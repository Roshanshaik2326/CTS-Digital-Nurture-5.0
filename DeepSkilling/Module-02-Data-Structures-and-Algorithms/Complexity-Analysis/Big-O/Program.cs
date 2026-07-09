using System;

class Program
{
    static void ConstantTime()
    {
        Console.WriteLine("O(1) - Constant Time");
        Console.WriteLine("Accessing the first element of an array.");
    }

    static void LinearTime(int[] numbers)
    {
        Console.WriteLine("\nO(n) - Linear Time");

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
    }

    static void QuadraticTime(int[] numbers)
    {
        Console.WriteLine("\nO(n²) - Quadratic Time");

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.Write($"({numbers[i]},{numbers[j]}) ");
            }

            Console.WriteLine();
        }
    }

    static void Main()
    {
        int[] numbers = {1,2,3};

        ConstantTime();

        LinearTime(numbers);

        QuadraticTime(numbers);
    }
}