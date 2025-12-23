using System;

class StudentGradeCalculator2d
{
    static void Main()
    {
	//take the number of students as input from user
        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[,] marks = new double[n, 3];
        double[] percentage = new double[n];
        char[] grade = new char[n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Enter mark: ");
                marks[i, j] = Convert.ToDouble(Console.ReadLine());
            }
//calcualte the percentage
            percentage[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3;
//assigning grades
		grade[i] = percentage[i] >= 80 ? 'A' :percentage[i] >= 70 ? 'B' :percentage[i] >=60  ? 'C' :percentage[i]>=50? 'D':percentage[i]>=40?'E' :'R';
            
        }

        for (int i = 0; i < n; i++)
            Console.WriteLine($"Percentage={percentage[i]}, Grade={grade[i]}");
    }
}
