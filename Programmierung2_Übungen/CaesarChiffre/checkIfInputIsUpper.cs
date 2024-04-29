using System.Reflection.Metadata.Ecma335;

namespace CaesarChiffre;

public class checkIf
{
    public void isUpper(string input)
    {
        char[] inputArray = input.ToCharArray();
        int len = inputArray.Length;

        for (int i = 0; i <= len-1; i++)
        {
            if (inputArray[i] != char.ToUpper(inputArray[i]))
            {
                Console.WriteLine("Nur Großbuchstaben");
                throw new Exception("Nur Großbuchstaben verwenden");
            }
            else
            {
                Console.WriteLine("Passt");
            }
        }
        
    }

    public void checkRotationAmount(string input2)
    {
        try
        {
            bool success = int.TryParse(input2, out int number);

            if (success)
            {
                Console.WriteLine($"Konvertierung erfolgreich Nummer ist: {number}");
                if (number > 25)
                {
                    Console.WriteLine("Nur Zahlen von 1-25 eingeben");
                }
            }
            else
            {
                Console.WriteLine("Konvertierung fehlerhaft");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }
}