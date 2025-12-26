using System;
class SnakeAndLadder
{
    static int[] playerPositions = new int[4];
    static string[] playerNames = new string[4];
    static int playerCount;
    static Random random = new Random();
	//board 
    static int[] board = new int[101];
	
	//method to initiliase the board for snake and ladder
	 static void InitializeBoard()
    {
        // Ladder
        board[3] = 22;
        board[5] = 8;
        board[11] = 26;
        board[20] = 29;

        // Snake
        board[27] = 1;
        board[21] = 9;
        board[17] = 4;
        board[19] = 7;
    }
	
	//method to roll dice
 static int RollDice(){
        return random.Next(1, 7);
    }

//method to get the no of player
 static void GetPlayers(){
        do{
            Console.Write("Enter number of players (2–4): ");
            playerCount = Convert.ToInt32(Console.ReadLine());
        }
        while(playerCount < 2 || playerCount > 4);

        for(int i = 0;i<playerCount;i++){
            Console.Write("Enter player name: ");
            playerNames[i] = Console.ReadLine();
            playerPositions[i] = 0;
        }
    }
	
	//method to check snaker or ladder
    static int ApplySnakeOrLadder(int position){
        if(board[position] != 0){
            string msg = board[position] > position ? "Ladder" : "Snake";
            Console.WriteLine(msg + " found!");
            return board[position];
        }

        return position;
    }

//method to check win or not
    static bool CheckWin(int position){
        switch (position)
        {
            case 100:
                return true;
            default:
                return false;
        }
    }

    static void Main(){
        Console.WriteLine("game of snake and ladder:");
//calling board initilise method
        InitializeBoard();
		//calling get playr metod
        GetPlayers();

        bool gameFinished = false;
//loop until game is not finsihed
        while(!gameFinished){
            for(int i = 0;i<playerCount;i++){
                Console.WriteLine("\nPlayer Turn: " + playerNames[i]);
                Console.Write("Press ENTER to roll dice");
                Console.ReadLine();
                int dice = RollDice();
                int oldPos = playerPositions[i];
                int newPos = oldPos + dice;

                Console.WriteLine("Dice: " + dice);
//chekcin if move is greater than 100 or not
                if(newPos > 100){
                    Console.WriteLine("Move skipped beyond 100");
                    continue;
                }

                newPos = ApplySnakeOrLadder(newPos);
                playerPositions[i] = newPos;

                Console.WriteLine("Position: " + oldPos + " → " + newPos);

                if(CheckWin(newPos)){
                    Console.WriteLine(playerNames[i] + " wins the game!");
                    gameFinished = true;
                    break;
                }
            }
        }
        Console.WriteLine("\nGame Over");
    }
   
}
