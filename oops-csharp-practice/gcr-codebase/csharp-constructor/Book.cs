class Book
{
    public string Title;
    public string Author;
    public double Price;
//default constructor
    public Book()
    {
        Title = "c++";
        Author = "Unknown";
        Price = 199.00;
    }

    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }
	
	static void Main(){
	Book book=new Book();
	Console.WriteLine(book.Title);
	Console.WriteLine(book.Author);
	Console.WriteLine(book.Price);
	Book book2=new Book("dsa","ankit",199.99);
	Console.WriteLine("parametrised constructor");
	Console.WriteLine(book2.Title);
	Console.WriteLine(book2.Author);
	Console.WriteLine(book2.Price);
	}
}
