using System;

class ChocolatesDistribution
{
    static void Main(String[] args)
    {
       //take input of no of chocolates
        Console.Write("Enter number of chocolates: ");
        int numberOfChocolates=Convert.ToInt32(Console.ReadLine());
		//take input of number Of Children
        Console.Write("Enter number of children: ");
        int numberOfChildren=Convert.ToInt32(Console.ReadLine());
//divide
        int chocolatesPerChild=numberOfChocolates/numberOfChildren;
		//take raminder
        int remainingChocolates=numberOfChocolates%numberOfChildren;

        Console.WriteLine("The number of chocolates each child gets is "+chocolatesPerChild+
                          " and the number of remaining chocolates is "+remainingChocolates); //output
    }
}