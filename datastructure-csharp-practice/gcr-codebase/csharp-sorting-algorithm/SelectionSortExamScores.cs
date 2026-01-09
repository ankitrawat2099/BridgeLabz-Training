using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.datastructure_csharp_practice.gcr_codebase.csharp_sorting_alogrithm
{


    class SelectionSortExamScores
    {
        static void Main()
        {
            //take the number of studetns as input from user
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            int[] scores = new int[n];
            //input the exam scores 
            Console.WriteLine("Enter exam scores:");
            for (int i = 0; i < n; i++)
                scores[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                    if (scores[j] < scores[minIndex])
                        minIndex = j;

                int temp = scores[i];
                scores[i] = scores[minIndex];
                scores[minIndex] = temp;
            }

            Console.WriteLine("Sorted Exam Scores:");
            foreach (int s in scores)
                Console.Write(s + " ");
        }
    }

}
