namespace CaesarChiffre;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello USer");
        Console.WriteLine("Please give me a Text");

        check Testen = new check();
        Testen.CheckWord("HALLO");
        Testen.DatenTypundZahlenraum(12);
        Testen.Verschluesseln("HALLO",1);


    }
}