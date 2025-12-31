using System;

class MathFunctions
{
    //method to calculate factorial
    public static int Factorial(int n)
    {
        int fact = 1;
        for (int i = 1; i <= n; i++) 
            fact = fact * i;  //     fact = fact * i;

        return fact;
    }

    //method to check number is prime 
    public static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i < n; i++) 
        {
            if (n % i == 0) 
                return false;
        }
        return true;
    }

    //method to find GCD
    public static int GCD(int a, int b)
    {
        while (a != b)
        {
            if (a > b){
                a = a - b; }
            else{
                b = b - a;}
        }
        return a;
    }

    //method for fibonacci
    public static int Fibonacci(int n)
    {
        if (n == 0){
            return 0;}

        int a = 0, b = 1, c = 0;
        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return b;
    }
}

class MathmaticsOperations
{
    static void Main()
    {
        Console.WriteLine("1. Factorial");
        Console.WriteLine("2. Prime");
        Console.WriteLine("3. GCD");
        Console.WriteLine("4. Fibonacci");
//take the user choice as input 
        Console.Write("Enter choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
//switch case for user choice
        switch (choice) 
        {
            case 1:
                Console.Write("Enter number: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                    Console.WriteLine("Not possible");
                else 
                    Console.WriteLine("Factorial = " + MathFunctions.Factorial(n));
                break;

            case 2:
                Console.Write("Enter number: ");
                int p = Convert.ToInt32(Console.ReadLine());
                if (MathFunctions.IsPrime(p))
                    Console.WriteLine("Prime Number");
                else
                    Console.WriteLine("Not Prime");
                break;

            case 3:
                Console.Write("Enter two numbers: ");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("GCD = " + MathFunctions.GCD(a, b));
                break;

            case 4:
                Console.Write("Enter number: ");
                int f = Convert.ToInt32(Console.ReadLine());
                if (f < 0)
                    Console.WriteLine("Not possible");
                else
                    Console.WriteLine("Fibonacci = " + MathFunctions.Fibonacci(f));
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}