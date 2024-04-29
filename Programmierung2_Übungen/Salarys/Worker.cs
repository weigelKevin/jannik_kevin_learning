namespace Salarys;

public abstract class Worker
{
    private string Name { get; set; }
    private string Abteilung { get; set; }

    public Worker(string name, string abteilung)
    {
        Name = name;
        Abteilung = abteilung;
    }


    public virtual void calculatedSalary()
    {
       
    }
}