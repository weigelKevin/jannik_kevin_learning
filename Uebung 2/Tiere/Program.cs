namespace Tiere;

class Program
{
    static void Main(string[] args)
    {
        Katzen katz1 = new Katzen("Hans", 12, "Blau");
        katz1.Sound();
        Hund hundi = new("Jojo", 12, "Marmelade");
        hundi.Sound();

    }
}