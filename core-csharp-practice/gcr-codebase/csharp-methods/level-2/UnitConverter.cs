using System;
class UnitConverter
{
//method to convert km to miles
	public static double ConvertKmToMiles(double km){
		return km * 0.621371;}
//method to convert miles to km 
    public static double ConvertMilesToKm(double miles){
		return	miles * 1.60934;}
		//method to convert meters to feet
    public static double ConvertMetersToFeet(double meters){
		return meters * 3.28084;}
	//method to convert feet to meters
    public static double ConvertFeetToMeters(double feet){
		return feet * 0.3048;
		}
		
		static void Main(){
			//take the distance from user
		Console.Write("enter the distance: ");
		double distance=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine(ConvertKmToMiles(distance));
		Console.WriteLine(ConvertMilesToKm(distance));
		Console.WriteLine(ConvertMetersToFeet(distance));
		Console.WriteLine(ConvertFeetToMeters(distance));
		}
}
