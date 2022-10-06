internal class Cap : Product
{
    //Konstruktorerna i dessa ärvda klasser blir ett krav när en konstruktor som tar en parameter
    //lades till i basklassen. Då måste även Cap få en konstruktor som kallar baskonstruktorn.
    public Cap(float price) : base(price)
    {
    }
}