using System;

class TextState
{
    public string Content;
    public TextState? Prev, Next;
    //constructor
    public TextState(string content)
    {
        Content = content;
    }
}

class UndoRedoManager
{
    private TextState current;

    public UndoRedoManager(string initial)
    {
        current = new TextState(initial);
    }
//method for write
    public void Write(string text)
    {
        TextState newState = new TextState(text);
        newState.Prev = current;
        current.Next = newState;
        current = newState;
    }
    //method for undo
    public void Undo()
    {
        if (current.Prev != null)
            current = current.Prev;
        else
            Console.WriteLine("Nothing to undo");
    }
    //method for redo operation
    public void Redo()
    {
        if (current.Next != null)
            current = current.Next;
        else
            Console.WriteLine("Nothing to redo");
    }
    //method to show
    public void Show()
    {
        Console.WriteLine("Current Text: " + current.Content);
    }
}

class UndoRedo
{
    static void Main()
    {
        UndoRedoManager manager = new UndoRedoManager("Empty");
        int choice;

        do
        {
            Console.WriteLine("\n1.Write  2.Undo  3.Redo  4.Show  0.Exit");
            //take choice from user
            choice = int.Parse(Console.ReadLine() ?? "0");

            if (choice == 1)
            {
                Console.Write("Enter text: ");
                manager.Write(Console.ReadLine()!);
            }
            else if (choice == 2) manager.Undo();
            else if (choice == 3) manager.Redo();
            else if (choice == 4) manager.Show();

        } while (choice != 0);
    }
}
