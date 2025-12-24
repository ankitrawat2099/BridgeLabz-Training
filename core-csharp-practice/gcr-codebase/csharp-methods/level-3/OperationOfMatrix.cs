using System;
class OperationOfMatrix
{
    //method to generate random matrix
    public static int[,] GenerateMatrix(int rows,int cols){
        Random rand = new Random();
        int[,] mat = new int[rows, cols];
        for (int i = 0;i<rows;i++){
            for (int j = 0;j<cols;j++){
		mat[i, j] = rand.Next(1,10);}}
        return mat;
    }

    //method to add two matrices
    public static int[,] Add(int[,] a,int[,] b){
        int rows = a.GetLength(0);
		int cols = a.GetLength(1);
        int[,] sum = new int[rows, cols];
        for (int i = 0;i<rows;i++){
            for (int j = 0; j < cols; j++){
		sum[i, j] = a[i, j] + b[i, j];}}
        return sum;
    }

    //method to subtract two matrices
    public static int[,] Subtract(int[,] a, int[,] b){
        int rows = a.GetLength(0);
		int cols = a.GetLength(1);
        int[,] diff = new int[rows, cols];
        for (int i = 0;i<rows;i++){
            for (int j = 0;j<cols;j++){
		diff[i, j] = a[i, j] - b[i, j];}}
        return diff;
    }

    //method to multiply two matrices
    public static int[,] Multiply(int[,] a, int[,] b){
        int rows = a.GetLength(0);
		int	cols = b.GetLength(1);
		int common = a.GetLength(1);
        int[,] prod = new int[rows, cols];
        for (int i = 0;i<rows;i++){
            for (int j=0;j<cols;j++){
                for (int k = 0;k<common;k++){
		prod[i, j] += a[i, k] * b[k, j];}}}
        return prod;
    }

    //metho to Transpose matrix
    public static int[,] Transpose(int[,] mat)
    {
        int rows = mat.GetLength(0);
		int cols = mat.GetLength(1);
        int[,] trans = new int[cols, rows];
        for (int i = 0;i < rows; i++)
            for (int j = 0; j < cols; j++)
                trans[j, i] = mat[i, j];
        return trans;
    }

    // mehjod to display matrix
    public static void DisplayMatrix(int[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
                Console.Write(mat[i, j] + " ");
            Console.WriteLine();
        }
    }

    static void Main()
    {
		//take thye nmber of rows as input from user
        Console.Write("Enter rows: "); 
		int r = Convert.ToInt32(Console.ReadLine());
		//take the number of col as nput from user
        Console.Write("Enter cols: "); 
		int c = Convert.ToInt32(Console.ReadLine());

        int[,] A = GenerateMatrix(r, c);
        int[,] B = GenerateMatrix(r, c);

        Console.WriteLine("Matrix A:");
        DisplayMatrix(A);
        Console.WriteLine("Matrix B:");
        DisplayMatrix(B);

        Console.WriteLine("Addition:");
        DisplayMatrix(Add(A, B));

        Console.WriteLine("Subtraction:");
        DisplayMatrix(Subtract(A, B));

//multiplication only for square matrices 
        if (r == c) {
            Console.WriteLine("Multiplication:");
            DisplayMatrix(Multiply(A, B));

            Console.WriteLine("Transpose of A:");
            DisplayMatrix(Transpose(A));
        }
    }
}
