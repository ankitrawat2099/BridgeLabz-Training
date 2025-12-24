class UnitConverter3rd
{
	//method to convert temperature
    public static double ConvertFahrenheitToCelsius(double f){
	return (f - 32) * 5 / 9;}
    public static double ConvertCelsiusToFahrenheit(double c){
	return (c * 9 / 5) + 32;}
	//method to convert weight
    public static double ConvertPoundsToKg(double pounds) {
	return pounds * 0.453592;}
    public static double ConvertKgToPounds(double kg){
	return kg * 2.20462;}
	//methd to convert quantity
    public static double ConvertGallonsToLiters(double gallons){
	return gallons * 3.78541;}
    public static double ConvertLitersToGallons(double liters){ 
	return liters * 0.264172;}
	static void Main(){
		//take the input from user
		Console.Write("enter the temperature: ");
		double temperature=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine(ConvertFahrenheitToCelsius(temperature));
		Console.WriteLine(ConvertCelsiusToFahrenheit(temperature));
		//take weight as input form yuser
		Console.Write("enter the weight: ");
		double weight=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine(ConvertPoundsToKg(weight));
		Console.WriteLine(ConvertKgToPounds(weight));
		//take the quantity form user
		Console.Write("enter the quantity: ");
		double quantity=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine(ConvertGallonsToLiters(quantity));
		Console.WriteLine(ConvertLitersToGallons(quantity));
	}
}
