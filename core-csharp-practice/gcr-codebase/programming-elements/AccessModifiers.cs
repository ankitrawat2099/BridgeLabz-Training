using System;
//parent class
class Parent
{
    public int publicNum = 1;
    private int privateNum = 2;
    protected int protectedNum = 3;
    internal int internalNum = 4;
    protected internal int protectedInternalNum = 5;
    private protected int privateProtectedNum = 6;

    public void ShowPrivateNum()
    {
        Console.WriteLine(privateNum);
    }
}
//child class inherit parent class
class Child : Parent
{
   
    public void DisplayFromChild()
    {
        Console.WriteLine(protectedNum);
        Console.WriteLine(protectedInternalNum);
        Console.WriteLine(privateProtectedNum);
    }
}

class AccessModifiers
{
    static void Main(String[] args)
    {
		//creating object of parent class
        Parent parentObj = new Parent();
		//creating object of child class
        Child childObj = new Child();

        Console.WriteLine(parentObj.publicNum);
        Console.WriteLine(parentObj.internalNum);

        Console.WriteLine(parentObj.protectedInternalNum);
        parentObj.ShowPrivateNum();

       
        childObj.DisplayFromChild();
    }
}