using System;
class TextToUppercase{
    static void Main(){
        //take the text as input from  user
        Console.Write("Enter text:");
        string input = Console.ReadLine()?? "";
        Console.WriteLine("Manual Uppercase: " + ConvertText(input));
        Console.WriteLine("Built-in: " + input.ToUpper());
    }
//method to convert text to upperscaese
    static string ConvertText(string value){
        char[] temp = new char[value.Length];
        for (int i = 0;i<value.Length;i++){
            char ch = value[i];
            temp[i] = (ch >= 'a' && ch <= 'z') ? (char)(ch - 32) : ch;
        }
        return new string(temp);
    }
}
