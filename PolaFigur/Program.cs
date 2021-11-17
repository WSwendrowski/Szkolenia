Random random = new Random();
int damagesOrc;
int damagesHero;
int round = 0;
int orcLive = 10;
int heroLive = 10;

do
{
    round += 1;
    damagesOrc = random.Next(1, 11);
    orcLive -= damagesOrc;
    if (orcLive < 0)
    {
        orcLive = 0;
    }
    Console.WriteLine($"Round {round}.");
    Console.WriteLine($"Monster was damaged and lost {damagesOrc} health and now has {orcLive} health.");

    if (orcLive == 0) continue;
    
        damagesHero = random.Next(1, 11);
        heroLive -= damagesHero;
        if (heroLive < 0)
        { 
            heroLive = 0;
        }
    Console.WriteLine($"Hero was damaged and lost {damagesHero} health and now has {heroLive} health.");

} while (orcLive > 0 && heroLive > 0);

if (orcLive > heroLive)
{
    Console.WriteLine("Orc win!");
}
else
{
    Console.WriteLine("Hero win!");
}