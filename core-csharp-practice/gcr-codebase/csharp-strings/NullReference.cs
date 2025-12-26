using System;
class NullReference
{
    static void Main()
    {
        try
        {//inmput string
            string message = null;
            Console.WriteLine(message.Length);
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("NullReferenceException");
        }
    }
}
