namespace generic;

public abstract class Product
{

    private static int id;
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Count { get; set; }
    public decimal TotalIncome { get; set; }

    public abstract void Sell();
    public abstract void ShowInfo();


    protected Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }


}
