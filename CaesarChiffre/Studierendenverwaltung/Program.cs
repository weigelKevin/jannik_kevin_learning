namespace Studierendenverwaltung;

class Program
{
    static void Main(string[] args)
    
    {
        List<int> notenListe = new List<int>();
        Student std1 = new Student("Hallo","12344","12",notenListe);
        std1.NoteHinzufuegen(2);
        std1.NoteHinzufuegen(4);
        
        double berechen = std1.NoteBerechnen();
        Console.WriteLine(berechen);
        std1.anzeigen();
        
    }
}