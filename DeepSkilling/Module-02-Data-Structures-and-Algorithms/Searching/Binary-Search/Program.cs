using System;

class Program
{
    static void Main()
    {
        int[] productIds = { 101, 102, 103, 104, 105, 106, 107 };
        string[] productNames =
        {
            "Keyboard",
            "Mouse",
            "Monitor",
            "Printer",
            "Speaker",
            "Laptop",
            "Webcam"
        };

        Console.Write("Enter Product ID to Search: ");
        int searchId = Convert.ToInt32(Console.ReadLine());

        int left = 0;
        int right = productIds.Length - 1;
        bool found = false;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (productIds[mid] == searchId)
            {
                Console.WriteLine("\nProduct Found");
                Console.WriteLine($"Product ID   : {productIds[mid]}");
                Console.WriteLine($"Product Name : {productNames[mid]}");

                found = true;
                break;
            }
            else if (searchId < productIds[mid])
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        if (!found)
        {
            Console.WriteLine("\nProduct Not Found.");
        }
    }
}