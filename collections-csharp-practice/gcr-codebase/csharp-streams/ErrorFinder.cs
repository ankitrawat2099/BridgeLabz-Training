using System;
using System.IO;

class ErrorFinder
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("C:\\Users\\admin\\Downloads\\streams\\destination.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.ToLower().Contains("error"))
                    Console.WriteLine(line);
            }
        }
    }
}
