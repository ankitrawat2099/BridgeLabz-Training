using System;
class StaffMember{
    string staffName;
    int staffId;
    double staffSalary;
//constructor to initilise the name,id and salary
    public StaffMember(string name, int id, double salary){
        staffName = name;
        staffId = id;
        staffSalary = salary;
    }
//method to show detatils
    public void ShowDetails(){
        Console.WriteLine("Employee Name : " + staffName);
        Console.WriteLine("Employee ID   : " + staffId);
        Console.WriteLine("Salary        : " + staffSalary);
    }
}

class Employee{
    static void Main()
    {
		//take the name of employee as input from user
		Console.Write("enter the name of Employee:");
		string name=Console.ReadLine()?? "";
			//take the id of employee as input from user
		Console.Write("enter the id of Employee:");
		int staffId=Convert.ToInt32(Console.ReadLine());
			//take the salary of employee as input from user
		Console.Write("enter the salary of Employee:");
		double staffSalary= Convert.ToDouble(Console.ReadLine());
        StaffMember emp = new StaffMember(name, staffId,staffSalary);
        emp.ShowDetails();
    }
}
