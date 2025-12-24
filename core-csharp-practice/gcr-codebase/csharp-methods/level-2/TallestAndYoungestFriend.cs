using System;

class TallestAndYoungestFriend
{
	//method to find yountest
    static int FindYoungest(int[] ages)
    {
        int min = ages[0];
        for (int i = 1;i<ages.Length;i++){
		if (ages[i] < min) min = ages[i];}
        return min;
    }
//method to find tallest
    static int FindTallest(int[] heights)
    {
        int max = heights[0];
        for (int i = 1; i<heights.Length; i++)
            if (heights[i]>max){
			max = heights[i];}
        return max;
    }

    static void Main()
    {
        int[] ages = new int[3];
        int[] heights = new int[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter age of friend: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter height of friend {i + 1}: ");
            heights[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"Youngest: {FindYoungest(ages)}");
        Console.WriteLine($"Tallest: {FindTallest(heights)}");
    }
}
