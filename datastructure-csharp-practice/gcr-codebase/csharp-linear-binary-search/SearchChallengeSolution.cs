using System;
using System.Linq;

class SearchChallengeSolution
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

        //Linear Search: First Missing Positive 
        bool[] visited = new bool[n + 2];

        foreach (int num in arr)
        {
            if (num > 0 && num <= n + 1)
                visited[num] = true;
        }

        int missing = 1;
        while (visited[missing]){
            missing++;}

        Console.WriteLine("First Missing Positive: " + missing);

        // Binary Search for Target
        Array.Sort(arr);
    //take the targeyt value input from user
        Console.Write("Enter target to search: ");
        int target = int.Parse(Console.ReadLine());

        int low = 0, high = arr.Length - 1;
        int index = -1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == target)
            {
                index = mid;
                break;
            }
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }

        Console.WriteLine(index != -1? "Target found at index: " + index : "Target not found");
    }
}
