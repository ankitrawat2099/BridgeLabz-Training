using System;

class Quadratic
{
//method to find roots
    static double[] FindRoots(double a, double b, double c)
    {
        double delta = b * b - 4 * a * c;

        if (delta<0){
		return new double[0];}
        if (delta == 0){
		return new double[] { -b / (2 * a) };}

        double sqrt = Math.Sqrt(delta);
        return new double[]
        {
            (-b + sqrt) / (2 * a),
            (-b - sqrt) / (2 * a)
        };
    }

    static void Main()
    {
	//take the number as inp0ut from user
        Console.Write("Enter a, b, c: ");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        double[] roots = FindRoots(a,b,c);
//check use enter the roots
        if (roots.Length==0)
            Console.WriteLine("No real roots");
        else
            foreach (double r in roots)
                Console.WriteLine($"Root: {r}");
    }
}
