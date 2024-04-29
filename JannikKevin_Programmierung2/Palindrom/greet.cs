namespace Palindrom;

public class greet
{
    public string DoGreet()
    {
        return "Hello User please enter a word for palindrome test";
    }

    public void DoCheckInput(string input1)
    {
        if (string.IsNullOrEmpty(input1))
        {
            Console.WriteLine("Nichts eingegeben");
            throw new Exception();
        }

        if (string.IsNullOrWhiteSpace(input1))
        {
            Console.WriteLine("Nichts eingegeben");
            throw new Exception();
        }
    }

    public void CheckIfPalindrom(string input1)
    {
        char[] originalStringArray = input1.ToCharArray();
        Array.Reverse(originalStringArray);
        char[] reversedStringArray = originalStringArray;
        string? revString = new string(reversedStringArray);

        if (input1 == revString)
        {
            Console.WriteLine("Passt");
            Console.WriteLine(revString);
        }
        else
        {
            Console.WriteLine("Passt nicht");
        }
    }

    public void CheckIfPalindromV2(string input1)
    {
        char[] orgStrArr1 = input1.ToCharArray();
        char[] orgStrArr2 = input1.ToCharArray();
        bool checker = true;
        Array.Reverse(orgStrArr2);

        while (checker==true)
        {
            for (int i = 0; i < orgStrArr1.Length; i++)
            {
                if (orgStrArr1[i] == orgStrArr2[i])
                {
                    checker = true;
                    
                }
                else
                {
                    checker = false;
                    break;
                }

                
            }
            if (checker == false)
            {
                Console.WriteLine("Kein Palindrom");
            }
            else
            {
                Console.WriteLine("Ist Palindrom");
                checker = false;
            }
        }
        
        
        
    }
}