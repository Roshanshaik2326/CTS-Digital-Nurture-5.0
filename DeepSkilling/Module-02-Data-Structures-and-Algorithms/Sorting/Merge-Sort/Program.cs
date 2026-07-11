using System;

class Program
{
    static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];

        int i = left;
        int j = mid + 1;
        int k = 0;

        while (i <= mid && j <= right)
        {
            if (arr[i] <= arr[j])
                temp[k++] = arr[i++];
            else
                temp[k++] = arr[j++];
        }

        while (i <= mid)
            temp[k++] = arr[i++];

        while (j <= right)
            temp[k++] = arr[j++];

        for (int x = 0; x < temp.Length; x++)
            arr[left + x] = temp[x];
    }

    static void MergeSort(int[] arr, int left, int right)
    {
        if (left >= right)
            return;

        int mid = (left + right) / 2;

        MergeSort(arr, left, mid);
        MergeSort(arr, mid + 1, right);

        Merge(arr, left, mid, right);
    }

    static void Main()
    {
        int[] orderIds = { 38, 27, 43, 3, 9, 82, 10 };

        Console.WriteLine("Before Merge Sort:");
        Console.WriteLine(string.Join(" ", orderIds));

        MergeSort(orderIds, 0, orderIds.Length - 1);

        Console.WriteLine("\nAfter Merge Sort:");
        Console.WriteLine(string.Join(" ", orderIds));
    }
}