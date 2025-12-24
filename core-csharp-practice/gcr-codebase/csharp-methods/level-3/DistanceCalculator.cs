using System;
class DistanceCalculator
{
    //methiod to calculate Euclidean distance
    public static double EuclideanDistance(double x1, double y1, double x2, double y2){
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    //method to calculate line equation y = mx + c
    public static double[] LineEquation(double x1, double y1, double x2, double y2){
		//calculate slope
        double m = (y2 - y1) / (x2 - x1);
        double b = y1 - m * x1;        
        return new double[] { m, b };
    }
    static void Main(){
        Console.Write("Enter x1: ");
		double x1 =Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y1: "); 
		double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter x2: "); 
		double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y2: ");
		double y2 = Convert.ToDouble(Console.ReadLine());
        double dist = EuclideanDistance(x1, y1, x2, y2);
        double[] eq = LineEquation(x1, y1, x2, y2);
        Console.WriteLine("Distance: " + dist);
        Console.WriteLine($"Line Equation: y = {eq[0]}x + {eq[1]}");
    }
}
