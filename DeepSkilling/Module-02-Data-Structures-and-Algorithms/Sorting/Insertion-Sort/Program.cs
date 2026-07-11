using System;

class Program
{
    static void Main()
    {
        string[] employees =
        {
            "Roshan",
            "Rahul",
            "Priya",
            "Anil",
            "Kiran"
        };

        int[] salaries =
        {
            45000,
            30000,
            52000,
            40000,
            35000
        };

        Console.WriteLine("===== Before Insertion Sort =====\n");

        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine($"{employees[i]} : ₹{salaries[i]}");
        }

        // Insertion Sort
        for (int i = 1; i < salaries.Length; i++)
        {
            int keySalary = salaries[i];
            string keyEmployee = employees[i];

            int j = i - 1;

            while (j >= 0 && salaries[j] > keySalary)
            {
                salaries[j + 1] = salaries[j];
                employees[j + 1] = employees[j];
                j--;
            }

            salaries[j + 1] = keySalary;
            employees[j + 1] = keyEmployee;
        }

        Console.WriteLine("\n===== After Insertion Sort =====\n");

        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine($"{employees[i]} : ₹{salaries[i]}");
        }
    }
}