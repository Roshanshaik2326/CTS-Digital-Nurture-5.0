using System;

class Program
{
    static void Main()
    {
        int[] employeeIds = { 101, 102, 103, 104, 105 };
        string[] employeeNames =
        {
            "Roshan",
            "Rahul",
            "Priya",
            "Anil",
            "Kiran"
        };

        Console.Write("Enter Employee ID to Search: ");

        int searchId = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        for (int i = 0; i < employeeIds.Length; i++)
        {
            if (employeeIds[i] == searchId)
            {
                Console.WriteLine("\nEmployee Found");
                Console.WriteLine($"Employee ID   : {employeeIds[i]}");
                Console.WriteLine($"Employee Name : {employeeNames[i]}");

                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("\nEmployee Not Found.");
        }
    }
}