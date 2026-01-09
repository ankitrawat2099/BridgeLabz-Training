using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.datastructure_csharp_practice.gcr_codebase.csharp_sorting_alogrithm
{

    class InsertionSortEmployeeIDs
    {
        static void Main()
        {
            //take the no of emplyees from user
            Console.Write("Enter number of employees: ");
            int n = int.Parse(Console.ReadLine());

            int[] empIds = new int[n];
            //taking the employee id input from user
            Console.WriteLine("Enter employee IDs:");
            for (int i = 0; i < n; i++)
                empIds[i] = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                int key = empIds[i];
                int j = i - 1;

                while (j >= 0 && empIds[j] > key)
                {
                    empIds[j + 1] = empIds[j];
                    j--;
                }
                empIds[j + 1] = key;
            }

            Console.WriteLine("Sorted Employee IDs:");
            foreach (int id in empIds)
                Console.Write(id + " ");
        }
    }

}
