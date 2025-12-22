using System;

class PersonBmiCalculator
{
    static void Main(String[] args)
    {
		//take weight of person from user
        Console.Write("Enter weight (kg): ");
        double weight = Convert.ToDouble(Console.ReadLine());
//take height of person form user
        Console.Write("Enter height (cm): ");
        double heightCm = Convert.ToDouble(Console.ReadLine());
//conmvert height in cm to meters
        double heightM = heightCm / 100;
        double bmi = weight / (heightM * heightM);

        Console.WriteLine($"BMI: {bmi:f2}");
//calcluate the status according to BMI
        if (bmi < 18.5)
            Console.WriteLine("Underweight");
        else if (bmi < 25)
            Console.WriteLine("Normal weight");
        else if (bmi < 30)
            Console.WriteLine("Overweight");
        else
            Console.WriteLine("Obese");
    }
}
