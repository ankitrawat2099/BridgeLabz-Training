using System;

class Trip
{
    static void Main(String[] args)
    {
//take the inputs
        Console.Write("Enter your name: ");
        String name=Console.ReadLine();
        Console.Write("Enter fromCity: ");
        String fromCity=Console.ReadLine();
        Console.Write("Enter viaCity: ");
        String viaCity=Console.ReadLine();
        Console.Write("Enter toCity: ");
        String toCity=Console.ReadLine();
        Console.Write("Enter distance from fromCity to viaCity in miles: ");
        double fromToVia=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter distance from viaCity to toCity in miles: ");
        double viaToFinalCity=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter time taken in hours: ");
        double timeTaken=Convert.ToDouble(Console.ReadLine());
//total distance covered
        double totalDistance=fromToVia+viaToFinalCity;
		//speed
        double speed=totalDistance/timeTaken;

        Console.WriteLine("The results of the trip are: Total Distance "+totalDistance+" miles, Time "+timeTaken+" hours, Average Speed "+speed+" mph"); //output
    }
}