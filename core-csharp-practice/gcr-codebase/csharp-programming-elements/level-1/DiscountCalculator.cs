using System;

class DiscountCalculator
{
    static void Main(String[] args)
    {
        double courseFee = 125000;
        double discount = 10;
//discountAmount
        double discountAmount = (courseFee * discount) / 100;
		//final discount fee
        double finalFee = courseFee - discountAmount;

        Console.WriteLine("The discount amount is INR " + discountAmount + " and final discounted fee is INR " + finalFee);
    }
}
