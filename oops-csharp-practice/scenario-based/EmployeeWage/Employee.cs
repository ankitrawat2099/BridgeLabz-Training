namespace EmployeeWage;
using System;

public class Employee
{
  //employee id,name,salary
    private int EmployeeId { get; set; }
    private string EmployeeName { get; set; }
    private double EmployeeSalary { get; set; }

      public Employee(int employeeId,string empName)
    {
        EmployeeId = employeeId;
        EmployeeName=empName;
    }
}




   

