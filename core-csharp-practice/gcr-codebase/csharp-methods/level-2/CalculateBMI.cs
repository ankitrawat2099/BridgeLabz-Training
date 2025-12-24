using System;

class CalculateBMI
{
//method to calcualte
    static void Calculate(double[,] data)
    {
        for (int i =0;i<10;i++){
            double heightMeters = data[i, 1] / 100;
            data[i, 2] = data[i, 0] / (heightMeters * heightMeters);
        }
    }
//method to get status
    static string GetStatus(double bmi)
    {
        if (bmi < 18.5){
		return "Underweight";}
        if (bmi < 25){
		return "Normal";}
		
        if (bmi < 30){
		return "Overweight";}
		
        return "Obese";
    }

    static void Main()
    {
        double[,] people = new double[10, 3];

        for (int i=0;i< 10;i++)
        {
            Console.Write($"Enter weight (kg) for person: ");
            people[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Enter height (cm) for person: ");
            people[i, 1] = Convert.ToDouble(Console.ReadLine());
        }

        Calculate(people);
        for (int i = 0; i < 10; i++)
            Console.WriteLine($"BMI: {people[i, 2]:F2}, Status: {GetStatus(people[i, 2])}");
    }
}
