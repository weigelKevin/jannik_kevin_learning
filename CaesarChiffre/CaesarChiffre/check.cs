namespace CaesarChiffre;

public class check
{
    public void CheckWord(string eingabe)
    {
        if (eingabe==eingabe.ToUpper())
        {
            Console.WriteLine("Richtig");
        }
        else
        {
            Console.WriteLine("Falsch");
        }
        
    }

    public void DatenTypundZahlenraum(int zahl)
    {
        if (zahl is int && zahl >= 1 && zahl <= 25)
        {
            Console.WriteLine("Passt");
        }
        else
        {
            Console.WriteLine("Falsch");
        }
    }

    public void Verschluesseln(string eingabe, int zahlenraum)
    {
        char[] EingabeArray = eingabe.ToCharArray();
        string Alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char[] ArrayAplha = Alpha.ToCharArray();

        for (int i = 0; i < EingabeArray.Length; i++)
        {
            for (int j = 0; j < ArrayAplha.Length; j++)
            {
                if (EingabeArray[i]!=ArrayAplha[j])
                {
                    continue;
                }
                else
                {
                    EingabeArray[i] = ArrayAplha[j + zahlenraum];
                    Console.WriteLine(EingabeArray[i]);
                    break;
                }
            }
        }
    }
}