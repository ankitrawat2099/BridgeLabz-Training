
class KmToMiles
{
    static void Main(string[] args)
    {
        Console.Write("Enter distance kilometers: ");
        //take radius as input from user
        double kilometer= Convert.ToDouble(Console.ReadLine());
        //apply conversion fromula
        double miles = kilometer * 0.621371;

        Console.WriteLine(miles);
    }
}