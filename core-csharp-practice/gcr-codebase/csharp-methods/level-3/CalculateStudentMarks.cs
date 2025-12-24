using System;

class CalculateStudentMarks
{
	//method to generate marks
    public static int[,] Generate(int students)
    {
        Random rand = new Random();
        int[,] marks = new int[students,3];
        for (int i = 0; i < students; i++)
            for (int j=0;j<3;j++){
				//marks 30 to 99
			marks[i, j] = rand.Next(30, 100);}
        return marks;
    }

    // Calculate total
    public static double[,] CalculateResults(int[,] marks)
    {
        int students = marks.GetLength(0);
        double[,] results = new double[students, 3];
        for (int i = 0; i < students; i++){
            int total = marks[i, 0] + marks[i, 1] + marks[i, 2];
            results[i, 0] = total;
            results[i, 1] = Math.Round(total / 3.0, 2);
            results[i, 2] = Math.Round((total / 300.0) * 100, 2);
        }
        return results;
    }

    // method to display the result
    public static void DisplayResults(int[,] marks,double[,] results)
    {
        Console.WriteLine("Physics\tChem\tMaths\tTotal\tAverage\tPercentage");
        for (int i = 0; i < marks.GetLength(0); i++)
            Console.WriteLine($"{marks[i,0]}\t{marks[i,1]}\t{marks[i,2]}\t{results[i,0]}\t{results[i,1]}\t{results[i,2]}");
    }

    static void Main()
    {
		//take the number of studnets form user
        Console.Write("Enter number of students: ");
        int n =Convert.ToInt32(Console.ReadLine());
        int[,] marks = Generate(n);
        double[,] results = CalculateResults(marks);
        DisplayResults(marks, results);
    }
}
