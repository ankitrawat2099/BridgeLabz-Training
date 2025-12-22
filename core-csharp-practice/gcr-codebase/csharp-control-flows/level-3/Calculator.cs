using System;

class Calculator
{
    static void Main()
    {
	//enter the number form user
        Console.Write("Enter first number: ");
        double first = Convert.ToInt32(Console.ReadLine());
//enter the second number
        Console.Write("Enter second number: ");
        double second =  Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
		//enter the operator 
        string op = Console.ReadLine();

        switch (op)
        {
            case "+":
                Console.WriteLine($"Result: {first + second}");
                break;

            case "-":
                Console.WriteLine($"Result: {first - second}");
                break;

            case "*":
                Console.WriteLine($"Result: {first * second}");
                break;

            case "/":
                if (second != 0)
                    Console.WriteLine($"Result: {first / second}");
                else
                    Console.WriteLine("Division by zero is not allowed");
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
