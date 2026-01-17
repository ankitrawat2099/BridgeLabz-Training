using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Review.BankAccountManager
{
    public class BankAccountMenu
    {
        BankAccountUtilityImpl ac;
        public BankAccountMenu(BankAccount account)
        {
            ac = new BankAccountUtilityImpl(account);
        }
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("1 To CheckBalance:");
            Console.WriteLine("2 To Withdraw:");
            Console.WriteLine("3 To Deposit:");
            Console.WriteLine("4 To Exit:");
            int choice = Convert.ToInt32(Console.ReadLine());
          
                switch (choice)
                {
                    case 1:
                      ac.CheckBalance();
                        break;
                    case 2:
                        Console.WriteLine("enter the amount to withdraw");
                        double a = Convert.ToDouble(Console.ReadLine());
                        ac.WithDraw(a);
                        break;
                    case 3:
                        Console.WriteLine("enter the amount to deposit");
                        double am = Convert.ToDouble(Console.ReadLine());
                        ac.Deposit(am);
                        break;
                    case 4:
                        Console.WriteLine("thank you!");
                        return;
                    default:
                        Console.WriteLine("please enter valid choice");
                        break;
                }
            }
        }
    }
}
