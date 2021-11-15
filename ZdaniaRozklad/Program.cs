using System;
using System.Globalization;

Console.WriteLine("Wpisz dowolne zdanie:\n");
string sentence = Console.ReadLine();

//string sentence = "Ala ma 3 koty.";

int lenghtSentence = sentence.Length;

sentence = sentence.Replace(",", " ");
sentence = sentence.Replace(".", "");
sentence = sentence.Replace("  ", " ");
sentence = sentence.Replace("!", "");
sentence = sentence.Replace("?", "");

string[] arraySentence = sentence.Split(' ');

int words = 0;
int itemsInArray = 0;

int result = 0;
int valueOfWord = 0;


//foreach (string word in arraySentence)
//{
//    words += 1;
//}

words = arraySentence.Length;

//id1 - odmiana słowa "wyraz"

string id1;
if (words == 1)
{
    id1 = "wyraz";
}

else if ((words >= 2) && (words <= 4))
{
    id1 = "wyrazy";
}
else
{
    id1 = "wyrazów";
}

//id2 - odmiana słowa "znak"

string id2;
if ((lenghtSentence >= 0) && (lenghtSentence == 1))
{
    id2 = "znak";
}

else if ((lenghtSentence >= 2) && (lenghtSentence <= 4))
{
    id2 = "znaki";
}
else
{
    id2 = "znaków";
}


Console.WriteLine($"\nTwoje zdanie ma {words} {id1} (i {lenghtSentence} {id2}).\n");

foreach (string part in arraySentence)
{
    int d = part.Length;
    itemsInArray += 1;

    Console.WriteLine($"\tWyraz nr {itemsInArray} ma liter: \t{d}");
}

foreach (string value in arraySentence)
{
    if (int.TryParse(value, out result))
        valueOfWord += result;
}

if (valueOfWord >= 1)
{
    Console.WriteLine("");
    Console.WriteLine($"Wartość użytych liczb równa się: {valueOfWord}.");
}
