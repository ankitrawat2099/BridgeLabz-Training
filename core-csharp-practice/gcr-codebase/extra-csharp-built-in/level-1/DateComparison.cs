using System;
using System.Globalization;
class DateComparison{
    //method tp compare two dates
    static void DateCompare(DateTime firstDate, DateTime secondDate){
        if (firstDate < secondDate){
            Console.WriteLine("First date is before second date");}
        else if (firstDate > secondDate){
            Console.WriteLine("First date is after second date");}
        else{
            Console.WriteLine("Both dates are the same");}
    }

    static void Main(){
        //taking input of date fist form user
        Console.Write("Enter first date (dd-MM-yyyy): ");
        string input1 = Console.ReadLine()!;                        
        //taking input of date second form user
        Console.Write("Enter second date (dd-MM-yyyy): ");
        string input2 = Console.ReadLine()!;                      
        DateTime date1 = DateTime.ParseExact(input1, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        DateTime date2 = DateTime.ParseExact(input2, "dd-MM-yyyy", CultureInfo.InvariantCulture);

        DateCompare(date1, date2);   
    }
}
