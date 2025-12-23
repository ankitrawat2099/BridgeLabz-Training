using System;

class CalculateBmi
{
    static void Main()
    {
	//take number of persons as input from user
        Console.Write("Enter the number of persons: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[] weight = new double[n];
        double[] height = new double[n];
        double[] bmi = new double[n];
        string[] status = new string[n];

        for (int i = 0; i < n; i++)
        {
			//taking the persons weight as input from user
            Console.Write($"Enter the  weight of person: ");
            weight[i] = Convert.ToDouble(Console.ReadLine());
//taking the persons height as input from user
            Console.Write($"Enter height (m) of person: ");
            height[i] = Convert.ToDouble(Console.ReadLine());
//calculating the BMI
            bmi[i] = weight[i] / (height[i] * height[i]);
//updating the status
            status[i] = bmi[i] < 18.5 ? "Underweight" : bmi[i] < 25 ? "Normal" :bmi[i] < 40 ? "Overweight" : "Obese";
        }
//printing the the BMI table
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Height: {height[i]}, Weight: {weight[i]}, BMI: {bmi[i]}, Status: {status[i]}");
        }
    }
}
