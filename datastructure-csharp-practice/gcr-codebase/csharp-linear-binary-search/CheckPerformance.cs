using System;
using System.Text;
using System.Diagnostics;

class CheckPerformance
{
    static void Main()
    {
        Stopwatch watch = new Stopwatch();

        watch.Start();
        //string builder to append 
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 10000; i++)
        {
            sb.Append(i);
        }
        watch.Stop();

        Console.WriteLine("StringBuilder Time (ms): " + watch.ElapsedMilliseconds);
    }
}
