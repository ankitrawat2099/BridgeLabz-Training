using System;

class ProfitLossCalculator
{
    static void Main(String[] args)
    {
        double costPrice = 129;
        double sellingPrice = 191;
//calculate profit
        double profit = sellingPrice - costPrice;
		//calculate percentage of profit
        double profitPercentage = (profit / costPrice) * 100;

        Console.WriteLine( "The Cost Price is INR " + costPrice + " and Selling Price is INR " + sellingPrice + "\n" +"The Profit is INR " + profit + " and the Profit Percentage is " + profitPercentage + "%"
        );
    }
}
