using System.Threading.Channels;

namespace Salarys;

public class HourlyWageWorker:Worker
{
    private double HoursWorked { get; set; }
    private double ValuePerHour { get; set; }

    public HourlyWageWorker(string name, string abteilung, double hoursWorked, double valuePerHour) : base(name, abteilung)
    {
        HoursWorked = hoursWorked;
        ValuePerHour = valuePerHour;
    }

    public override void calculatedSalary()
    {
        Console.WriteLine(this.HoursWorked*this.ValuePerHour);
    }
}