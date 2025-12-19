using System;

class TemperatureConverter
{
    static void Main(String[] args)
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius=Convert.ToDouble(Console.ReadLine());
//convert the celsius to fahrenheit
        double fahrenheit=(celsius*9/5)+32; 

        Console.WriteLine("The "+celsius+" Celsius is "+fahrenheit+" Fahrenheit");
    }
}