using System;

class BonusCalculator
{
    static void Main(String[] args)
    {
	//take salary as input from user
        Console.Write("Enter the salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());
//take the years of service as input from user
        Console.Write("Enter the years of service: ");
        int years = Convert.ToInt32(Console.ReadLine());
//check the years if greater than 5 or not
        if (years > 5)
        {
            double bonusAmount = salary * 5/100;
            Console.WriteLine($"Bonus amount is {bonusAmount}");
        }
        else
        {
            Console.WriteLine("No bonus is applicable");
        }
    }
}
