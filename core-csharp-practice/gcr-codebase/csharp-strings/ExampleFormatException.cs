using System;
class ExampleFormatException
{
    static void Main()
    {
        try
        {
            //number input
            int number = int.Parse("av123");
        }
        catch (FormatException)
        {
            Console.WriteLine("FormatException occurred while parsing");
        }
    }
}
