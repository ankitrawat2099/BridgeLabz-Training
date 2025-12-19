using System;

class FahrenheitToCelsiusConverter
{
    static void Main(String[] args)
    {
       //take the temperature input in fahrenheit
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit=Convert.ToDouble(Console.ReadLine());
//convert temperature to celsius
        double celsius=(fahrenheit-32)*5/9; 

        Console.WriteLine("The "+fahrenheit+" Fahrenheit is "+celsius+" Celsius");
    }
}