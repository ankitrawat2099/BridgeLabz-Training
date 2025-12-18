class AreaOfCircle{
public static void Main(String[] args){
Console.Write("enter the radius of circle: ");
//take radius as input from user
	double radius=Convert.ToInt32(Console.ReadLine());
	double pie=Math.PI;
	Console.WriteLine(pie*radius*radius);
}
}