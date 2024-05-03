namespace Gehaelter;

public abstract class Worker
{
    public string Name { get; set; }
    private string Abteilung { get; set; }

    public Worker(string name, string abteilung)
    {
        Name = name;
        Abteilung = abteilung;
    }

    public virtual double CalculateSalary()
    {
        return 1.1D;
    }
}

public class PermanentEmployee:Worker
{
    private double MonatlichesGehalt { get; set; }

    public PermanentEmployee(string name, string abteilung, double monatlichesGehalt) : base(name, abteilung)
    {
        MonatlichesGehalt = monatlichesGehalt;
    }

    public override double CalculateSalary()
    {
        return this.MonatlichesGehalt;
    }
}

public class HourlyWageWorker:Worker
{
    private double Stunden { get; set; }
    private double Stundensatz { get; set; }

    public HourlyWageWorker(string name, string abteilung, double stunden, double stundensatz) : base(name, abteilung)
    {
        Stunden = stunden;
        Stundensatz = stundensatz;
    }

    public override double CalculateSalary()
    {
        return this.Stunden * this.Stundensatz;
    }
}