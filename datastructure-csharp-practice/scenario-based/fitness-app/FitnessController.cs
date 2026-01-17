using System;
namespace FitnessController;

public class FitnessController
{
    private IStepTracker tracker;

    public FitnessController()
    {
        tracker = new StepManager();
    }

    public void StartMenu()
    {
        int choice;

        do
        {
            Console.WriteLine("\n1. Register User");
            Console.WriteLine("2. Modify Step Count");
            Console.WriteLine("3. Display Ranking");
            Console.WriteLine("4. Exit");
            Console.Write("Choose option: ");
            //take the choice from user as input

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter user name: ");
                    string userName = Console.ReadLine();

                    Console.Write("Enter step count: ");
                    int stepCount = int.Parse(Console.ReadLine());

                    tracker.RegisterUser(userName, stepCount);
                    break;

                case 2:
                    Console.Write("Enter user position: ");
                    int pos = int.Parse(Console.ReadLine());

                    Console.Write("Enter updated steps: ");
                    int updatedSteps = int.Parse(Console.ReadLine());

                    tracker.ChangeSteps(pos, updatedSteps);
                    break;

                case 3:
                    tracker.ShowRanking();
                    break;

                case 4:
                    Console.WriteLine("Application closed.");
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

        } while (choice != 4);
    }
}