var a = "dupa";
Console.WriteLine(a);
Pizda(a);
Console.WriteLine(a);    
Chuj(ref a);
Console.WriteLine(a);

void Pizda(string b)
{
    b = "pizda";
    return;
}

void Chuj(ref string c)
{
    c = "chuj";
    return ;
}

