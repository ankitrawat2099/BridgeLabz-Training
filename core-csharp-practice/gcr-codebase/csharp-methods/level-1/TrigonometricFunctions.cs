using System;

class TrigonometricFunctions
{
//method to find angles
    public static double[] calculateTrigonometricFunctions(double angle)
    {
        double radians = angle* Math.PI / 180;
        return new double[]
        {
            Math.Sin(radians),
            Math.Cos(radians),
            Math.Tan(radians)
        };
    }
    static void Main()
    {
	//take the angle in degrees form user
        Console.Write("Enter angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        double[] result = calculateTrigonometricFunctions(angle);
        Console.WriteLine($"sine: {result[0]},cosine: {result[1]},tangent: {result[2]}");
    }
}
