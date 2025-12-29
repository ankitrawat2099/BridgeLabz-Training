
using System;
class SentenceFormater
{
	 char[] CorrectParagraph(string str)
	{
		//list of character for storing the final ans
		char[] ans = new char[str.Length * 2];
		int j = 0;
		//variable of type bool to check the first character ius capatial
		bool isCapital = true;
		bool isSpace = true;
		for(int i = 0; i < str.Length; i++)
		{
			char ch = str[i];
			//checking if the character is alphabet
			if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
			{
				//checking for first letter capital
				if (isCapital && str[i] >= 'a' && str[i] <= 'z')
				{
					ch = (char)(ch - 32);
				}
				ans[j++] = ch;
				isCapital = false;
			}
			//chekig for dot,question mark and exlamatory mark
			else if (ch == '.' || ch == '?' || ch == '!')
			{
				ans[j++] = ch;
				ans[j++] = ' ';
				isCapital = true;

			}
			else
			{
				if (ch == ' ' && isSpace)
				{
					ans[j++] = ' ';
					isSpace = false;
				}


			}

		}
		return ans;
	}




	/*
	Summary:
	This program auto-corrects a poorly formatted paragraph.
	It removes extra spaces, ensures exactly one space after punctuation,
	and capitalizes the first letter of each sentence.
	The logic works character-by-character without using built-in
	string formatting methods.
	*/


	static void Main()
	{
		//take the paragraph as input from user
		Console.Write("enter the sentence: ");
		string str = Console.ReadLine() ?? "";
		SentenceFormater obj = new SentenceFormater();
		char[] ans = obj.CorrectParagraph(str);
		foreach (char c in ans)
		{
			Console.Write(c);
		}
	}

}



