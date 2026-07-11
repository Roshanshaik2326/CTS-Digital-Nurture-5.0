using System;

class Program
{
    static void Main()
    {
        string[] products =
        {
            "Laptop",
            "Keyboard",
            "Monitor",
            "Mouse",
            "Printer"
        };

        int[] prices =
        {
            4500,
            3200,
            5100,
            2800,
            3900
        };

        Console.WriteLine("===== Before Selection Sort =====\n");

        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine($"{products[i]} : ₹{prices[i]}");
        }

        // Selection Sort
        for (int i = 0; i < prices.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < prices.Length; j++)
            {
                if (prices[j] < prices[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap prices
            int tempPrice = prices[i];
            prices[i] = prices[minIndex];
            prices[minIndex] = tempPrice;

            // Swap product names
            string tempProduct = products[i];
            products[i] = products[minIndex];
            products[minIndex] = tempProduct;
        }

        Console.WriteLine("\n===== After Selection Sort =====\n");

        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine($"{products[i]} : ₹{prices[i]}");
        }
    }
}