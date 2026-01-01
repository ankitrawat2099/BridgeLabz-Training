//SUMMARY
// We are building a simple cafeteria menu system using arrays and methods.
// A string[] array is used to store the fixed list of menu items.
// The menu is displayed with index numbers, allowing users to select items easily.
// Methods like DisplayMenu() and GetItemByIndex() are used to organize the code and fetch user-selected items, making the program clear and reusable.


using System;

class CafeteriaMenuApp
{
    //method to display menu with prices
    static void DisplayMenu(string[] items, int[] prices)
    {
        Console.WriteLine("\n---- Menu ----");
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(i + " : " + items[i] + " - ₹" + prices[i]);
        }
    }

    //method to order items
    static void OrderItems(string[] items, int[] counts)
    {
        Console.Write("Enter item number to order (-1 to stop): ");
        int itemIndex = Convert.ToInt32(Console.ReadLine());

        while (itemIndex != -1)
        {
            counts[itemIndex]++;
            Console.WriteLine(items[itemIndex] + " added!");

            Console.Write("Enter item number to order (-1 to stop): ");
            itemIndex = Convert.ToInt32(Console.ReadLine());
        }
    }

    //method to display final bill
    static void DisplayFinalBill(string[] items, int[] prices, int[] counts)
    {
        Console.WriteLine("\n---- Final Bill ----");
        int total = 0;
        bool hasOrder = false;

        for (int i = 0; i < items.Length; i++)
        {
            if (counts[i] > 0)
            {
                int itemTotal = counts[i] * prices[i];
                Console.WriteLine(items[i] + " x " + counts[i] + " = ₹" + itemTotal);
                total += itemTotal;
                hasOrder = true;
            }
        }

        if (!hasOrder)
        {
            Console.WriteLine("No items ordered.");
        }
        else
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Total Amount: ₹" + total);
        }
    }


    static void Main()
    {
        //cafeteria items
        string[] menuItems =
        {
            "Idli",
            "Dosa",
            "Vada",
            "Poha",
            "Sandwich",
            "Burger",
            "Pizza",
            "Pasta",
            "Tea",
            "Coffee"
        };

        //prices of items
        int[] prices = { 30, 60, 25, 35, 50, 80, 120, 100, 15, 20 };

        //count of ordered items
        int[] itemCount = new int[menuItems.Length];

        while (true)
        {
            //main menu options
            Console.WriteLine("\n---- Cafeteria App ----");
            Console.WriteLine("1. Show Menu Items");
            Console.WriteLine("2. Order Items(with index)");
            Console.WriteLine("3. Exit & Show Bill");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                DisplayMenu(menuItems, prices);
            }
            else if (choice == 2)
            {
                OrderItems(menuItems, itemCount);
            }
            else if (choice == 3)
            {
                DisplayFinalBill(menuItems, prices, itemCount);
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        }
    }

}