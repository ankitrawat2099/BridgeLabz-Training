using System;
class BasicCalculator
{
    //method to add two numbers
    static double Add(double a,double b){ 
        return a + b;}

    //method to subtract second number from first
    static double Subtract(double a,double b){
        return a - b;}

    //method to multiply two numbers
    static double Multiply(double a,double b){
        return  a * b;}

    //method to divide first number by second
    static double Divide(double a,double b){
        return a / b;}

    static void Main() {
        //take the fist nunmber as input from user
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        // take the second number as input from user
        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        //take the operation as input from user
        Console.Write("Choose operation (+ - * /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();
        double result = 0;
        switch (op)
        {
            case '+':result = Add(num1, num2);
                break;
            case '-':result = Subtract(num1, num2);
                break;
            case '*':result = Multiply(num1, num2);
                break;
            case '/':
                result = Divide(num1, num2);
                break;
            default:
                Console.WriteLine("Invalid operation");
                return;
        }
        //display the final result
        Console.WriteLine("Result: " + result);
    }
}
