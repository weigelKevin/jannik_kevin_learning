namespace Programm;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Gruesse C1 = new Gruesse();
        Console.WriteLine(C1.begruessen());
        string eingabe = Console.ReadLine();
        C1.DoCheckInput(eingabe);
        C1.CheckwithanOtherMethode(eingabe);
        

    }
}