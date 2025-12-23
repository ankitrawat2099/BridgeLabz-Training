using System;

class StudentGradeCalculator
{
    static void Main()
    {
	//take the number of students from user
        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[] percentage = new double[n];
        char[] grade = new char[n];

        for (int i = 0; i < n; i++)
        {
			//take the phyics marks from user as input
            Console.Write("Physics Marks: ");
            double physics = Convert.ToDouble(Console.ReadLine());
				//take the chemistyr marks from user as input
            Console.Write("Chemistry marks: ");
            double chemistry = Convert.ToDouble(Console.ReadLine());
				//take the maths marks from user as input
            Console.Write("Maths marks: ");
            double math = Convert.ToDouble(Console.ReadLine());
//calculate percentage
            percentage[i] = (physics+ chemistry + math) / 3;
//assingin grades 
            grade[i] = percentage[i] >= 80 ? 'A' :percentage[i] >= 70 ? 'B' :percentage[i] >=60  ? 'C' :percentage[i]>=50? 'D':percentage[i]>=40?'E' :'R';
        }

        for (int i = 0; i < n; i++)
            Console.WriteLine($"Percentage={percentage[i]}, Grade={grade[i]}");
    }
}
