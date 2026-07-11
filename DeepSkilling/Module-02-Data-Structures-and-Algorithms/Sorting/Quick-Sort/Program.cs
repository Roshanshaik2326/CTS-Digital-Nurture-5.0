using System;

class Program
{
    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }

        Swap(arr, i + 1, high);
        return i + 1;
    }

    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);

            QuickSort(arr, low, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, high);
        }
    }

    static void Main()
    {
        int[] studentRanks = { 65, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Before Quick Sort:");
        Console.WriteLine(string.Join(" ", studentRanks));

        QuickSort(studentRanks, 0, studentRanks.Length - 1);

        Console.WriteLine("\nAfter Quick Sort:");
        Console.WriteLine(string.Join(" ", studentRanks));
    }
}