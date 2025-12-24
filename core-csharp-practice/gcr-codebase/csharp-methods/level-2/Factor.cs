using System;

class Factor
{
	//method to find factos
    static int[] findFactor(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++){
		if (number % i == 0){ 
		count++;}
		}

        int[] factors = new int[count];
        int index = 0;

        for (int i = 1; i <= number; i++){
            if (number % i == 0){ 
			factors[index++] = i;}
			}

        return factors;
    }
//method to calcualte the sum of factors
    static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        for(int i=0;i<factors.Length;i++){
		sum += factors[i];}
        return sum;
		
    }
	//method to find the product of factors

    static long ProductOfFactors(int[] factors)
    {
        long product = 1;
        foreach (int f in factors) product *= f;
        return product;
    }

//method to find the sum of squears of factors
    static double SumOfSquareFactor(int[] factors)
    {
        double sum = 0;
        foreach (int f in factors) sum += Math.Pow(f, 2);
        return sum;
    }

    static void Main()
    {
		//take the number as input from user
        Console.Write("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());
//factors array to store factors
        int[] factors = findFactor(num);

        Console.WriteLine("Factors:");
        for(int i=0;i<factors.Length;i++){ 
		Console.WriteLine(factors[i] + " ");}
        Console.WriteLine($"Sum: {SumOfFactors(factors)}");
        Console.WriteLine($"Product: {ProductOfFactors(factors)}");
        Console.WriteLine($"Sum of Squares: {SumOfSquareFactor(factors)}");
    }
}
