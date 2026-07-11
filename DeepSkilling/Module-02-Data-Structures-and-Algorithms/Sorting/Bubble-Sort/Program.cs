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
            75,
            88,
            65,
            97
        };

        Console.WriteLine("===== Before Sorting =====\n");

        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"{students[i]} : {marks[i]}");
        }

        // Bubble Sort
        for (int i = 0; i < marks.Length - 1; i++)
        {
            for (int j = 0; j < marks.Length - i - 1; j++)
            {
                if (marks[j] > marks[j + 1])
                {
                    // Swap Marks
                    int tempMark = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = tempMark;

                    // Swap Student Names
                    string tempName = students[j];
                    students[j] = students[j + 1];
                    students[j + 1] = tempName;
                }
            }
        }

        Console.WriteLine("\n===== After Bubble Sort =====\n");

        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"{students[i]} : {marks[i]}");
        }
    }
}