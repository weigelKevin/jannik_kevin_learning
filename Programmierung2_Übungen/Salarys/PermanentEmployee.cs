namespace Salarys;

public class PermanentEmployee:Worker
{
    
    private double salary { get; set; }
    public PermanentEmployee(string name, string abteilung, double salary) : base(name, abteilung)
    {
        this.salary = salary;
    }

    public override void calculatedSalary()
    {
        Console.WriteLine(this.salary);
    }
}