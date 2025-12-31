using System;
class Person
{
    public string Name;
    public int Age;
//parametised constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
//copy constructor
    public Person(Person p)
    {
        Name = p.Name;
        Age = p.Age;
    }
	static void Main(){
	Person p1=new Person("ankit",21);
	Console.WriteLine(p1.Name+" "+p1.Age);
	Person p2=new Person(p1);
	Console.WriteLine(p2.Name+" "+p2.Age);
	}
}
