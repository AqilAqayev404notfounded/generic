namespace generic;

internal class Library
{
    public int BookLimit { get; set; }
    List<Book> Books;
    public Library(int bookLimit)
    {
        BookLimit = bookLimit;
        Books = new List<Book>();
    }
    public void AddBook(Book book)
    {
        if (book.Count >= BookLimit)
        {
            throw new CapacityLimitExcaption("limit dolub");
        }
        book.Count++;
        Books.Add(book);
    }
    public void GetBookById(int id)
    {
        foreach (Book book in Books)
        {
            if (book.Id == id)
            {
                book.ShowInfo();
                return;
            }
        }
        throw new NotFoundExcaption("book not found");
    }
    public List<Book> GetAllBooks()
    {
        return Books;
    }
    public void RemoveById(int id)
    {
        foreach (var book in Books)
        {
            if (book.Id == id)
            {
                Books.Remove(book);
                Console.WriteLine("Book removed succesfully");
                return;
            }
        }
        throw new NotFoundExcaption("Kitab tapilmadi");
    }
}
