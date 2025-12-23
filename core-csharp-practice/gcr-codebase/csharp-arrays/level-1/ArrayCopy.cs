using System;

class ArrayCopy
{
    static void Main(string[] args)
    {
		//take the number of rows from user 
        Console.Write("Enter the  row: ");
        int row = Convert.ToInt32(Console.ReadLine());
//take the number of column from user 
        Console.Write("Enter column: ");
        int col = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[row, col];
        int[] arr = new int[row * col];
        int index = 0;

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
				//storing the element in 2d array
                Console.Write($"Enter the element: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                arr[index++] = matrix[i, j];
            }
        }
//printing the element of 1d array
        for(int i=0;i<=arr.Length;i++){
		Console.Write(arr[i]+ " ");}
    }
}
