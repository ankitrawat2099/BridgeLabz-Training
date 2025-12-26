using System;
class TextToLowercase{
    static void Main(){
        //tke the text as input from user
        Console.Write("Enter text:");
        string input = Console.ReadLine()?? "";
        Console.WriteLine("Manual Lowercase: " +ConvertText(input));
        Console.WriteLine("Built-in:" + input.ToLower());
    }
//method to convert text to lowercase
    static string ConvertText(string value){
        char[] temp = new char[value.Length];
        for (int i = 0;i<value.Length;i++){
            char ch = value[i];
            temp[i] = (ch >= 'A' && ch <= 'Z') ? (char)(ch + 32) : ch;
        }
        return new string(temp);
    }
}
