using System.Threading.Channels;

namespace Programm;

public class Gruesse
{
    public string begruessen()
    {
        return "Please enter an input!";
        
    }

    public void DoCheckInput (string eingabe1)
    {
        if (eingabe1 == null)
        {
            Console.WriteLine("Keine Eingabe vorhanden");
            
        }
        else
        {
            Console.WriteLine("Einagbe vorhanden");
        }
    }

    public void CheckIfPalindrom(string test)
    {
        char[] orginalStringArray = test.ToCharArray();
        Array.Reverse(orginalStringArray);
        string a = new string(orginalStringArray);
        

        if (test == a)
        {
            Console.WriteLine("Passt");
        }
        else
        {
            Console.WriteLine("Passt nicht");
        }
    }

    public void CheckwithanOtherMethode(string test)
    {
        char[] original1 = test.ToCharArray();
        Array.Reverse(original1);
        char[] original2 = test.ToCharArray();

        bool isPalindrome = true;

        for (int i = 0; i < original1.Length; i++)
        {
            if (original1[i] != original2[i])
            {
                isPalindrome = false;
                break; 
            }
        }

        if (isPalindrome)
        {
            Console.WriteLine("Passt");
        }
        else
        {
            Console.WriteLine("Falsch");
        }
    }

}