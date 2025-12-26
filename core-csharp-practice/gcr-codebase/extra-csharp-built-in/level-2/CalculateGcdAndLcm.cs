using System;

class CalculateGcdAndLcm
{
    //method to calcualte GCD
    static int CalculateGCD(int a, int b){
        while (b != 0){
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    //methjod to calcualte LCM
    static int CalculateLCM(int a, int b){
        return (a * b) / CalculateGCD(a, b);
    }

    static void Main(){
        //tak the fist number as input from user
        Console.Write("Enter first number: ");
        int x = Convert.ToInt32(Console.ReadLine());
//take the second number as input from user
        Console.Write("Enter second number: ");
        int y = Convert.ToInt32(Console.ReadLine());
//display GCD and LCM
        Console.WriteLine("GCD: " + CalculateGCD(x, y));     
        Console.WriteLine("LCM: " + CalculateLCM(x, y));
    }
}
