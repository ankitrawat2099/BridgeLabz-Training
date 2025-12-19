using System;

class DoubleOperation
{
    static void Main(String[] args)
    {
      //take 3 double numbers input
        Console.Write("Enter a: ");
        double a=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter b: ");
        double b=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter c: ");
        double c=Convert.ToDouble(Console.ReadLine());
//operations
        double operation1=a+b*c;
        double operation2=a*b+c;
        double operation3=c+a/b;
        double operation4=a%b+c;

        Console.WriteLine("The results of Double Operations are "+operation1+", "+operation2+", "+operation3+", and "+operation4);
    }
}