namespace Task12;

public class Tiger : Animal
{
    static Random random = new Random();

    public Tiger() : base(
        voice: "Ruaaaaaaaaarrr x2",
        sex: random.Next(2) == 0
    )
    {
    }
}
