       
using System;

class KmToMilesInput
{
    static void Main()
    {
        double Kilometers;
       

        Console.Write("Enter distance in kilometers: ");
        Kilometers = Convert.ToDouble(Console.ReadLine());

        double Miles = Kilometers *1.6;

        Console.WriteLine(
            "The total miles is " + Miles +" mile for the given " +Kilometers + " km"
        );
    }
}
