namespace Gehälter;

public class Worker
{
    string Name { get; set; }
    private string Abteilung { get; set; }

    public Worker(string name, string abteilung)
    {
        Name = name;
        Abteilung = abteilung;
    }

    public virtual void calculateSalery()
    {
    
        Console.WriteLine("Das Gehalt beträgt");
    
    }
}

public class paymetEmployee:Worker
{
    private int monGehalt { get; set; }

    public paymetEmployee(string name, string abteilung, int monGehalt) : base(name, abteilung)
    {
        this.monGehalt = monGehalt;
    }

   
}

public class hourlyWorker : Worker
{
   public int Stunden { get; set; } 
   public int Lohnsatz { get; set; }

   public hourlyWorker(string name, string abteilung, int stunden, int lohnsatz) : base(name, abteilung)
   {
       Stunden = stunden;
       Lohnsatz = lohnsatz;
   }

   public override void calculateSalery()
   {
       
       int betrag = this.Stunden * this.Lohnsatz;
       Console.WriteLine(betrag);
   }
}

