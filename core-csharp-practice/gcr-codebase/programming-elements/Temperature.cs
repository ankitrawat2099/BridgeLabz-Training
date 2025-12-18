class Temperature{
public static void Main(String[] args){
Console.Write("enter the temp in celcius: ");
//take temp in  celcius as input from user
int celcius=Convert.ToInt32(Console.ReadLine());
//apply conversion formula
int fahrenheit=(celcius*9/5)+32;
Console.WriteLine(fahrenheit);
}
}