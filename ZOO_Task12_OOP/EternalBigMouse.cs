namespace Task12;

public class EternalBigMouse : Animal
{
    static Random random = new Random();

    public EternalBigMouse() : base(
        voice: "PIPIPIPIPIPIPIPIPIPIPIPIPIPIPIPIPIPIPI",
        sex: random.Next(2) == 0
    )
    {
    }
}
