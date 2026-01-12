using System;

class MatrixBinarySearch
{
    static void Main()
    {
        //take the number of rows input from usr
        Console.Write("Enter rows: ");
        int rows = int.Parse(Console.ReadLine());
 //take the number of coloumn input from usr
        Console.Write("Enter columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Enter matrix elements row-wise:");
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                matrix[i, j] = int.Parse(Console.ReadLine());

        Console.Write("Enter target value: ");
        int target = int.Parse(Console.ReadLine());

        int left = 0, right = rows * cols - 1;
        bool found = false;

        // Treat matrix as 1D sorted array
        while (left <= right)
        {
            int mid = (left + right) / 2;
            int r = mid / cols;
            int c = mid % cols;

            if (matrix[r, c] == target)
            {
                found = true;
                break;
            }
            else if (matrix[r, c] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        Console.WriteLine(found ? "Target Found" : "Target Not Found");
    }
}
