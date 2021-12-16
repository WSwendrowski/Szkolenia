using System.IO;


Console.WriteLine(@"Witaj w programie do  sprzedaży pyrów i cebuli by Eduardo ""StojącaPała"" Leszczo.");
const decimal priceOnion = 3.99m;
const decimal pricePotatos = 1.68m;


Console.WriteLine("");
Console.WriteLine("\tChcesz kupić cebulę (1) czy pyry (2)?");
Console.WriteLine("");
Console.WriteLine($"Cena netto cebuli:\t {priceOnion} PLN");
Console.WriteLine($"Cena netto pyrów:\t {pricePotatos} PLN\n");
Console.WriteLine("Przyszłem po:");

string clientChooseofItem;
clientChooseofItem = Console.ReadLine();

Console.WriteLine("\nA ile kg:");

string clientChooseOfQty;
clientChooseOfQty = Console.ReadLine();

decimal itemPrice = clientChooseofItem == "1" ? priceOnion : pricePotatos;

PrintInvoice();

 void PrintInvoice()
{
    string document = "FAKTURA";
    string placeOf = "Miejsce wystawienia";
    string city = "Gniezno";
    string headingDate = "Data wystawienia";
    string thisDay = DateTime.Today.ToString();
    string itemName = "Nazwa towaru";
    string namePrice = "Cena: ";

    Console.WriteLine($"\n\t\t{document}\n");
    var firstLine = placeOf.PadRight(22);
    firstLine += city.PadRight(34);
    Console.WriteLine(firstLine);
    Console.WriteLine("");

    var secondLine = headingDate.PadRight(22); ;
    secondLine += thisDay.PadRight(34);
    Console.WriteLine(secondLine);
    Console.WriteLine("");

    var thirdLine = itemName.PadRight(22);
    thirdLine += clientChooseofItem.PadRight(34);
    Console.WriteLine(thirdLine);
    Console.WriteLine("");

    var forthLine = namePrice.PadRight(22);
    forthLine += itemPrice.ToString().PadRight(34);
    Console.WriteLine(forthLine);
    Console.WriteLine("");

    //File.WriteAllText("faktury.txt", document );
}


