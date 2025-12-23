using System;

class CalculatMeanHeight
{
    static void Main(string[] args)
    {
        double[] heights = new double[11];
        double sum = 0;
//taking the height of all players from the user
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write($"Enter the  height: ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
			//calculaitn the sum of all heights
            sum += heights[i];
        }

//calculating the mean
        double mean = sum / heights.Length;
        Console.WriteLine($"Mean: {mean}");
    }
}
