internal class Program
{
    private static void Main(string[] args)
    {
        //Skapa en ny order
        Order myOrder = new Order();

        //Skapa ett en choklad som kostar 100 
        Chocolate choco = new Chocolate();
        choco.Price = 100;

        //Skapa en Filling och lägg den till chokladen
        Filling guldflarn = new() { Price = 50, Type = "Guldflarn" };
        choco.AddFilling(guldflarn);

        //Vi kan också göra så här, skapa objektet direkt i metodanropet, om vi inte behöver en 
        //referens till det som vi har till 'guldflarn'
        choco.AddFilling(new Filling() { Price = 5, Type = "Sågspån" });

        //Lägg chokladen till ordern
        myOrder.AddProduct(choco);

        //Skapa en keps som kostar 500 och lägg till den till ordern
        Cap cap = new Cap();
        cap.Price = 500;
        myOrder.AddProduct(cap);

        //Testa att skriva ut TotalPrice för att testa att den logiken funkar
        Console.WriteLine("Ny order skapad. Totalpris: " + myOrder.TotalPrice);
    }
}