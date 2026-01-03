using System;

class Animal
{
    public string Name;
    public int Age;
//constructor to initialize animal details
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }
//method to make sound
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}
//dog class inheriting from animal
class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }
//override make sound method
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}
//cat class inheriting from animal
class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }
//override make sound method
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

class Bird : Animal
{
    public Bird(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Bird chirps");
    }
}

class AnimalHierarchy
{
    static void Main()
    {
        //user inpur for animal type
        Console.WriteLine("Choose Animal: 1-Dog  2-Cat  3-Bird");
        int choice = Convert.ToInt32(Console.ReadLine());
//user input for animal details
        Console.Write("Enter Name: ");
        string name = Console.ReadLine()?? "";
//user input for animal details
        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Animal animal;

        switch (choice)
        {
            case 1: animal = new Dog(name, age);
             break;
            case 2: animal = new Cat(name, age); 
            break;
            case 3: animal = new Bird(name, age); 
            break;
            default:
                Console.WriteLine("Invalid choice");
                return;
        }

        animal.MakeSound(); 
    }
}
