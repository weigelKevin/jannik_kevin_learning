namespace NamedParameters;

class Program
{
    public void DoDivision(int zaehler, int nenner, bool ungeraderZaehler, bool ungeraderNenner)
    {
        if (ungeraderNenner == true && ungeraderNenner == true)
        {
            Console.WriteLine("Zaehler und Nenner sind beide ungerade");
        }
        else
        {
            if (ungeraderNenner == true && ungeraderZaehler != true)
            {
                Console.WriteLine("Nur nenner ist ungerade");
            }
            else
            {
                if (ungeraderZaehler == true && ungeraderNenner != true)
                {
                    Console.WriteLine("Nur Zaehler ist ungerade");
                }
                else
                {
                    Console.WriteLine("Alle sind ungerade");
                }
            }
        }

        int divison = zaehler / nenner;
        Console.WriteLine(divison);
    }
    static void Main(string[] args)
    {
        Program p1 = new Program();
        p1.DoDivision(nenner: 2, zaehler:3, ungeraderNenner:false, ungeraderZaehler:true);
    }
}