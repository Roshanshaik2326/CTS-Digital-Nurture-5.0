using System;

class Program
{
    static void Main()
    {
        string[] students =
        {
            "Roshan",
            "Rahul",
            "Priya",
            "Anil",
            "Kiran"
        };

        int[] marks =
        {
            92,
            85,
            97,
            80,
            88
        };

        Console.WriteLine("===== Student Marks =====\n");

        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"{students[i]} : {marks[i]}");
        }

        Console.WriteLine();

        int highest = marks[0];
        string topper = students[0];

        int total = 0;

        for (int i = 0; i < marks.Length; i++)
        {
            total += marks[i];

            if (marks[i] > highest)
            {
                highest = marks[i];
                topper = students[i];
            }
        }

        Console.WriteLine($"Topper : {topper}");
        Console.WriteLine($"Highest Marks : {highest}");

        Console.WriteLine($"Average Marks : {(double)total / marks.Length:F2}");
    }
}