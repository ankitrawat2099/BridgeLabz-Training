using System;

class QuotientRemainderFinder
{
    static void Main(String[] args)
    {
        //take input of num1 
        Console.Write("Enter first number: ");
        int num1=Convert.ToInt32(Console.ReadLine());
		//take input of num2
        Console.Write("Enter second number: ");
        int num2=Convert.ToInt32(Console.ReadLine());
//calculate quotient using division
        int quotient=num1/num2;            
		//calculate remainder using modulus
        int remainder=num1%num2;     

        Console.WriteLine("The Quotient is "+quotient+" and Remainder is "+remainder+" of two numbers "+num1+" and "+num2);
    }
}