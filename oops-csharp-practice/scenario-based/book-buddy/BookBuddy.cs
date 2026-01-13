using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.book_buddy
{
    class BookBuddy
    {
        static void Main()
        {
            IBookShelf shelf = new BookShelf();
            int choice;

            do
            {
                Console.WriteLine("\n--- BookBuddy Digital Bookshelf ---");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Sort Books");
                Console.WriteLine("3. Search by Author");
                Console.WriteLine("4. View All Books");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");
                //take the choice from user as input
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter Book Title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter Author Name: ");
                    string author = Console.ReadLine();

                    shelf.AddBook(title, author);
                }
                else if (choice == 2)
                {
                    shelf.SortBooksAlphabetically();
                }
                else if (choice == 3)
                {
                    Console.Write("Enter Author Name: ");
                    string author = Console.ReadLine();

                    shelf.SearchByAuthor(author);
                }
                else if (choice == 4)
                {
                    string[] books = shelf.ExportToArray();
                    if (books.Length == 0)
                    {
                        Console.WriteLine("No books available.");
                    }
                    else
                    {
                        for (int i = 0; i < books.Length; i++)
                        {
                            Console.WriteLine(books[i]);
                        }
                    }
                }

            } while (choice != 5);

            Console.WriteLine("Thank you for using BookBuddy!");
        }
    }


}
