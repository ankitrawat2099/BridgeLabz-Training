using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.datastructure_csharp_practice.gcr_codebase.csharp_sorting_alogrithm
{

    class QuickSortProductPrices
    {
        static void Main()
        {
            //take the number of products input from user
            Console.Write("Enter number of products: ");
            int n = int.Parse(Console.ReadLine());

            int[] prices = new int[n];
            //take the product prices input
            Console.WriteLine("Enter product prices:");
            for (int i = 0; i < n; i++)
                prices[i] = int.Parse(Console.ReadLine());

            QuickSort(prices, 0, n - 1);

            Console.WriteLine("Sorted Product Prices:");
            foreach (int p in prices)
                Console.Write(p + " ");
        }
        //method for quick sort
        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(arr, low, high);
                QuickSort(arr, low, pivot - 1);
                QuickSort(arr, pivot + 1, high);
            }
        }
        //method for partition
        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int swap = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = swap;

            return i + 1;
        }
    }

}
