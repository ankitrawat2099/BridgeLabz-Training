using System;

class RotationPointSearch
{
    static void Main()
    {
        //take the array size input from user
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter rotated sorted array elements:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        int low = 0, high = n - 1;

        // Binary search to find smallest element
        while (low < high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] > arr[high])
                low = mid + 1;
            else
                high = mid;
        }

        Console.WriteLine("Rotation Point Index: " + low);
        Console.WriteLine("Smallest Element: " + arr[low]);
    }
}
