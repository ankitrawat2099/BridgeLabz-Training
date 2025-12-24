using System;

class FootballPlayers
{
    //method to generate random heights for players
    public static int[] GetHeights(int players){
        Random rand = new Random();
        int[] heights = new int[players];
        for (int i = 0;i<players;i++){
		heights[i] = rand.Next(150, 251);} 
        return heights;
    }

    //metod to find shortest height
    public static int FindShortest(int[] array){
        int min = int.MaxValue;
        foreach (int h in array){
	if(h < min){
		min = h;}}
        return min;
    }

    //method to find tallest height
    public static int FindTallest(int[] array){
        int max = int.MinValue;
        foreach (int h in array){
		if (h > max){
			max = h;}
		}
        return max;
    }

    //method to calculate mean height
    public static double FindMean(int[] array){
        int sum = 0;
        foreach(int h in array){
		sum += h;}
        return (double)sum / array.Length;
    }

    static void Main(){
		//take the heights of 11 playrs
        int[] heights = GetHeights(11); 
        Console.WriteLine("Player Heights:");
        foreach(int h in heights){
		Console.Write(h + " ");}
        Console.WriteLine();
        // Display shortest
        Console.WriteLine("Shortest: " + FindShortest(heights));
		 //display tallest 
        Console.WriteLine("Tallest: " + FindTallest(heights));
		//display mean
        Console.WriteLine("Mean: " + Math.Round(FindMean(heights), 2));
    }
}
