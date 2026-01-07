namespace EmployeeWage;
public class EmployeeUtilityImpl:IEmployee
{
    private Employee employee;
    private Random random = new Random();
    public EmployeeUtilityImpl(Employee employee)
    {
        this.employee = employee;
    }
    //uc1:Check Employee is Present or Absent using random
     public void CheckAttendance()
{
    
    int attendance = random.Next(0, 2);
    Console.WriteLine(attendance == 1? "Employee is Present": "Employee is Absent");
}

}