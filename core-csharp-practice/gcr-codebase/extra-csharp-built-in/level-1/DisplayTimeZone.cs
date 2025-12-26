using System;
class DisplayTimeZone{
    //method to display current time in time zones
    static void ShowTimeZones()
    {
        DateTimeOffset gmtTime = DateTimeOffset.UtcNow;
        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
//printing the time in differt zones
        Console.WriteLine("GMT Time: " + gmtTime);                                           
        Console.WriteLine("IST Time: " + TimeZoneInfo.ConvertTime(gmtTime, istZone));
        Console.WriteLine("PST Time: " + TimeZoneInfo.ConvertTime(gmtTime, pstZone));
    }
    static void Main(){
        //callsing method
        ShowTimeZones();         
    }
}
