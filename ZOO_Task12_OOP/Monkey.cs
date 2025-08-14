namespace Task12;

public class Monkey : Animal
{
    static Random random = new Random();

    public Monkey() : base(
        voice: "AGUGUGUGUUGUAKAKKAKAKAKKAKAKhhhhhh",
        sex: random.Next(2) == 0
    )
    {
    }
}
