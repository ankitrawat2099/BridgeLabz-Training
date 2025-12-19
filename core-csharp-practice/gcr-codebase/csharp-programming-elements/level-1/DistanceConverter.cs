using System;

class DistanceConverter
{
    public static void Main(string[] args)
    {
        // Read distance in feet from user input
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());

        // Convert distance to yards
        double distanceInYards = distanceInFeet / 3;

        // Convert distance to miles
        double distanceInMiles = distanceInYards / 1760;

        Console.WriteLine(
            $"The distance in yards is {distanceInYards} and in miles is {distanceInMiles}"
        );
    }
}