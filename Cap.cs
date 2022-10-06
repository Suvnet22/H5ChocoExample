internal class Cap : Product
{
    int _size = 2; //1 = small, 2 = medium, 3 = large

    public int Size
    {
        get { return _size; }
        set
        {
            //Se till så att Size inte kan sättas till något annat än 1,2 eller 3
            if (value >= 1 && value <= 3) _size = value;
        }
    }

    public override float Price
    {
        get
        {
            //Starta med grundpriset på kepsen och modifiera beroende på Size
            float basePrice = base.Price + (_size * 10f);
            return basePrice;
        }
    }

    //Konstruktorerna i dessa ärvda klasser blir ett krav när en konstruktor som tar en parameter
    //lades till i basklassen. Då måste även Cap få en konstruktor som kallar baskonstruktorn.
    public Cap(string type, float price) : base(price, type)
    {
    }
}