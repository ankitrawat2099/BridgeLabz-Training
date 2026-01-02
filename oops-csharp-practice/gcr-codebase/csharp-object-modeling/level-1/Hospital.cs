using System;

class Patient
{
    public string Name;
    //constructor for Patient
    public Patient(string name){
        Name = name;}
}

class Doctor
{
    public string Name;
    //constructor for Doctor
    public Doctor(string name){
        Name = name;}
//method for doctor to consult a patient
    public void Consult(Patient patient)
    {
        Console.WriteLine($"Doctor {Name} is consulting {patient.Name}");
    }
}

class Hospital
{
    static void Main()
    {
        //take the doctor and patient details as input from user
        Console.Write("Enter doctor name: ");
        Doctor doc = new Doctor(Console.ReadLine()?? "");

        Console.Write("Enter patient name: ");
        Patient pat = new Patient(Console.ReadLine()?? "");

        doc.Consult(pat);
    }
}
