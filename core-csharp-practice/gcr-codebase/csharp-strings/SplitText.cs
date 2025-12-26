using System;
class SplitText{
    static void Main(){
        // take the word input form user
        Console.Write("Enter text:");
        string word = Console.ReadLine() ?? "";
        string[,] wordData = SplitWordsAndLengths(word);
        Console.WriteLine("Word     Length");
        for(int i = 0;i<wordData.GetLength(0);i++){
            Console.WriteLine($"{wordData[i, 0]}\t{wordData[i, 1]}");
        }
    }
    // Method to split words manualy
    static string[,] SplitWordsAndLengths(string text){
        // Count words
        int wordCount = 1;
        for(int i = 0;i<GetStringLength(text);i++){
            if(text[i] == ' ')
                wordCount++;
        }
        string[,] result = new string[wordCount, 2];
        string currentWord = "";
        int index = 0;

        for(int i = 0;i<=GetStringLength(text);i++){
            if(i == GetStringLength(text) || text[i] == ' '){
                // Store word and its length
                result[index, 0] = currentWord;
                result[index, 1] = GetStringLength(currentWord).ToString();
                currentWord = "";
                index++;
            }
            else{
                currentWord += text[i];
            }
        }
        return result;
    }
    // Method to calculate string lenghth
    static int GetStringLength(string input){
        int count = 0;
        foreach(char _ in input){
            count++;
        }
        return count;
    }
}
