using System;

class Calculator
{
    public static void Main(string[] args)
    {
    
        // take two numbers from user input
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Perform arithmetic operations
        double add = num1 + num2;
        double sub = num1 - num2;
        double mul = num1 * num2;
        double div = num1 / num2;

         Console.WriteLine($"The addition, subtraction, multiplication and division value of 2 numbers {num1} and {num2} is {add}, {sub}, {mul}, and {div}"
        );
    }
}