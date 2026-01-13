using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.book_buddy
{
    
    class BookShelf : IBookShelf
    {
        private string[] books;
        private int count;

        public BookShelf()
        {
            books = new string[2];
            count = 0;
        }
        //method to add book
        public void AddBook(string title, string author)
        {
            if (title == "" || author == "")
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            if (count == books.Length)
            {
                ResizeArray();
            }

            books[count] = title + " - " + author;
            count++;
        }

        private void ResizeArray()
        {
            string[] temp = new string[books.Length * 2];
            for (int i = 0; i < books.Length; i++)
            {
                temp[i] = books[i];
            }
            books = temp;
        }
        //method to sort books
        public void SortBooksAlphabetically()
        {
            if (count == 0)
            {
                Console.WriteLine("Bookshelf is empty.");
                return;
            }

            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (string.Compare(books[i], books[j]) > 0)
                    {
                        string temp = books[i];
                        books[i] = books[j];
                        books[j] = temp;
                    }
                }
            }
        }
        //method to search book
        public void SearchByAuthor(string author)
        {
            if (count == 0)
            {
                Console.WriteLine("Bookshelf is empty.");
                return;
            }

            bool found = false;

            for (int i = 0; i < count; i++)
            {
                string[] parts = books[i].Split('-');
                if (parts.Length == 2)
                {
                    string storedAuthor = parts[1].Trim();
                    if (storedAuthor.Equals(author, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(books[i]);
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No books found for author: " + author);
            }
        }

        public string[] ExportToArray()
        {
            string[] result = new string[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = books[i];
            }
            return result;
        }
    }

}
