using System;
class Circle
{
    public double Radius;
//default constructro
    public Circle(){ 
	Radius=12.2; }
//parametrised constructor
    public Circle(double radius)
    {
        Radius = radius;
    }
	static void Main(){
	Circle c1=new Circle();
	Console.WriteLine(c1.Radius);
	Circle c2=new Circle(10.2);
	Console.WriteLine(c2.Radius);
	}
}
