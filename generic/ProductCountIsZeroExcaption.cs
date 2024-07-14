namespace generic;

public class ProductCountIsZeroExcaption : Exception
{
   

    public ProductCountIsZeroExcaption(string message)
        : base(message)
    {
    }
}
