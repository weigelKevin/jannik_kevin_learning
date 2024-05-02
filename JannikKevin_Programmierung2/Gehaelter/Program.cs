namespace Gehaelter;

class Program
{
    static void Main(string[] args)
    {
        HourlyWageWorker hww1 = new("Hans", "Prod", 160.0D, 16.0D);
        PermanentEmployee pe1 = new("Peter", "CIT", 3500.0D);

        double peterGehalt = pe1.CalculateSalary();
        double hansLohn = hww1.CalculateSalary();

        Console.WriteLine($"{pe1.Name}#s Gehalt beträgt {peterGehalt}EUR\n{hww1.Name}'s Lohn beträgt {hansLohn}EUR");
    }
}