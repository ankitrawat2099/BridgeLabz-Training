using System;

class SimpleInterestCalculator
{
    static void Main()
    {
        //take input of principal
        Console.Write("Enter principal: ");
        double principal=Convert.ToDouble(Console.ReadLine());
		//take input of rate
        Console.Write("Enter rate: ");
        double rate=Convert.ToDouble(Console.ReadLine());
		//take input of time 
        Console.Write("Enter time: ");
        double time=Convert.ToDouble(Console.ReadLine());
//formula for simple Interest
        double simpleInterest=(principal*rate*time)/100;

        Console.WriteLine("The Simple Interest is "+simpleInterest+ " for Principal "+principal+", Rate of Interest "+rate+" and Time "+time);
    }
}