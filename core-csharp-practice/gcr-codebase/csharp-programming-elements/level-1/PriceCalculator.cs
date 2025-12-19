using System;

class PriceCalculator
{
    static void Main()
    {
//take the input from user for unitprice
        Console.Write("Enter the unit price of the item: ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());
//input form user for quantity
        Console.Write("Enter the quantity to be bought: ");
        int quantity = Convert.ToInt32(Console.ReadLine());
//calculate totalCost
        double totalCost = unitPrice * quantity;

        Console.WriteLine("The total purchase price is INR " + totalCost +" if the quantity " + quantity +" and unit price is INR " + unitPrice
        );
    }
}
