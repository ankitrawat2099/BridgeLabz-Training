using System;
class LibraryBook
{
    private bool available = true;
    public string Title;
    public string Author;
    public double Price;

    public void BorrowBook()
    {
        if (available)
        {
            available = false;
            Console.WriteLine("Book borrowed successfully.");
        }
        else
        {
            Console.WriteLine("Book not available.");
        }
    }
	
	static void Main(){
	LibraryBook obj=new LibraryBook();
	obj.BorrowBook();
	}
	
}
