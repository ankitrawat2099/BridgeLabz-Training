using System;

class WindChillCalculator
{
	//method to find temperature
    static double CalculateWindChill(double temperature, double windSpeed)
    {
        return 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
    }

    static void Main()
    {
	//take the temperature as input from user
        Console.Write("Enter temperature: ");
        double temperature = Convert.ToDouble(Console.ReadLine());
//take the windSpeedas input from user
        Console.Write("Enter wind speed: ");
        double windSpeed= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Temperature:{CalculateWindChill(temperature, windSpeed)}");
    }
}
