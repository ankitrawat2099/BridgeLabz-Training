using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.datastructure_csharp_practice.gcr_codebase.csharp_sorting_alogrithm
{

    class BubbleSortStudentMarks
    {
        static void Main()
        {
            //take the number of students as input from user
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            int[] marks = new int[n];
            //input the marks of studetns 
            Console.WriteLine("Enter student marks:");
            for (int i = 0; i < n; i++)
                marks[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (marks[j] > marks[j + 1])
                    {
                        int temp = marks[j];
                        marks[j] = marks[j + 1];
                        marks[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted Marks:");
            foreach (int m in marks)
                Console.Write(m + " ");
        }
    }

}
