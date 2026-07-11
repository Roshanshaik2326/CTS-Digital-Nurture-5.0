using System;

class Program
{
    static void Heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && arr[left] > arr[largest])
        {
            largest = left;
        }

        if (right < n && arr[right] > arr[largest])
        {
            largest = right;
        }

        if (largest != i)
        {
            int temp = arr[i];
            arr[i] = arr[largest];
            arr[largest] = temp;

            Heapify(arr, n, largest);
        }
    }

    static void HeapSort(int[] arr)
    {
        int n = arr.Length;

        // Build Max Heap
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(arr, n, i);
        }

        // Extract elements
        for (int i = n - 1; i > 0; i--)
        {
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;

            Heapify(arr, i, 0);
        }
    }

    static void Main()
    {
        int[] priorities = { 40, 20, 15, 30, 10 };

        Console.WriteLine("Before Heap Sort:");
        Console.WriteLine(string.Join(" ", priorities));

        HeapSort(priorities);

        Console.WriteLine("\nAfter Heap Sort:");
        Console.WriteLine(string.Join(" ", priorities));
    }
}