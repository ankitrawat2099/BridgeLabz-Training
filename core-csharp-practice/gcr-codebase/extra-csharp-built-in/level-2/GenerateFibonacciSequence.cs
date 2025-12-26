using System;
class GenerateFibonacciSequence{
    //pinr the fibonacci series
    static void Fibonacci(int terms){
        int a = 0;
        int b = 1;
        for (int i = 1;i<=terms;i++){
            Console.Write(a + " ");
            int next = a + b;
            a = b;
            b = next;
        }
    }

    static void Main(){
        //take thu number oqf terms as input from user
        Console.Write("Enter number of terms: ");
        int terms = int.Parse(Console.ReadLine()!);
        Fibonacci(terms);          
    }
}
