class Exponent
{
    static void Main(string[] args)
    {
        Console.Write("Enter the base: ");
        //take base as input from user
        double baseNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the exponent: ");
        //take exponent as input from user
        double exponent = Convert.ToDouble(Console.ReadLine());
//calculate power
        Console.WriteLine(Math.Pow(baseNumber, exponent));
    }
}