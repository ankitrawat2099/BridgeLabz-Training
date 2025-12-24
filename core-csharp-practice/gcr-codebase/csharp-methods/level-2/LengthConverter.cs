class LengthConverter
{
	//method to conver yards to feet
    public static double ConvertYardsToFeet(double yards){
return	yards * 3;}
//method to conver feet to yards
    public static double ConvertFeetToYards(double feet){
	return feet * 0.333333;}
//method to conver meters to inches
    public static double ConvertMetersToInches(double meters){
	return meters * 39.3701;}
	//method to conver inches to meters
    public static double ConvertInchesToMeters(double inches){
	return inches * 0.0254;}
	//method to conver inches to centimeters
    public static double ConvertInchesToCentimeters(double inches){
	return inches * 2.54;}
	
	static void Main(){
			//take the distance from user
		Console.Write("enter the distance: ");
		double distance=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine(ConvertYardsToFeet(distance));
		Console.WriteLine(ConvertFeetToYards(distance));
		Console.WriteLine(ConvertMetersToInches(distance));
		Console.WriteLine(ConvertInchesToMeters(distance));
		Console.WriteLine(ConvertInchesToCentimeters(distance));
	
	}
}
