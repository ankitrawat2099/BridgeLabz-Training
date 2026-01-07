using System;

class FriendNode
{
    public int Id;
    public string Name;
    public FriendNode? Next;
//constructor
    public FriendNode(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

class FriendList
{
    private FriendNode? head;
    //method to add friend
    public void AddFriend(int id, string name)
    {
        FriendNode node = new FriendNode(id, name);
        node.Next = head;
        head = node;
    }
    //method to remove freind
    public void RemoveFriend(int id)
    {
        if (head == null) return;

        if (head.Id == id)
        {
            head = head.Next;
            Console.WriteLine("Friend removed");
            return;
        }

        FriendNode temp = head;
        while (temp.Next != null && temp.Next.Id != id)
            temp = temp.Next;

        if (temp.Next != null)
        {
            temp.Next = temp.Next.Next;
            Console.WriteLine("Friend removed");
        }
        else
            Console.WriteLine("Friend not found");
    }

    public void DisplayFriends()
    {
        if (head == null)
        {
            Console.WriteLine("No friends");
            return;
        }

        FriendNode temp = head;
        while (temp != null)
        {
            Console.WriteLine($"{temp.Id} - {temp.Name}");
            temp = temp.Next;
        }
    }
}

class SocialMediaFriendConnection
{
    static void Main()
    {
        FriendList list = new FriendList();
        int choice;

        do
        {
            Console.WriteLine("\n1.Add Friend  2.Remove Friend  3.Display  0.Exit");
            //take the choice form user
            choice = int.Parse(Console.ReadLine() ?? "0");

            if (choice == 1)
            {
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine()!);
                Console.Write("Name: ");
                string name = Console.ReadLine()!;
                list.AddFriend(id, name);
            }
            else if (choice == 2)
            {
                Console.Write("Enter ID: ");
                list.RemoveFriend(int.Parse(Console.ReadLine()!));
            }
            else if (choice == 3)
                list.DisplayFriends();

        } while (choice != 0);
    }
}
