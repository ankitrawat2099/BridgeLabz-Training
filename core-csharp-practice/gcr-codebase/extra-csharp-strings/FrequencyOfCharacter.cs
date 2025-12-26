using System;
class FrequencyOfCharacter{
    static void Main(){
        //tkae the strng as input from user
        Console.Write("Enter a string:");
        string text = Console.ReadLine() ?? "";
        int max = 0;
        char frequent=' ';
        for(int i = 0;i<text.Length;i++){
            int count = 0;
            for(int j = 0;j<text.Length;j++){
                if(text[i] == text[j])
                    count++;
            }

            if(count > max)
            {
                max = count;
                frequent = text[i];
            }
        }

        Console.WriteLine(frequent);
    }
}
