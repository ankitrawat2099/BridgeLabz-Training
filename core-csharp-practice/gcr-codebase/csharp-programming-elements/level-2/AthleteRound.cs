using System;

class AthleteRound
{
    static void Main(String[] args)
    {
     //take input of sides   
        Console.Write("Enter side1 in meters: ");
        double side1=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter side2 in meters: ");
        double side2=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter side3 in meters: ");
        double side3=Convert.ToDouble(Console.ReadLine());
		//perimeter
        double perimeter=side1+side2+side3;           
        double totalDistance=5*1000;                   
        double totalRounds=totalDistance/perimeter;      

        Console.WriteLine("The total number of rounds the athlete will run is "+totalRounds);
    }
}