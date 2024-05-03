using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Tiere;

public abstract class Tier
{
        
    private string Name { get; set; }
    private int Alter { get; set; }
    
    public Tier(string name, int alter)
    {
        Name = name;
        Alter = alter;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Ich bin Abstrakt also mache ich keinen Sound");
    }
}

public class Katze : Tier
{
    private string KatzenfutterMarke { get; set; }

    public Katze(string katzenfutterMarke, string name, int alter) : base(name,alter)
    {
        KatzenfutterMarke = katzenfutterMarke;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Miau Miau");
    }
}

public class Hund : Tier
{
    private string HundefutterMarke { get; set; }

    public Hund(string name, int alter, string hundefutterMarke) : base(name, alter)
    {
        HundefutterMarke = hundefutterMarke;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Wau Wau");
    }
}