class Hund
{
    private CBauchfelll bauchfell;
    private CKopfFell kopfFell;

    private class CKopfFell
    {
        public string? KopfFell {get; }

        public CKopfFell(string? KopfFell)
        {
            this.KopfFell = KopfFell;
        }
    }
     private class CBauchfelll
    {
        public string? BauchFell {get;}
    }

    public Hund(string KopfFell)
    {
        kopfFell = new CKopfFell(KopfFell);
        bauchfell = new CBauchfelll();
    }

    public void showColors()
    {
        System.Console.WriteLine(this.kopfFell);
    }


}

class Program
{
    public static void Main(string[] args)
    {
        Hund h1 = new Hund("braun");
        h1.showColors();
        System.Console.WriteLine("Hi");
    }
}