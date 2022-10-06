public abstract class Product
{
    //gjorde set till private så att grundpriset bara kan sättas i konstruktorn här
    public virtual float Price { get; private set; }

    public Product(float price)
    {
        Price = price;
    }
}