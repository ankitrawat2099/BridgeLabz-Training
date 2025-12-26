using System;
class CreateSubstring
{
    static void Main()
    {
	//take the stirng as input from user
        Console.WriteLine("Enter string:");
        string data = Console.ReadLine();
		
//tkae the start index from user
        Console.WriteLine("Enter start index:");
        int startIndex = Convert.ToInt32(Console.ReadLine());
//take the end index from user
        Console.WriteLine("Enter end index:");
        int endIndex = Convert.ToInt32(Console.ReadLine());
        string manualSub = CreateManual(data, startIndex, endIndex);
        string builtInSub = data.Substring(startIndex, endIndex - startIndex);
        Console.WriteLine("Manual Substring: " + manualSub);
        Console.WriteLine("Built-in: " + builtInSub);
    }
//method to create the substring manualy
    static string CreateManual(string value,int start,int end)
    {
        string result = "";
        for (int i = start;i < end;i++){
            result += value[i];
        }
        return result;
    }
}
