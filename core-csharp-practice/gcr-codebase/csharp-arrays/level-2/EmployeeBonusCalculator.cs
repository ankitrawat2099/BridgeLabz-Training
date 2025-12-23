using System;

class EmployeeBonusCalculator
{
    static void Main()
    {
		//arrays for salary,serivce years,bonusAmountand new salary
        double[] salary = new double[10];
        double[] serviceYears = new double[10];
        double[] bonusAmount = new double[10];
        double[] newSalary = new double[10];

        double totalBonus = 0;
		double totalOldSalary = 0;
		double totalNewSalary = 0;

        for (int i = 0; i < 10; i++)
        {
			//taking the employee salary as input from yuser
            Console.Write($"Enter salary of employee: ");
            salary[i] = Convert.ToDouble(Console.ReadLine());
//taking the employee years of serive as input from user
            Console.Write($"Enter years of service of employee: ");
            serviceYears[i] = Convert.ToDouble(Console.ReadLine());
//chekcing for vallid salary number and serive years
            if (salary[i] <= 0 || serviceYears[i] < 0)
            {
                Console.WriteLine("Invalid input");
                i--;
                continue;
            }
        }

        for (int i = 0; i < 10; i++)
        {
            double bonusRate = serviceYears[i] > 5 ? 0.05 : 0.02;
            bonusAmount[i] = salary[i] * bonusRate;
            newSalary[i] = salary[i] + bonusAmount[i];

            totalBonus += bonusAmount[i];
            totalOldSalary += salary[i];
            totalNewSalary += newSalary[i];
        }
//printing the bounus ,oldsalary and the new salary 
        Console.WriteLine($"Total Bonus: {totalBonus}");
        Console.WriteLine($"Total Old Salary:{totalOldSalary}");
        Console.WriteLine($"Total New Salary: {totalNewSalary}");
    }
}
