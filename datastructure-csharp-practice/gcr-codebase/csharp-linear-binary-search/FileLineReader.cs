using System;
using System.IO;

class FileLineReader
{
    static void Main()
    {
        //path of file
        string path = "C:\\Users\\admin\\Downloads\\strings\\demo.txt";

        StreamReader sr = new StreamReader(path);
        
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        
    }
}
