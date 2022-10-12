internal class Cap : Product
{
    public CapSize Size { get; set; }

    public override float Price
    {
        get
        {
            //Starta med grundpriset på kepsen och modifiera beroende på Size
            float basePrice = base.Price + ((int)Size * 10f);
            return basePrice;
        }
    }

    //Konstruktorerna i dessa ärvda klasser blir ett krav när en konstruktor som tar en parameter
    //lades till i basklassen. Då måste även Cap få en konstruktor som kallar baskonstruktorn.
    public Cap(string type, float price) : base(price, type)
    {
        Category = Category.Clothing;
    }
}

public enum CapSize
{
    Undefined,
    Small,
    Medium,
    Large,
    XLarge,
    XXLarge
}