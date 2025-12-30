using System;
class Circle
{
    private double radius;

    //constructor to initialize radius
    public Circle(double r)
    {
        radius = r;
    }

    //method to calculate area
    public double CalculateArea()
    {
        double pi = 3.14159;
        return pi * radius * radius;
    }

    //method to calculate circumference
    public double CalculateCircumference()
    {
        double pi = 3.14159;
        return 2 * pi * radius;
    }

    //method to display results
    public void Display()
    {
        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Area of Circle: " + CalculateArea());
        Console.WriteLine("Circumference of Circle: " + CalculateCircumference());
    }
}

class Program
{
    static void Main()
    {
	//tkae the radius of circel as input from user
        Console.Write("Enter radius of the circle: ");
        double r = Convert.ToDouble(Console.ReadLine());

        Circle c = new Circle(r);
        c.Display();
    }
}
