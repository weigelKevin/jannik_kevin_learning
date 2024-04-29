namespace Salarys;

class Program
{
    static void Main(string[] args)
    {
        PermanentEmployee pe1 = new PermanentEmployee("Kevin", "CIT-XM", 10000.5);
        HourlyWageWorker hww1 = new HourlyWageWorker("Jannik", "Hausmeister", 2, 10);
        pe1.calculatedSalary();
        hww1.calculatedSalary();
    }
}