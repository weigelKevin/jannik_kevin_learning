using System.Formats.Tar;

namespace Tiere;

public class Tier
{
    private string Name { get; set; }
    private int Alter { get; set; }

    public Tier(string name, int alter)
    {
        Name = name;
        Alter = alter;
    }

    public virtual void Sound()
    {
        Console.WriteLine("Hallo liebes Tier");
    }
}

public class Katzen:Tier
{
    public string Farbe { get; set; }

    public Katzen(string Name, int Alter, string Farbe) : base( Name, Alter)
    {
        Farbe = Farbe;
    }

    public override void Sound()
    {
        base.Sound();
        Console.WriteLine("Miau");
    }
}

public class Hund : Tier
{
    public string Hundefutter { get; set; }

    public Hund(string name, int alter, string hundefutter) : base(name, alter)
    {
        Hundefutter = hundefutter;
    }

    public override void Sound()
    {
        base.Sound();
        Console.WriteLine("Wuff Wuff");
    }
}