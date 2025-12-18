class SimpleInterest{
public static void Main(){
Console.Write("Enter the principal: ");
//take principal as input from user
float principal=Convert.ToSingle(Console.ReadLine());
Console.Write("Enter the rate: ");
//take rate as input from user
float rate=Convert.ToSingle(Console.ReadLine());
Console.Write("Enter the time: ");
//take time as input from user
float time=Convert.ToSingle(Console.ReadLine());
//apply simple interest formula
float simpleInterest=(principal*rate*time)/100;
Console.WriteLine(simpleInterest);


}

}