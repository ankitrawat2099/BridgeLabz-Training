using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{


    class FitTrack
    {
        static void Main()
        {
            //take the user name as input from user
            Console.Write("Enter User Name: ");
            string name = Console.ReadLine() ?? "";
            //pasing the name of the user to the userprofile
            UserProfile user = new UserProfile(name);

            int choice;
            do
            {
                //menu for choosing the choice
                Console.WriteLine("\n---- FitTrack Menu ----");
                Console.WriteLine("1. Cardio Workout");
                Console.WriteLine("2. Strength Workout");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");
                //take the user choice as input
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CardioWorkout cardio = new CardioWorkout();
                        Console.Write("Enter duration in minutes: ");
                        //take duration in minutes from user as input
                        cardio.DurationMinutes = Convert.ToInt32(Console.ReadLine());
                        user.PerformWorkout(cardio);
                        break;

                    case 2:
                        StrengthWorkout strength = new StrengthWorkout();
                        Console.Write("Enter duration in minutes: ");
                        //take duration in minutes from user as input
                        strength.DurationMinutes = Convert.ToInt32(Console.ReadLine());
                        user.PerformWorkout(strength);
                        break;

                    case 3:
                        Console.WriteLine("Exiting FitTrack...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
            while (choice != 3);
        }
    }

}
