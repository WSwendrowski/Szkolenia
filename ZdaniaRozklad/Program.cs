using System;
using System.Globalization;

Console.WriteLine("Wpisz dowolne zdanie:\n");
string sentence = Console.ReadLine();

//string sentence = "Ala ma 3 koty.";

int lenghtSentence = sentence.Length;

RemoveSpecialCharacters();

string[] arraySentence = sentence.Split(' ');

int words = 0;
int itemsInArray = 0;

int result = 0;
int valueOfWord = 0;

words = arraySentence.Length;

string wordForms1 = "";

wordForms1 = WordVariety(wordForms1);

string wordForms2;

WordVariety2();

Console.WriteLine($"\nTwoje zdanie ma {words} {wordForms1} (i {lenghtSentence} {wordForms2}).\n");

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

 void RemoveSpecialCharacters()
{
    sentence = sentence.Replace(",", " ");
    sentence = sentence.Replace(".", "");
    sentence = sentence.Replace("  ", " ");
    sentence = sentence.Replace("!", "");
    sentence = sentence.Replace("?", "");
}

string WordVariety(string wordForms1)
{
    if (words == 1)
    {
        wordForms1 = "wyraz";
    }

    else if ((words >= 2) && (words <= 4))
    {
        wordForms1 = "wyrazy";
    }
    else
    {
        wordForms1 = "wyrazów";
    }
    return wordForms1;
}

void WordVariety2()
{
    if ((lenghtSentence >= 0) && (lenghtSentence == 1))
    {
        wordForms2 = "znak";
    }

    else if ((lenghtSentence >= 2) && (lenghtSentence <= 4))
    {
        wordForms2 = "znaki";
    }
    else
    {
        wordForms2 = "znaków";
    }
}