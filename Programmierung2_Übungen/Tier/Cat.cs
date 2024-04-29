namespace Tier;

public class Cat : Animal
{
    private bool DoesMiau { get; set; }

    public Cat(int legs, string color, bool hasTail, bool doesMiau) : base(legs, color, hasTail)
    {
        DoesMiau = doesMiau;
    }

    public void DoMiau()
    {
        Console.WriteLine("Miau! Miau!");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Miau! Miau!");
    }
}