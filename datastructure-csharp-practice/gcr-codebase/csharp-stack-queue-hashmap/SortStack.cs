using System;
using System.Collections.Generic;

class SortStack
{
    // Method to sort the stack
    static void Sort(Stack<int> stack)
    {
        // Base case: stack is empty
        if (stack.Count == 0)
            return;

        // Remove top element
        int temp = stack.Pop();

        // Sort remaining stack
        Sort(stack);

        // Insert element in sorted order
        InsertSorted(stack, temp);
    }

    // Insert element at correct position
    static void InsertSorted(Stack<int> stack, int value)
    {
        if (stack.Count == 0 || stack.Peek() <= value)
        {
            stack.Push(value);
            return;
        }

        int temp = stack.Pop();
        InsertSorted(stack, value);
        stack.Push(temp);
    }

    static void Main()
    {
        //taking stack input
        Stack<int> stack = new Stack<int>();
        Console.WriteLine("enter the no of element to push:");
         int n=Convert.ToInt32(Console.ReadLine());
         for(int i=0;i<n;i++){
        Console.WriteLine("enter the element to push");
        int element=Convert.ToInt32(Console.ReadLine());
        stack.Push(element);}
        Sort(stack);

        // Print sorted stack
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
    }
}
