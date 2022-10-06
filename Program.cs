internal class Program
{
    private static void Main(string[] args)
    {
        //Skapa en ny order
        Order myOrder = new Order();

        //Skapa ett en choklad som kostar 100 
        Chocolate choco = new Chocolate(100, 75);

        //Skapa en Filling och lägg den till chokladen
        Filling guldflarn = new(50) { Type = "Guldflarn" };
        choco.AddFilling(guldflarn);

        //Vi kan också göra så här, skapa objektet direkt i metodanropet, om vi inte behöver en 
        //referens till det som vi har till 'guldflarn'
        choco.AddFilling(new Filling(5) { Type = "Sågspån" });

        //Lägg chokladen till ordern
        myOrder.AddProduct(choco);

        //Skapa en keps som kostar 500 och lägg till den till ordern
        Cap cap = new Cap(500);
        myOrder.AddProduct(cap);

        //Lägg till en ny donation till ordern
        myOrder.Donation = new Donation(myOrder.TotalPrice, "BY-SUVNET");

        //Bekräfta ordern
        myOrder.Confirm();

        if (myOrder.IsConfirmed)
        {
            //Testa att skriva ut saker för att testa att den logiken funkar
            Console.WriteLine($"Order nr {myOrder.OrderNo} skapad {myOrder.OrderDate}");
            Console.WriteLine("Totalpris: " + myOrder.TotalPrice);
            Console.WriteLine($"{myOrder.Donation.Amount} kr donerat till {myOrder.Donation.Company}.");
        }
    }
}