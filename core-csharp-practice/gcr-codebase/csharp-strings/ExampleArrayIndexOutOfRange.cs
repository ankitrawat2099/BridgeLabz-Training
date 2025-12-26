using System;
class ExampleArrayIndexOutOfRange
{
    static void Main(){
        try{
            //value array 
            int[] values = { 10, 20, 30 };
            Console.WriteLine(values[6]);
        }
        catch (IndexOutOfRangeException){
            Console.WriteLine("IndexOutOfRangeException for array");
        }
    }
}
