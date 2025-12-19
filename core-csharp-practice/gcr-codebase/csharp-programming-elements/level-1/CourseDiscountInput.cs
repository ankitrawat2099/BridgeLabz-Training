using System;

class CourseDiscountInput
{
    public static void Main(string[] args)
    {
        // Read fee and discount percentage from user input
        double fee = Convert.ToDouble(Console.ReadLine());
        double discountPercent = Convert.ToDouble(Console.ReadLine());

        // Calculate discount amount
        double discountAmount = (fee * discountPercent) / 100;

        // Calculate final fee after discount
        double finalFee = fee - discountAmount;

        Console.WriteLine($"The discount amount is INR {discountAmount} and final discounted fee is INR {finalFee}"
        );
    }
}