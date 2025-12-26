using System;
class RecursiveFactorial
{
    //method to find recursive factorial
    static long Factorial(int num){
        if (num == 0){
            return 1;}
        return num * Factorial(num - 1);
    }

    static void Main(){
        //take the number as input from user
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());      
        Console.WriteLine("Factorial: " + Factorial(num));    
    }
}
