namespace Uebung_2;

class Program
{
    static void Main(string[] args)
    {
        Student t1 = new Student("Hal", "2111", 20, 1);
        t1.hinzufuegen(1);
        t1.hinzufuegen(3);
        t1.Anzeigen();
        t1.GesamtAusgabe();
       

    }
}