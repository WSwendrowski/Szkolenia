using System.IO;


Console.WriteLine(@"Witaj w programie do  sprzedaży pyrów i cebuli by Eduardo ""StojącaPała"" Leszczo.");
const decimal priceOnion = 3.99m;
const decimal pricePotatos = 1.68m;
bool finishShoping = false;
decimal itemPrice;
string itemName;


Console.WriteLine("");
Console.WriteLine("\tChcesz kupić cebulę (1) czy pyry (2)?");
Console.WriteLine("");
Console.WriteLine($"Cena netto cebuli:\t {priceOnion} PLN");
Console.WriteLine($"Cena netto pyrów:\t {pricePotatos} PLN\n");
Console.WriteLine("Przyszłem po:");

string clientChooseofItem;
clientChooseofItem = Console.ReadLine();

Console.WriteLine("\nA ile kg:");

string clientChooseOfQtyString;
clientChooseOfQtyString = Console.ReadLine();
decimal clientChooseOfQty = Convert.ToDecimal(clientChooseOfQtyString);


switch (clientChooseofItem)
{
        case "1":
            itemName = "Cebula";
            itemPrice = priceOnion;
        break;

        case "2":
            itemName = "Pyry";
            itemPrice = pricePotatos;
        break;

        default:
        Console.WriteLine("Chcesz coś czy nie?");
        break;
}

var content = ComposeInvoiceContent();
var amount = AmountOfMoney();

Console.WriteLine(content);
SaveInvoice(content);

string ComposeInvoiceContent(string itemName, decimal itemPrice, decimal amount)
{
    string document = "FAKTURA";
    string placeOf = "Miejsce wystawienia";
    string city = "Gniezno";
    string headingDate = "Data wystawienia";
    string thisDay = DateTime.Today.ToString();
    string itemNamespace = "Nazwa towaru";
    string namePrice = "Cena: ";

    var headerLine = $"\n\t\t{document}\n";
   
    var firstLine = placeOf.PadRight(22);
    firstLine += city.PadRight(34);

    var secondLine = headingDate.PadRight(22); ;
    secondLine += thisDay.PadRight(34);

    var thirdLine = itemNamespace.PadRight(22);
    thirdLine += itemName.PadRight(34);

    var fourthLine = namePrice.PadRight(22);
    fourthLine += itemPrice.ToString().PadRight(34);

    var fifthLine = "Wartość z VATem:".PadRight(22);
    fifthLine += amount.ToString().PadRight(22);

    var content = string.Join("\n", new string[] { headerLine, firstLine, secondLine, thirdLine, fourthLine, fifthLine });
    return content;
}

decimal AmountOfMoney(decimal itemPrice, decimal clientChooseOfQty)
{
    amount = itemPrice * 1.23m * clientChooseOfQty;
    return amount;
}

void SaveInvoice(string content)
{
        File.WriteAllText("faktury.txt", content);
}