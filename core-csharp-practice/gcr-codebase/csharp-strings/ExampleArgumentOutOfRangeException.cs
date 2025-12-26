using System;
class ExampleArgumentOutOfRangeException
{
    static void Main()
    {
        try
        {
            //input text
            string text = "hello world";
            Console.WriteLine(text.Substring(4, 10));
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("ArgumentOutOfRangeException handled");
        }
    }
}
