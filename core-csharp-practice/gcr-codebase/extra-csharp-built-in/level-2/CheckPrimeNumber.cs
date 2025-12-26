using System;
class CheckPrimeNumber{
    //check if number is prime
    static bool IsPrime(int num){
        if (num <= 1){
            return false;
        } 
//iterate to number/2
        for (int i = 2;i<= num / 2;i++) {
            if (num % i == 0)
                return false;
        }
        return true;
    }
    static void Main(){
        //take the number as input form user
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(IsPrime(num) ? "Prime Number" : "Not a Prime Number");
    }
}
