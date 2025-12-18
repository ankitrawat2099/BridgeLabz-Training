class PerimeterOfRectangle{
public static void Main(){
	Console.Write("enter the length of rectangle: ");
	//take length as input from user
	float length=Convert.ToSingle(Console.ReadLine());
	Console.Write("enter the breadth of rectangle: ");
	//take breadth as input from user
	float breadth=Convert.ToSingle(Console.ReadLine());
	//calculate perimeter
	float perimter=2*(length+breadth);
	Console.WriteLine(perimter);
}
}