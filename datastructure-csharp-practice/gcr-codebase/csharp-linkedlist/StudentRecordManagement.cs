using System;
//class for studnt node
class StudentNode
{
    public int RollNumber;
    public string Name;
    public int Age;
    public string Grade;

    public StudentNode? Next;

    public StudentNode(int roll, string name, int age, string grade)
    {
        RollNumber = roll;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}

class StudentLinkedList
{
    private StudentNode? head;

    // Add at beginning
    public void AddAtBeginning(StudentNode node)
    {
        node.Next = head;
        head = node;
    }

    // Add at end
    public void AddAtEnd(StudentNode node)
    {
        if (head == null)
        {
            head = node;
            return;
        }

        StudentNode temp = head;
        while (temp.Next != null)
            temp = temp.Next;

        temp.Next = node;
    }

    // Delete by Roll Number
    public void DeleteByRoll(int roll)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        if (head.RollNumber == roll)
        {
            head = head.Next;
            Console.WriteLine("Student deleted.");
            return;
        }

        StudentNode current = head;
        while (current.Next != null && current.Next.RollNumber != roll)
            current = current.Next;

        if (current.Next == null)
            Console.WriteLine("Student not found.");
        else
        {
            current.Next = current.Next.Next;
            Console.WriteLine("Student deleted.");
        }
    }

    // Search student
    public void Search(int roll)
    {
        StudentNode? temp = head;
        while (temp != null)
        {
            if (temp.RollNumber == roll)
            {
                Console.WriteLine($"Found -> {temp.RollNumber}, {temp.Name}, {temp.Age}, {temp.Grade}");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found.");
    }

    // Update grade
    public void UpdateGrade(int roll, string grade)
    {
        StudentNode? temp = head;
        while (temp != null)
        {
            if (temp.RollNumber == roll)
            {
                temp.Grade = grade;
                Console.WriteLine("Grade updated.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found.");
    }

    // Display all records
    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("No records available.");
            return;
        }

        StudentNode? temp = head;
        while (temp != null)
        {
            Console.WriteLine($"{temp.RollNumber} | {temp.Name} | {temp.Age} | {temp.Grade}");
            temp = temp.Next;
        }
    }
}

class StudentRecordManagement
{
    static void Main()
    {

        StudentLinkedList list = new StudentLinkedList();

        int choice;

        do
        {
            Console.WriteLine("\n--- Student Record Management ---");
            Console.WriteLine("1. Add at Beginning");
            Console.WriteLine("2. Add at End");
            Console.WriteLine("3. Delete by Roll No");
            Console.WriteLine("4. Search by Roll No");
            Console.WriteLine("5. Update Grade");
            Console.WriteLine("6. Display All");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");
            //take the choice from user
            choice = int.Parse(Console.ReadLine() ?? "0");

            switch (choice)
            {
                case 1:
                case 2:
                    Console.Write("Roll No: ");
                    int roll = int.Parse(Console.ReadLine() ?? "0");
                    Console.Write("Name: ");
                    string name = Console.ReadLine() ?? "";
                    Console.Write("Age: ");
                    int age = int.Parse(Console.ReadLine() ?? "0");
                    Console.Write("Grade: ");
                    string grade = Console.ReadLine() ?? "";

                    StudentNode node = new StudentNode(roll, name, age, grade);

                    if (choice == 1)
                        list.AddAtBeginning(node);
                    else
                        list.AddAtEnd(node);
                    break;

                case 3:
                    Console.Write("Enter Roll No: ");
                    list.DeleteByRoll(int.Parse(Console.ReadLine() ?? "0"));
                    break;

                case 4:
                    Console.Write("Enter Roll No: ");
                    list.Search(int.Parse(Console.ReadLine() ?? "0"));
                    break;

                case 5:
                    Console.Write("Enter Roll No: ");
                    int r = int.Parse(Console.ReadLine() ?? "0");
                    Console.Write("New Grade: ");
                    list.UpdateGrade(r, Console.ReadLine() ?? "");
                    break;

                case 6:
                    list.Display();
                    break;
            }
        }
        while (choice != 0);
    }
}
