using System;

class CheckNumber5
{
    // method to find factors
    public static int[] GetFactors(int number)
    {
        int count = 0;
        for (int i=1;i<= number;i++){
		if (number%i==0){
		count++;}
		}
        int[] factors = new int[count];
        int idx=0;
        for (int i=1;i<=number;i++){
            if (number%i==0){
		factors[idx++]=i;}}
        return factors;
    }

    // method to find the gratest factor
    public static int GreatestFactor(int[] factors)
    {
        int max = int.MinValue;
        foreach (int f in factors){
			if(f>max){
			max=f;}
		}
        return max;
    }

    // method to find sum of factors
    public static int SumFactors(int[] factors)
    {
        int sum = 0;
        foreach (int f in factors) sum += f;
        return sum;
    }

    //method to find the product of factor
    public static int ProductFactors(int[] factors){
        int prod = 1;
        foreach(int f in factors){
		prod=prod*f;}
        return prod;
    }

    //method to find product of cube of factor
    public static double ProductCubeFactors(int[] factors){
        double prod = 1;
        foreach (int f in factors){
		prod *= Math.Pow(f, 3);}
        return prod;
    }

    //method to check perfect number
    public static bool IsPerfect(int number){
        int[] factors=GetFactors(number);
        int sum = 0;
        foreach (int f in factors){
			if (f!=number){
				sum+=f;}
		}
        return sum == number;
    }

    //method to check abundant number
    public static bool IsAbundant(int number)
    {
        int[] factors = GetFactors(number);
        int sum = 0;
        foreach(int f in factors){
			if(f!=number){
		sum += f;}}
        return sum>number;
    }

    //methid to dheck deficient number
    public static bool IsDeficient(int number)
    {
        int[] factors = GetFactors(number);
        int sum = 0;
        foreach(int f in factors){
			if(f!=number){
		sum += f;
	}}
        return sum<number;
    }

    //method to check strong number
    public static bool IsStrong(int number)
    {
        int sum = 0;
		int n = number;
        while(n>0){
            int digit = n % 10;
            int fact = 1;
            for (int i = 1; i <= digit; i++){ fact *= i;}
            sum += fact;
            n /= 10;
        }
        return sum == number;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int[] factors = GetFactors(num);
        Console.WriteLine("Factors: " + string.Join(",", factors));
        Console.WriteLine("Greatest Factor: " + GreatestFactor(factors));
        Console.WriteLine("Sum of Factors: " + SumFactors(factors));
        Console.WriteLine("Product of Factors: " + ProductFactors(factors));
        Console.WriteLine("Product of Cube of Factors: " + ProductCubeFactors(factors));
        Console.WriteLine("Perfect Number: " + IsPerfect(num));
        Console.WriteLine("Abundant Number: " + IsAbundant(num));
        Console.WriteLine("Deficient Number: " + IsDeficient(num));
        Console.WriteLine("Strong Number: " + IsStrong(num));
    }
}
