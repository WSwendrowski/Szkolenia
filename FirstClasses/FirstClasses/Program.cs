using Dancing;

Console.WriteLine("Cześć mała! Podaj mi datę urodzenia a wrzucę Cię w algorytm:");
var dateOfBirth = Console.ReadLine();

Person meat = new Person();
meat.DateOfBirth = DateTime.Parse(dateOfBirth);
Person predator = new Person();
predator.DateOfBirth = DateTime.Now;

if (meat.IsFuckable())
{
   Console.WriteLine(meat.GiveFuckSound());
   Tango.Go(predator, meat);
}