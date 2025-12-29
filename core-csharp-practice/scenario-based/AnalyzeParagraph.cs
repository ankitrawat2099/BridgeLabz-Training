/*
Summary:
This program analyzes a paragraph of text by performing multiple string operations. 
It counts the total number of words, identifies the longest word, replaces all occurrences 
of a given word with another word in a case-insensitive manner, and safely handles edge cases 
such as empty input or text containing only spaces.*/

using System;
class AnalyzeParagraph
{
    //method to check the case sensitve of words
     bool CaseSesitive(string a, string b)
    {
        if (a.Length != b.Length)
        {
            return false;
        }

        for (int i = 0; i < a.Length; i++)
        {
            char c1 = a[i];
            char c2 = b[i];

            if (c1 >= 'A' && c1 <= 'Z')
            {
                c1 = (char)(c1 + 32);
            }

            if (c2 >= 'A' && c2 <= 'Z')
            {
                c2 = (char)(c2 + 32);
            }

            if (c1 != c2)
            {
                return false;
            }
        }
        return true;
    }
    //method to count the words and find longest word int the paragraph 
     void CountAndFindLongestWord(string str)
    {
        int count = 0;
        int maxLength = 0;
        string longestWord = "";
        string currentWord = "";
        for (int i = 0; i <= str.Length; i++)
        {
            if (i < str.Length && str[i] != ' ')
            {
                currentWord += str[i];
            }
            else
            {
                if (currentWord.Length > 0)
                {
                    count++;
                    if (currentWord.Length > maxLength)
                    {
                        maxLength = currentWord.Length;
                        longestWord = currentWord;
                    }
                    currentWord = "";
                }
            }
        }

        Console.WriteLine("Word Count: " + count);
        Console.WriteLine("Longest Word: " + longestWord);
    }
    //method to replace the old word with new word
     string ReplaceWord(string str, string oldWord, string newWord)
    {
        string ans = "";
        string currentWord = "";
        for (int i = 0; i <= str.Length; i++)
        {
            if (i < str.Length && str[i] != ' ')
            {
                currentWord += str[i];
            }
            else
            {
                if (currentWord.Length > 0)
                {
                    if (CaseSesitive(currentWord, oldWord))
                    {
                        ans += newWord;
                    }
                    else
                    {
                        ans += currentWord;
                    }

                    currentWord = "";
                }

                if (i < str.Length)
                    ans += " ";
            }
        }
        return ans;
    }

    static void Main()
{

        //tkae the paragraph as inpur from user
        Console.Write("Enter a paragraph:");
        string str = Console.ReadLine() ?? "";
        AnalyzeParagraph obj = new AnalyzeParagraph();

        bool hasChar = false;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != ' ')
            {
                hasChar = true;
                break;
            }
        }

        if (!hasChar)
        {
            Console.Write("Paragraph is empty or contains only the spaces.");
            return;
        }

        //calling the CountAndFindLongestWord method
        obj.CountAndFindLongestWord(str);

        //take the word to replace from user as input
        Console.Write("Enter the word to replace:");
        string oldWord = Console.ReadLine() ?? "";
        //take the new word form user as input
        Console.Write("Enter the new word:");
        string newWord = Console.ReadLine() ?? "";
        Console.Write("new paragraph:");
        Console.WriteLine(obj.ReplaceWord(str, oldWord, newWord));
    }


}
