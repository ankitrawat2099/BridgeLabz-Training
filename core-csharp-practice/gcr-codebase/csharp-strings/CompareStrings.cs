using System;
class CompareStrings{
 
  static bool CompareManual(string a,string b)
    {
        if (a == null || b == null){
		return false;}
        if (a.Length != b.Length){
		return false;}

        for (int i = 0;i< a.Length;i++){
            if (a[i] != b[i]){
			return false;}
        }
        return true;
    }

 
 static void Main()
    {
        //take the fist stirng as input from user
        Console.Write("Enter first string:");
        string first = Console.ReadLine();
		//take the second stirng as input from user
        Console.Write("Enter second string:");
        string second = Console.ReadLine();

        bool manualCompare = CompareManual(first,second);
        bool builtInCompare = string.Equals(first,second);

        Console.WriteLine($"Manual Compare: {manualCompare}");
        Console.WriteLine($"Built-in: {builtInCompare}");
		}}