using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.datastructure_csharp_practice.scenario_based
{


    class AtmDispenser
    {
        static void Main()
        {
            Console.Write("Enter amount to withdraw:");
            //take amount as input from user
            int amount = Convert.ToInt32(Console.ReadLine());

            int choice;
            do
            {
                Console.WriteLine("\n--- ATM Menu ---");
                Console.WriteLine("1. All Notes Available");
                Console.WriteLine("2. Remove Rs.500 Note");
                Console.WriteLine("3. Limited Notes (Fallback Scenario)");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");
                //take the choice from user as input
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        //scenario-1: for all notes
                        int[] notesA = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
                        Dispense(amount, notesA);
                        break;

                    case 2:
                        //scenario-2:without 500 note
                        int[] notesB = { 200, 100, 50, 20, 10, 5, 2, 1 };
                        Dispense(amount, notesB);
                        break;

                    case 3:
                        //scenario-3:fallback combo for exact change not available
                        int[] notesC = { 200, 100, 50 };
                        Dispense(amount, notesC);
                        break;

                    case 4:
                        Console.WriteLine("Thank you for using ATM.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
            while (choice != 4);
        }
        //method to dispense amount
        static void Dispense(int amount, int[] notes)
        {
            int remaining = amount;
            int totalNotes = 0;

            Console.WriteLine("\nDispensing Notes:");

            foreach (int note in notes)
            {
                int count = remaining / note;
                if (count > 0)
                {
                    Console.WriteLine("Rs." + note + " x " + count);
                    remaining -= note * count;
                    totalNotes += count;
                }
            }
            //if no amount remains means all notes availbale
            if (remaining == 0)
            {
                Console.WriteLine("Total Notes: " + totalNotes);
            }
            //otherwise not possible
            else
            {
                Console.WriteLine("Exact change not possible");
                Console.WriteLine("Remaining Amount: Rs." + remaining);
                Console.WriteLine("Notes Dispensed: " + totalNotes);
            }
        }
    }




}
