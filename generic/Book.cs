namespace generic;

public class Book:Product
{
    private static int _id;
    public string AuthorName { get; set; }
    public int PageCount { get; set; }

    public override void Sell()
    {
        if (Count == 0)
        {
            throw new NotFoundExcaption("Bu mehsuldan qalmayib");
        }
        Count--;
        TotalIncome += Price;
        Console.WriteLine("Book sold successfully");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Id:{Id} - Name:{Name} - Author:{AuthorName} - Pages:{PageCount}");
    }

    public Book(string name, decimal price, string authorName, int pageCount) : base(name, price)
    {
        AuthorName = authorName;
        PageCount = pageCount;
        Id = ++_id;
    }
}
