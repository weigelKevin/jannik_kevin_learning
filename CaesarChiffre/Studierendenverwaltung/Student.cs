using System.Threading.Channels;

namespace Studierendenverwaltung;

public class Student
{
    private string Name { get; set; }
    private string MartikelNummer { get; set; }
    private string Alter { get; set; }
    private List<int> Noten { get; set; }

    public Student(string name, string martikelNummer, string alter, List<int> noten)
    {
        Name = name;
        MartikelNummer = martikelNummer;
        Alter = alter;
        Noten = noten;
    }

    public void NoteHinzufuegen(int note)
    {
        if (note<=6 &&note>=1)
        {
           Noten.Add(note);
           foreach (int n in Noten)
           {
               Console.WriteLine(n);
           }
        }
        else
        {
            Console.WriteLine("Einagbe nicht möglich");
        }
    }

    public double NoteBerechnen()
    {
        if (Noten.Count == 0)
        {
            return 0; 
        }

        int summe = 0;
        foreach (int note in Noten)
        {
            summe += note;
        }
        return (double)summe / Noten.Count; 
    }

  

    public void anzeigen()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Matrikelnummer: {MartikelNummer}");
        Console.WriteLine($"Alter: {Alter}");
        Console.WriteLine($"Durchschnittsnote: {NoteBerechnen()}");
        
    }
}

