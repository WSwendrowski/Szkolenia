﻿Console.WriteLine("Program do obliczania pól figur dla lamusów by Edek L.");
string figure;
bool repeatPlease = true;
do
{
    Console.WriteLine(
        "\nDostępne figury to:\n\t1. Kwadrat\n\t2. Prostokąt\n\t3. Trójką\n\t4. Koło\n\t5. Koniec programu.");
    Console.WriteLine("\nProszę wpisać numer figury:");
    figure = Console.ReadLine();
    switch (figure)
    {
        case "1":
            Console.WriteLine("\nWybraną figurą jest kwadrat.");
            Console.WriteLine("\n\t Proszę podać długość boku kwadratu [cm]:");
            string sideSquare = Console.ReadLine();
            decimal fieldSquare = decimal.Parse(sideSquare) * decimal.Parse(sideSquare);
            Console.WriteLine($"Pole kwadratu wynosi {fieldSquare} cm2.");
            break;

        case "2":

            Console.WriteLine("\nWybraną figurą jest prostokąt.");
            Console.WriteLine("\n\t Proszę podać długość prostokąta [cm]:");
            string widthRactangle = Console.ReadLine();
            Console.WriteLine("\n\t Proszę podać wysokość prostokąta [cm]:");
            string highRactangle = Console.ReadLine();
            decimal fieldRactangle = decimal.Parse(widthRactangle) * decimal.Parse(highRactangle);
            Console.WriteLine($"Pole prostokąta wynosi {fieldRactangle} cm2.");
            break;

        case "3":

            Console.WriteLine("\nWybraną figurą jest trójkąt.");
            Console.WriteLine("\n\t Proszę podać szerokość podstawy trójkąta [cm]:");
            string baseTriangle = Console.ReadLine();
            Console.WriteLine("\n\t Proszę podać wysokość trójkąta [cm]:");
            string highTriangle = Console.ReadLine();
            decimal fieldTriangle = (decimal.Parse(baseTriangle) * decimal.Parse(highTriangle)) / 2;
            Console.WriteLine($"Pole prostokąta wynosi {fieldTriangle} cm2.");
            break;

        case "4":

            Console.WriteLine("\nWybraną figurą jest koło.");
            Console.WriteLine("\n\t Proszę podać promień koła [cm]:");
            string radiusCircle = Console.ReadLine();
            decimal fieldCircle = (decimal.Parse(radiusCircle) * decimal.Parse(radiusCircle)) * 3.14m;
            Console.WriteLine($"Pole prostokąta wynosi {fieldCircle} cm2.");
            break;


        case "5":
            repeatPlease = false;
            break;
    }

} while (repeatPlease);