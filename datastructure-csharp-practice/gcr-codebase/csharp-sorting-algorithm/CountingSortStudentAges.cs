using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.datastructure_csharp_practice.gcr_codebase.csharp_sorting_alogrithm
{


    class CountingSortStudentAges
    {
        static void Main()
        {
            //take the number of students input from user
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            int[] ages = new int[n];
            int[] count = new int[19];
            //take the student ages bw 10 to 18
            Console.WriteLine("Enter student ages (10–18):");
            for (int i = 0; i < n; i++)
            {
                ages[i] = int.Parse(Console.ReadLine());
                count[ages[i]]++;
            }

            Console.WriteLine("Sorted Ages:");
            for (int age = 10; age <= 18; age++)
            {
                while (count[age]-- > 0)
                    Console.Write(age + " ");
            }
        }
    }

}
