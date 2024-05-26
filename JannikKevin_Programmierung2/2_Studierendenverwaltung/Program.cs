namespace _2_Studierendenverwaltung;

class Program
{
    static void Main(string[] args)
    {
        Student st1 = new Student("Kevin", "aweurio3", 22, 1, 2, 1, 1, 1, 1);
        st1.AddNote(5);
        Console.WriteLine(st1.CalcAVG());
        st1.PrintAll();
    }
}