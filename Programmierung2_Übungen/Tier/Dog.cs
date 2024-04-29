namespace Tier;

public class Dog:Animal
{
    private bool DoesBark { get; set; }
    
    public Dog(int legs, string color, bool hasTail, bool doesBark) : base(legs, color, hasTail)
    {
        DoesBark = doesBark;
    }

    public void Bark()
    {
        Console.WriteLine("Bark! Bark!");
    }
    public override void MakeSound()
    {
        Console.WriteLine("Bark! Bark!");
    }
}