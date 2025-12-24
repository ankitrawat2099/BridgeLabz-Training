using System;

class SimpleInterestCalculator
{
	//method to find simple interest
    static double SimpleInterest(double principal, double rate, double time)
    {
		//return the interest
        return (principal * rate * time) / 100;
    }

    static void Main()
    {
        Console.Write("Enter the Principal: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the time: ");
        double time = Convert.ToDouble(Console.ReadLine());
//callling the interest method
        double interest = SimpleInterest(principal, rate, time);

        Console.WriteLine($"The Simple Interest is {interest} for Principal {principal}, Rate of Interest {rate} and Time {time}");
    }
}
