namespace Tier;

public abstract class Animal
{
    private int Legs { get; set; }
    private string Color { get; set; }
    private bool HasTail { get; set; }

    public Animal(int legs, string color, bool hastail)
    {
        Legs = legs;
        Color = color;
        HasTail = hastail;
    }

    public virtual void MakeSound()
    {
        
    }
    
    
    
}