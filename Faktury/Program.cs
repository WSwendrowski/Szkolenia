﻿Console.WriteLine(@"Witaj w programie do  sprzedaży pyrów i cebuli by Eduardo ""StojącaPała"" Leszczo.");
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

 void PrintInvoice()
{
    string document = "FAKTURA";
    string placeOf = "Miejsce wystawienia";
    string city = "Gniezno";
    string headingDate = "Data wystawienia";
    string thisDay = DateTime.Today.ToString();

    Console.WriteLine($"\n\t\t{document}\n");
    var lineFirst = placeOf.PadRight(22);
    lineFirst += city.PadRight(34);
    Console.WriteLine(lineFirst);
    Console.WriteLine("");

    var secodLine = headingDate.PadRight(22); ;
    secodLine += thisDay.PadRight(34);
}


