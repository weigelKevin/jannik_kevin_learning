using System.Net;

namespace CaessarChiffre;

public class Check
{
    public void isUpper(string input1)
    {
        if (input1 != input1.ToUpper())
        {
            throw new Exception("only Upper letters"); 
        }
        
    }

    public void isInteger(string input2)
    {
        try
        {
            int rota = int.Parse(input2);

            if (rota>26)
            {
                
                Console.WriteLine("Only 1-25");
                
            }
        }
        
        catch (FormatException e)
        {
            Console.WriteLine("Only integers");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void DoChiffre(string text, int rotation)
    {
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char[] alphabetArray = alphabet.ToCharArray();
        char[] inputArray = text.ToCharArray();

        for (int i = 0; i < inputArray.Length; i++)
        {
            for (int j = 0; j < alphabetArray.Length; j++)
            {
                if (inputArray[i] != alphabetArray[j])
                {
                    continue;
                }
                else
                {
                    inputArray[i] = alphabetArray[j+rotation];
                    Console.WriteLine(inputArray[i]);
                    break;
                }

                
            }
            
        }
       
        
    }
    
}