namespace _2_Studierendenverwaltung;

public class Student
{
    public string Name { get; set; }
    public string Matrikelnummer { get; set; }
    public int Alter { get; set; }
    public double[] Noten { get; set; }

    public Student(string name, string matrikelnummer, int alter, params double[] noten)
    {
        Name = name;
        Matrikelnummer = matrikelnummer;
        Alter = alter;
        Noten = noten;
    }

    public void AddNote(double note)
    {
        int len = Noten.Length;
        double[] newNotenArray = new double[len + 1];
        for (int i = 0; i < len; i++)
        {
            newNotenArray[i] = Noten[i];
        }

        newNotenArray[Noten.Length] = note;
        Noten = newNotenArray;
        
        
    }

    public double CalcAVG()
    {
        double summe = 0;
        for (int i = 0; i < Noten.Length; i++)
        {
            summe = summe + Noten[i];
        }

        summe = summe / Noten.Length;
        return summe;
    }

    public void PrintAll()
    {
        string str = string.Join(" ,", Noten);
        Console.WriteLine($"Name: {Name}\nMatrikelnummer: {Matrikelnummer}\nAlter: {Alter}\nNoten: {str}");
    }
    
}