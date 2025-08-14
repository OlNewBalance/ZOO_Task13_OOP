namespace Task12;

public class Animal
{
    public string Voice;
    public bool Sex;
    public string SexDisplay => Sex ? "Самец" : "Самка";
    private static readonly Random _random = new Random();

    public Animal(string voice, bool sex)
    {
        Voice = voice;
        Sex = sex;
    }
}
