using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.book_buddy
{
    interface IBookShelf
    {
        void AddBook(string title, string author);
        void SortBooksAlphabetically();
        void SearchByAuthor(string author);
        string[] ExportToArray();
    }

}
