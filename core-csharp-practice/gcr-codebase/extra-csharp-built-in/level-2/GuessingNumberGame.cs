using System;
class GuessingNumberGame
{
    //method to generate a random guess
    static int GenerateGuess(int low, int high){
        Random rand = new Random();
        return rand.Next(low, high + 1);
    }

    //method to get feedback from user
    static string GetFeedback(){
        Console.Write("Is the guess High, Low, or Correct? ");
        return Console.ReadLine()!.ToLower();
    }

    static void Main(){
        int low = 1, high = 100;
        string feedback;

        Console.WriteLine("Think a number between 1 and 100.");
        do
        {
              int guess = GenerateGuess(low, high);
            Console.WriteLine("Computer Guess: " + guess);
            feedback = GetFeedback();
            if (feedback == "high"){
                high = guess - 1;}
            else if (feedback == "low"){
                low = guess + 1;}

        } 
        while (feedback != "correct");
        Console.WriteLine("Number guessed successfully!");
    }
}
