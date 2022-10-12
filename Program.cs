internal class Program
{
    private static void Main(string[] args)
    {
        //Skapa en ny order
        Order myOrder = new Order();

        //Skapa ett en choklad som kostar 100 
        Chocolate choco = new Chocolate("Chokladkaka", 100, 75);

        //Skapa en Filling och lägg den till chokladen
        Filling guldflarn = new("Guldflarn", 50);
        choco.AddFilling(guldflarn);

        //Vi kan också göra så här, skapa objektet direkt i metodanropet, om vi inte behöver en 
        //referens till det som vi har till 'guldflarn'
        choco.AddFilling(new Filling("Sågspån", 5));

        //Lägg chokladen till ordern
        myOrder.AddProduct(choco);

        //Skapa en keps som kostar 500 och lägg till den till ordern
        Clothes cap = new Clothes("Keps", 500);
        cap.Size = Size.Medium;
        myOrder.AddProduct(cap);

        //Lägg till en ny donation till ordern
        myOrder.Donation = new Donation(myOrder.TotalPrice, "BY-SUVNET");

        //Bekräfta ordern
        myOrder.Confirm();

        //Testa att skriva ut saker för att testa att den logiken funkar
        Console.WriteLine(GetOrderDetails(myOrder));
    }

    public static string GetOrderDetails(Order order)
    {
        System.Text.StringBuilder returnString = new();
        returnString.Append($"Order nr: {order.OrderNo}. Orderdatum: ");
        if (order.IsConfirmed)
            returnString.AppendLine($"{order.OrderDate}");
        else
            returnString.AppendLine("ORDER OBEKRÄFTAD.");

        foreach (var product in order.Products)
        {
            returnString.AppendLine($"{product.Name}, {product.Category}, {product.Price}:-");
        }
        returnString.AppendLine($"\nTotalpris: {order.TotalPrice}");

        if (order.IsConfirmed)
            returnString.AppendLine($"{order.Donation?.Amount} kr donerat till {order.Donation?.Company}.");

        return returnString.ToString();

    }
}