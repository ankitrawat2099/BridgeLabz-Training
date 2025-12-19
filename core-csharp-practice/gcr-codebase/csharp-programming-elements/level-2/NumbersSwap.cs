using System;

class NumbersSwap
{
    static void Main(String[] args)
    {
      //first number
        Console.Write("Enter number1: ");
        double num1=Convert.ToDouble(Console.ReadLine());
		//second number
        Console.Write("Enter number2: ");
        double num2=Convert.ToDouble(Console.ReadLine());
//swapping using temp
        double temp=num1;                     
        num1=num2;
        num2=temp;

        Console.WriteLine("The swapped numbers are "+num1+" and "+num2);
    }
}