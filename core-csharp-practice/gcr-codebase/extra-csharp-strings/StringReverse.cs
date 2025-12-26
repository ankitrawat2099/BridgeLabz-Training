using System;
class StringReverse
{
    static void Main(){
        //take sthe string as input from user
        Console.Write("Enter a string to reverse:");
        string input = Console.ReadLine() ?? "";
        char[] reversed = new char[input.Length];
        int index = 0;
        for(int i =input.Length - 1;i>=0;i--){
            reversed[index++] = input[i];
        }
//printing the reversed string
        Console.WriteLine(reversed);
    }
}
