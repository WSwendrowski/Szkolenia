Console.WriteLine("Program do obliczania pól figur dla lamusów by Edek L.");
Console.WriteLine("\nDostępne fugury to:\n\t1. Kwadrat\n\t2. Prostokąt\n\t3. Trójką\n\t4. Koło");
Console.WriteLine("\nProszę wpisać numer figury:");
string figure = Console.ReadLine();
switch (figure)
{
    case = "1":
            Console.WriteLine("\nWybraną figurą jest kwadrat.");
            Console.WriteLine("\n\t Proszę podać długość boku kwadratu [cm]:");
            string sideSquare = Console.ReadLine();
            int fieldSquare = int.Parse(sideSquare) * int.Parse(sideSquare);
            Console.WriteLine($"Pole kwadratu wynosi {fieldSquare} cm2.");
            break;
      
            case = "2":
    
            Console.WriteLine("\nWybraną figurą jest prostokąt.");
            Console.WriteLine("\n\t Proszę podać długość prostokąta [cm]:");
            string widthRactangle = Console.ReadLine();
            Console.WriteLine("\n\t Proszę podać wysokość prostokąta [cm]:");
            string highRactangle = Console.ReadLine();
            break;
      

            case = "3":
        
            Console.WriteLine("\nWybraną figurą jest trójkąt.");
            Console.WriteLine("\n\t Proszę podać szerokość podstawy trójkąta [cm]:");
            string baseTriangle = Console.ReadLine();
            Console.WriteLine("\n\t Proszę podać wysokość trójkąta [cm]:");
            string highTriangle = Console.ReadLine();
            break;

    default:
            Console.WriteLine("Nie rozpoznano figury.");

}