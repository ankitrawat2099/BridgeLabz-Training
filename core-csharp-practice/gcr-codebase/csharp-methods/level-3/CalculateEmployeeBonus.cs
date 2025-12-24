using System;
class CalculateEmployeeBonus{
    //method to generate random salary and years of service
    public static void GenerateEmployeeData(double[,] data){
        Random rand = new Random();
        for(int i = 0;i<data.GetLength(0);i++){
			//salary
            data[i, 0] = rand.Next(10000, 100000);
			//years of experinece
            data[i, 1] = rand.Next(1, 20);    
        }
    }

    //method to calculate bonus and new salary
    public static void CalculateBonus(double[,] data, double[,] result){
        for (int i = 0;i< data.GetLength(0);i++){
            double bonus = data[i, 1] > 5?data[i, 0] * 0.05 : data[i, 0] * 0.02;
			//old salary of employee
            result[i, 0] = data[i, 0];        // old salary
			//bouns
            result[i, 1] = bonus;            
			//new salary
            result[i, 2] = data[i, 0] + bonus;
        }
    }

    //method to display table
    public static void DisplayBonus(double[,] result){
        Console.WriteLine("OldSalary\tBonus\tNewSalary");
        for (int i = 0;i<result.GetLength(0);i++){
		Console.WriteLine($"{result[i, 0]}\t{result[i, 1]}\t{result[i, 2]}");}
    }

    static void Main(){
		//salary and years of experinece
        double[,] data = new double[10, 2]; 
		//employee old salary ,bonus,new salary
        double[,] result = new double[10, 3];
        GenerateEmployeeData(data);
        CalculateBonus(data, result);
        DisplayBonus(result);
    }
}
