using System;

class PeakElementBinarySearch
{
    static void Main()
    {
        //take the size of array input from user
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        int low = 0, high = n - 1;

        // Binary search for peak
        while (low < high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] < arr[mid + 1])
                low = mid + 1;
            else
                high = mid;
        }

        Console.WriteLine("Peak Element Index: " + low);
        Console.WriteLine("Peak Element Value: " + arr[low]);
    }
}
