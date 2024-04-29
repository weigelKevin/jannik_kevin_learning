using System.Security.Cryptography;

namespace Uebung_2;

public class Student
{
    private string Name { get; set; }
    private string MartikelNummer { get; set; }
    private int Alter { get; set; }
    private double NotenHinzufuegen { get; set; }
    public List<double> Noten { get; set; } 

    public Student(string name, string martikelNummer, int alter, double notenHinzufuegen)
    {
        Name = name;
        MartikelNummer = martikelNummer;
        Alter = alter;
        NotenHinzufuegen = notenHinzufuegen;
        Noten = new List<double>();
    }

    public void hinzufuegen(int noTe)
    {
        Noten.Add(noTe);
        double summe = Noten.Sum();
        Console.WriteLine($"Berechnung: {summe/Noten.Count}");



    }
    public void Anzeigen()
    {
        foreach (var T in Noten)
        {
            
            Console.WriteLine(T);
            
        }
    }

    public void GesamtAusgabe()
    {
        Console.WriteLine(Name, MartikelNummer);
        string noten = string.Join(",", this.Noten);
        Console.WriteLine(noten);
    }

   
}