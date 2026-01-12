using System;
using System.IO;

class ReadConsoleToWriteFile
{
    static void Main()
    {
        string path = "C:\\Users\\admin\\Downloads\\strings\\demo.txt";
        //take the input from user
        Console.Write("Enter text: ");
        string content = Console.ReadLine();
        //write data
        File.WriteAllText(path, content);
        Console.WriteLine("Data written successfully.");
    }
}
