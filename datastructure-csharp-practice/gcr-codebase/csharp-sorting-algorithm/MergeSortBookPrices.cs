using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.datastructure_csharp_practice.gcr_codebase.csharp_sorting_alogrithm
{
    class MergeSortBookPrices
    {
        static void Main()
        {
            //take the no of books input from usr
            Console.Write("Enter number of books: ");
            int n = int.Parse(Console.ReadLine());

            int[] prices = new int[n];
            //take book prices input
            Console.WriteLine("Enter book prices:");
            for (int i = 0; i < n; i++)
                prices[i] = int.Parse(Console.ReadLine());

            MergeSort(prices, 0, n - 1);

            Console.WriteLine("Sorted Book Prices:");
            foreach (int p in prices)
                Console.Write(p + " ");
        }
        //method to mergesort
        static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }
        //method to merge
        static void Merge(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[right - left + 1];
            int i = left, j = mid + 1, k = 0;

            while (i <= mid && j <= right)
                temp[k++] = arr[i] < arr[j] ? arr[i++] : arr[j++];

            while (i <= mid) temp[k++] = arr[i++];
            while (j <= right) temp[k++] = arr[j++];

            for (int x = 0; x < temp.Length; x++)
                arr[left + x] = temp[x];
        }
    }

}
