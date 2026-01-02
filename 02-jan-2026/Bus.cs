//bus has 20 seats 
//sets availibity
//allow user to reserve sets
//remaining seats
//seats price
//total price

class Bus
{
    static int[] seats = new int[20];
    static int price = 100;
    static int count = 0;
    public static bool IsSeatsAvailiable()
    {
        if (count == 20)
        {
            return false;
        }
        return true;
    }

    public static void ReserveSeat(int idx)
    {
        seats[idx] = 1;
        count++;
    }


    public static int TotalPrice()
    {
        return count * price;
    }
    public static int RemainingSeats()
    {
        return 20 - count;
    }
    static void Main()
    {

        int choice;
        Console.WriteLine("----BUS BOOKING----");
        do
        {
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1 To check seat availiablity");
            Console.WriteLine("2 To reserve seat with index");
            Console.WriteLine("3 To check total");
            Console.WriteLine("4 To check Remaining seats");
            Console.WriteLine("5 To check ticket price");
            Console.WriteLine("0 To exit");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    if (IsSeatsAvailiable())
                    {
                        Console.WriteLine("Yes seats availiable");
                    }
                    else
                    {
                        Console.WriteLine("No seats are availiable");
                    }
                    break;

                case 2:
                    Console.WriteLine("Enter the no. of seats you want to book");
                    int numberOfSets = Convert.ToInt32((Console.ReadLine()));
                    for (int i = 1; i <= numberOfSets; i++)
                    {
                        Console.WriteLine("Enter the index No");
                        int indexNo = Convert.ToInt32((Console.ReadLine()));
                        ReserveSeat(indexNo);
                        Console.WriteLine("Seat reserved with index no: " + indexNo);
                    }
                    Console.WriteLine("Your total price is:" + TotalPrice());
                    break;
                case 3:
                    Console.WriteLine("Total is:" + TotalPrice());
                    break;
                case 4:
                    Console.WriteLine("Remaining seats: " + RemainingSeats());
                    break;
                case 5:
                    Console.WriteLine("Ticket Price: " + price);
                    break;
            }
        }
        while (choice != 0);



    }
}