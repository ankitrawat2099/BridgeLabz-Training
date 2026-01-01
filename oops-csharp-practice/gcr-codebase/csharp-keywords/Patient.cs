using System;

class Patient
{
    public static string HospitalName = "AIIMS";
    private static int totalPatients = 0;

    public string Name;
    public int Age;
    public string Ailment;
    public readonly int PatientID;
//constructor to initialize patient details
    public Patient(string name, int age, string ailment, int id)
    {
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;
        this.PatientID = id;
        totalPatients++;
    }
//static method to display total patients
    public static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients: " + totalPatients);
    }
//method to display patient details
    public void DisplayPatient(object obj)
    {
        if (obj is Patient)
        {
            Console.WriteLine($"Hospital: {HospitalName}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Ailment: {Ailment}");
            Console.WriteLine($"Patient ID: {PatientID}");
        }
    }

    static void Main()
    {
        //take patient details from user
        Console.Write("Enter Patient Name: ");
        string name = Console.ReadLine()?? "";
//take age from user
        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
//take ailment from user
        Console.Write("Enter Ailment: ");
        string ailment = Console.ReadLine()?? "";
//take patient id from user
        Console.Write("Enter Patient ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Patient p = new Patient(name, age, ailment, id);
        p.DisplayPatient(p);
        GetTotalPatients();
    }
}
