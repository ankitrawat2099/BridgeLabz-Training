using System;
namespace FitnessController;

public class StepManager : IStepTracker
{
    private StepRecord[] records;
    private int totalUsers;

    public StepManager()
    {
        records = new StepRecord[20];
        totalUsers = 0;

        // Default users
        records[totalUsers++] = new StepRecord("Ankit", 2500);
        records[totalUsers++] = new StepRecord("Aditya", 9000);
        records[totalUsers++] = new StepRecord("Arjun", 71100);
        records[totalUsers++] = new StepRecord("Abhishek", 10000);
        records[totalUsers++] = new StepRecord("Vikram", 5000);
    }
    //method for registered user
    public void RegisterUser(string username, int steps)
    {
        if (totalUsers >= 20)
        {
            Console.WriteLine("Maximum users reached");
            return;
        }

        records[totalUsers++] = new StepRecord(username, steps);
    }
    //method for change steps
    public void ChangeSteps(int index, int steps)
    {
        if (index < 0 || index >= totalUsers)
        {
            Console.WriteLine("Invalid user position");
            return;
        }

        records[index].UpdateSteps(steps);
    }
    //method for show ranking
    public void ShowRanking()
    {
        SortDescending();

        Console.WriteLine("\n--- Step Leaderboard ---");
        for (int i = 0; i < totalUsers; i++)
        {
            Console.WriteLine((i + 1) + ". " + records[i]);
        }
    }
    //method to sort
    private void SortDescending()
    {
        for (int i = 0; i < totalUsers - 1; i++)
        {
            for (int j = 0; j < totalUsers - i - 1; j++)
            {
                if (records[j].GetStepCount() < records[j + 1].GetStepCount())
                {
                    StepRecord temp = records[j];
                    records[j] = records[j + 1];
                    records[j + 1] = temp;
                }
            }
        }
    }
}