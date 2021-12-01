public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }

    public int GetAge()
    {
        var age = DateTime.Now.Year - DateOfBirth.Year;
        return age;
    }

    public bool IsFuckable()
    {
        return GetAge() > 15;
    }

    public string GiveFuckSound()
    {
        return "Oh Yeah!!!";
    }
}