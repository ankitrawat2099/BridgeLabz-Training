using System;

// CallLog class
class CallLog
{
    public string PhoneNumber;
    public string Message;
    public DateTime TimeStamp;
    //constructor
    public CallLog(string phone, string message, DateTime time)
    {
        PhoneNumber = phone;
        Message = message;
        TimeStamp = time;
    }
    //method to display call log
    public void Display()
    {
        Console.WriteLine($"Phone: {PhoneNumber}");
        Console.WriteLine($"Message: {Message}");
        Console.WriteLine($"Time: {TimeStamp}");
        Console.WriteLine("----------------------");
    }
}

// Manager class
class CallLogManager
{
    private CallLog[] logs;
    private int count;

    public CallLogManager(int size)
    {
        logs = new CallLog[size];
        count = 0;
    }

    // Add call log
    public void AddCallLog()
    {
        if (count >= logs.Length)
        {
            Console.WriteLine("Log storage full!");
            return;
        }
        //take the phone nubmer as input from user
        Console.Write("Enter Phone Number: ");
        string phone = Console.ReadLine()?? "";
        //take the message as input from user
        Console.Write("Enter Message: ");
        string message = Console.ReadLine()?? "";
        //take the date as input from user
        Console.Write("Enter Date & Time (yyyy-MM-dd HH:mm): ");
        DateTime time = DateTime.Parse(Console.ReadLine()?? "");

        logs[count++] = new CallLog(phone, message, time);
        Console.WriteLine("Call log added successfully.\n");
    }

    // Search by keyword
    public void SearchByKeyword()
    {
        //take the keyword as input from user
        Console.Write("Enter keyword to search: ");
        string keyword = Console.ReadLine()?? "";

        bool found = false;

        for (int i = 0; i < count; i++)
        {
            if (logs[i].Message.Contains(keyword))
            {
                logs[i].Display();
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No logs found with given keyword.\n");
    }

    // Filter by time range
    public void FilterByTime()
    {
        //take the start time as input from user
        Console.Write("Enter Start Time (yyyy-MM-dd HH:mm): ");
        DateTime start = DateTime.Parse(Console.ReadLine()?? "");
        //take the end time as input from user
        Console.Write("Enter End Time (yyyy-MM-dd HH:mm): ");
        DateTime end = DateTime.Parse(Console.ReadLine()?? "");

        bool found = false;

        for (int i = 0; i < count; i++)
        {
            if (logs[i].TimeStamp >= start && logs[i].TimeStamp <= end)
            {
                logs[i].Display();
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No logs found in given time range.\n");
    }
}

class CustomerServiceCallLogManager
{
    static void Main()
    {
        //take the number of call logs as input from user
        Console.Write("Enter maximum number of call logs: ");
        int size = Convert.ToInt32(Console.ReadLine());
        //creating object and passing the size
        CallLogManager manager = new CallLogManager(size);

        while (true)
        {
            Console.WriteLine("\n1. Add Call Log");
            Console.WriteLine("2. Search by Keyword");
            Console.WriteLine("3. Filter by Time Range");
            Console.WriteLine("4. Exit");
            Console.Write("Choose option: ");
            //take the choice of user as input 
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    manager.AddCallLog();
                    break;

                case 2:
                    manager.SearchByKeyword();
                    break;

                case 3:
                    manager.FilterByTime();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
