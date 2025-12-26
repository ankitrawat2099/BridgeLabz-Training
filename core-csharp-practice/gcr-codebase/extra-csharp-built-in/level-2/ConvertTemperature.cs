using System;
class ConvertTemperature
{
    //method to convert Celsius to Fahrenheit
    static double CelsiusToFahrenheit(double celsius){
        return (celsius * 9 / 5) + 32;
    }

    //method to Convert Fahrenheit to Celsius
    static double FahrenheitToCelsius(double fahrenheit){
        return (fahrenheit - 32) * 5 / 9;
    }

    static void Main(){
        //take the converson choice fro user
        Console.Write("Choose conversion (C for Celsius, F for Fahrenheit): ");         
        char choice = Console.ReadKey().KeyChar;
        Console.WriteLine();
//take the temperature value as input from user
        Console.Write("Enter temperature value: ");
        bool isValid = double.TryParse(Console.ReadLine()!, out double temperature);
        if (!isValid){
            Console.WriteLine("Invalid temperature input.");
            return;
        }
        if (choice == 'C' || choice == 'c')
        {
            double result = FahrenheitToCelsius(temperature);
            Console.WriteLine("Temperature in Celsius: " + result);
        }
        else if (choice == 'F' || choice == 'f')
        {
            double result = CelsiusToFahrenheit(temperature);
            Console.WriteLine("Temperature in Fahrenheit: " + result);
        }
        else
        {
            Console.WriteLine("Invalid conversion choice.");
        }
    }
}
