class VolumeOfCylinder{
public static void Main(String[] args){
Console.Write("enter the radius of cylinder: ");
//take radius as input from user
	double radius=Convert.ToInt32(Console.ReadLine());
	Console.Write("enter the height of cylinder: ");
	//take height as input from user
	double height=Convert.ToInt32(Console.ReadLine());
	//apply volume formula with pi value
	double pie=Math.PI;
	Console.WriteLine(pie*radius*radius*height);
}
}