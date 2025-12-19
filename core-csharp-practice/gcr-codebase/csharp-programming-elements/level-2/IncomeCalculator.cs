using System;

class IncomeCalculator
{
    static void Main()
    {
        //take input of salary
        Console.Write("Enter salary: ");
        double salary=Convert.ToDouble(Console.ReadLine());
		//take input of bonus
        Console.Write("Enter bonus: ");
        double bonus=Convert.ToDouble(Console.ReadLine());
//total income
        double totalIncome=salary+bonus;

        Console.WriteLine("The salary is INR "+salary+" and bonus is INR "+bonus+ ". Hence Total Income is INR "+totalIncome); //output
    }
}