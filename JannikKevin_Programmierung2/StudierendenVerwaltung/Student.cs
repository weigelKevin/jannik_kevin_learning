namespace StudierendenVerwaltung;

public class Student
{
    private string Name { get; set; }
    private string Matrikelnummer { get; set; }
    private int Alter { get; set; }
    public double[] Noten { get; set; }

    public Student(string name, string matrikelnummer, int alter, params double[] noten)
    {
        Name = name;
        Matrikelnummer = matrikelnummer;
        Alter = alter;
        Noten = noten;
    }

    public void AddMark(double mark,double mark2)
    {
        double[] newMarks = new double[this.Noten.Length + 1];

        for (int i = 0; i < this.Noten.Length; i++)
        {
            newMarks[i] = Noten[i];
        }

        newMarks[this.Noten.Length] = mark;
        this.Noten = newMarks;
        foreach (double arg in this.Noten)
        {
            Console.WriteLine(arg);
        }

    }
    public double CalcAVG(out double summe, params double[] noten)
    {
        summe = 0.0;
        for (int i = 0; i < noten.Length; i++)
        {
            summe += noten[i];
        }

        
        return summe / this.Noten.Length;
    }

    public void PrintStudentProperties()
    {
        double val;
        string noten = string.Join(" ,",this.Noten);
        double avg = CalcAVG(out val, this.Noten);
        Console.WriteLine($"Name: {this.Name}\nMatrikelnummer: {this.Matrikelnummer}\nAlter: {this.Alter}\nNoten: {noten}\nNotendurchschnitt: {avg}");
    }
}