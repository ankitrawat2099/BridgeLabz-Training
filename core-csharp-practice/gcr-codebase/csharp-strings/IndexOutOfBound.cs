using System;
class IndexOutOfBound
{
    static void Main()
    {
        try
        {
            //string input
            string str = "Hello";
            Console.WriteLine(str[10]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("IndexOutOfRangeException caught ");
        }
    }
}
