using System;

class IntegerOperation
{
    static void Main(String[] args)
    {
        //take input of 3 numbers
        Console.Write("Enter a: ");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter b: ");
        int b=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter c: ");
        int c=Convert.ToInt32(Console.ReadLine());
		//a + b*c
        int operation1=a+b*c;        
		//a*b + c		
        int operation2=a*b+c;    
		//c + a/b		
        int operation3=c+a/b;      
		//a % b + c		
        int operation4=a%b+c;                            
        Console.WriteLine("The results of Int Operations are "+operation1+", "+operation2+", "+operation3+", and "+operation4);
    }
}