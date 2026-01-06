using System;

// Interface for medical record operations
interface IMedicalRecord
{
    void AddRecord(string record);
    void ViewRecords();
}

// Abstract Patient class
abstract class Patient
{
    // Private fields for encapsulation
    private int patientId;
    private string name;
    private int age;

    // Sensitive information
    private string diagnosis;

    // Constructor
    protected Patient(int id, string name, int age)
    {
        patientId = id;
        this.name = name;
        this.age = age;
    }

    // Abstract method
    public abstract double CalculateBill();

    // Common method
    public void DisplayPatientDetails()
    {
        Console.WriteLine("Patient ID : " + patientId);
        Console.WriteLine("Name       : " + name);
        Console.WriteLine("Age        : " + age);
    }

    // Protected setter for diagnosis
    protected void SetDiagnosis(string diag)
    {
        diagnosis = diag;
    }
}

// In-Patient class
class InPatient : Patient, IMedicalRecord
{
    private int daysAdmitted;

    // Array for medical history
    private string[] records = new string[5];
    private int recordCount = 0;

//constructor
    public InPatient(int id, string name, int age, int days)
        : base(id, name, age)
    {
        daysAdmitted = days;
    }

    public override double CalculateBill()
    {
        return daysAdmitted * 2000;
    }

    public void AddRecord(string record)
    {
        if (recordCount < records.Length)
        {
            records[recordCount] = record;
            recordCount++;
        }
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical Records:");
        for (int i = 0; i < recordCount; i++)
        {
            Console.WriteLine("- " + records[i]);
        }
    }
}

// Out-Patient class
class OutPatient : Patient, IMedicalRecord
{
    // Array for medical history
    private string[] records = new string[5];
    private int recordCount = 0;

    public OutPatient(int id, string name, int age)
        : base(id, name, age)
    {
    }

    public override double CalculateBill()
    {
        return 500;
    }
//method to add records
    public void AddRecord(string record)
    {
        if (recordCount < records.Length)
        {
            records[recordCount] = record;
            recordCount++;
        }
    }
//method to view records
    public void ViewRecords()
    {
        Console.WriteLine("Medical Records:");
        for (int i = 0; i < recordCount; i++)
        {
            Console.WriteLine("- " + records[i]);
        }
    }
}

class HospitalPatientManagement
{
    static void Main()
    {
        Console.WriteLine("Select Patient Type");
        Console.WriteLine("1. In-Patient");
        Console.WriteLine("2. Out-Patient");
        Console.Write("Enter choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
//take patient id as input from user
        Console.Write("Enter Patient ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
//take the patient name as input form user
        Console.Write("Enter Name: ");
        string name = Console.ReadLine()?? "";
//take age as input from 
        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Patient patient;

        if (choice == 1)
        {
            Console.Write("Enter number of days admitted: ");
            int days = Convert.ToInt32(Console.ReadLine());
            patient = new InPatient(id, name, age, days);
        }
        else
        {
            patient = new OutPatient(id, name, age);
        }

        // Polymorphism
        Console.WriteLine("\n--- Patient Information ---");
        patient.DisplayPatientDetails();
        Console.WriteLine("Total Bill: " + patient.CalculateBill());

        // Interface usage
        IMedicalRecord medical = (IMedicalRecord)patient;
        medical.AddRecord("Initial checkup completed");
        medical.AddRecord("Medicines prescribed");
        medical.ViewRecords();
    }
}
