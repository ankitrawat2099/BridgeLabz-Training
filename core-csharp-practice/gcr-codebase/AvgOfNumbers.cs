
class AvgOfNumbers
{
    static void Main(string[] args)
    {
        //take first nunmber as input from user
        Console.Write("Enter first no: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        //take second number as input from user
        Console.Write("Enter second no: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        //take third number as input from user
        Console.Write("Enter third no: ");
        double num3 = Convert.ToDouble(Console.ReadLine());
        //calculate average of three numbers
        double avg = (num1 + num2 + num3) / 3;

        Console.WriteLine(avg);
    }
}