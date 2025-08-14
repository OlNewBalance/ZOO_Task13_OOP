namespace Task12;

public class Bear : Animal
{
    static Random random = new Random();

    public Bear() : base(
        voice: "Ruaaaaaaaaarrr",
        sex: random.Next(2) == 0
    )
    {
    }
}
