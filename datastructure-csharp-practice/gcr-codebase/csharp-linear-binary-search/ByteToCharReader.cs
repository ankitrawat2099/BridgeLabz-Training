using System;
using System.IO;
using System.Text;

class ByteToCharReader
{
    static void Main()
    {
        string path = "C:\\Users\\admin\\Downloads\\strings\\demo.txt";

        StreamReader reader = new StreamReader(new FileStream(path,FileMode.Open), Encoding.UTF8);
        int i=0;
        while((i=reader.Read())!=-1){
            Console.Write((char)i);
        }
           
        
    }
}
