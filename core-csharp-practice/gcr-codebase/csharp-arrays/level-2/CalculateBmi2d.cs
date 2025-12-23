using System;

class CalculateBmi2d
{
    static void Main()
    {
	//enter the number of persons
        Console.Write("Enter number of persons: ");
        int number = Convert.ToInt32(Console.ReadLine());

        double[][] personBmi = new double[number][];
        string[] weightStatus = new string[number];

        for (int i = 0; i < number; i++)
        {
            personBmi[i] = new double[3];
//take the weight of user 
            Console.Write("Enter weight: ");
            personBmi[i][0] = Convert.ToDouble(Console.ReadLine());
//take the height as inpur from user
            Console.Write("Enter height: ");
            personBmi[i][1] = Convert.ToDouble(Console.ReadLine());
//calculate the BMI
            personBmi[i][2] = personBmi[i][0] / (personBmi[i][1] * personBmi[i][1]);
//updating the wiehgt status accrording to bmi
            weightStatus[i] = personBmi[i][2] < 18.5 ? "Underweight" :personBmi[i][2] < 25 ? "Normal" :personBmi[i][2] < 30 ? "Overweight" : "Obese";
        }
//printing the BMI
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine($"Height={personBmi[i][1]}, Weight={personBmi[i][0]}, BMI={personBmi[i][2]}, Status={weightStatus[i]}");
        }
    }
}
