using System;
using System.Globalization;
class DateArithmetic
{
    //method to perform all date operations
    static DateTime DateOperations(DateTime inputDate){
        // subtracting 3 weeks and adding 7 days, 1 month, and 2 years
        DateTime updatedDate = inputDate.AddDays(7).AddMonths(1).AddYears(2).AddDays(-21); 
//updated date
        return updatedDate;   
    }

    static void Main(){
        //take teh date input from user
        Console.Write("Enter date (dd-MM-yyyy): "); 
        string input = Console.ReadLine()!;               
        DateTime date = DateTime.ParseExact(input,"dd-MM-yyyy",CultureInfo.InvariantCulture );
        DateTime result = DateOperations(date);
        Console.WriteLine("Final Date After Calculations: " + result.ToString("dd-MM-yyyy"));             //Output as final date
    }
}
