using System;
class Calendar
{
    //metho to get month name
    public static string GetMonthName(int month)
    {
        string[] months ={ "January", "February", "March", "April", "May", "June","July", "August", "September", "October", "November", "December" };
        return months[month - 1];
    }

    //method to year is leap year or not
    public static bool IsLeapYear(int year){
        return (year%4==0 && year%100!=0) || year%400==0;
    }

    //method to get number of days in month
    public static int GetDaysInMonth(int month, int year){
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if(month == 2 && IsLeapYear(year)){
		return 29;}
        return days[month - 1];
    }

    //method to get first day of month
    public static int GetFirstDayOfMonth(int month,int year)
    {
        int y = year;
        int m = month;
        int d = 1;
        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        return (d + x + 31 * m0 / 12) % 7;
    }

    //method to display calendar
    public static void DisplayCalendar(int month, int year){
        Console.WriteLine("\n   " + GetMonthName(month) + " " + year);
        Console.WriteLine("Su Mo Tu We Th Fr Sa");

        int firstDay = GetFirstDayOfMonth(month, year);
        int days = GetDaysInMonth(month, year);

        for (int i = 0;i<firstDay;i++){
		Console.Write("   ");}
        for (int i = 1; i <= days; i++){
            Console.Write(i.ToString().PadLeft(2) + " ");
            if((i + firstDay) % 7 == 0){
			Console.WriteLine();}
        }
        Console.WriteLine();
    }

    static void Main(){
		//take the month as input from  user
        Console.Write("Enter month (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter year: ");
        int year =Convert.ToInt32(Console.ReadLine());
        DisplayCalendar(month,year);
    }
}
