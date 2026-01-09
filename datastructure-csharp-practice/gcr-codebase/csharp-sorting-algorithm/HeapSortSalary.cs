using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.datastructure_csharp_practice.gcr_codebase.csharp_sorting_alogrithm
{

    class HeapSortSalary
    {
        static void Main()
        {
            //take the applicants nunmber from usre
            Console.Write("Enter number of applicants: ");
            int n = int.Parse(Console.ReadLine());

            int[] salary = new int[n];
            //input the salary demands
            Console.WriteLine("Enter salary demands:");
            for (int i = 0; i < n; i++)
                salary[i] = int.Parse(Console.ReadLine());

            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(salary, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                int temp = salary[0];
                salary[0] = salary[i];
                salary[i] = temp;
                Heapify(salary, i, 0);
            }

            Console.WriteLine("Sorted Salary Demands:");
            foreach (int s in salary)
                Console.Write(s + " ");
        }
        //method for headsort
        static void Heapify(int[] arr, int size, int root)
        {
            int largest = root;
            int left = 2 * root + 1;
            int right = 2 * root + 2;

            if (left < size && arr[left] > arr[largest])
                largest = left;
            if (right < size && arr[right] > arr[largest])
                largest = right;

            if (largest != root)
            {
                int temp = arr[root];
                arr[root] = arr[largest];
                arr[largest] = temp;
                Heapify(arr, size, largest);
            }
        }
    }

}
