namespace CaessarChiffre;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello User");
        Console.WriteLine("Which text should be crypted only uppercase letters please");
        string text = Console.ReadLine();
        Check c1 = new Check();
        c1.isUpper(text);
        Console.WriteLine("Now enter how many rotations you want");
        string rotationString = Console.ReadLine();
        int rotation = int.Parse(rotationString);
        c1.isInteger(rotationString);
        c1.DoChiffre(text, rotation);

    }
}