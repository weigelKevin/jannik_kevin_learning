namespace _2_Caesar;


class Caesar : ICheck,IDoGreet
{
    public void isUpper(string word)
    {
        try
        {
            if (word == word.ToUpper())
            {

            }
            else
            {
                throw new Exception();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Bitte nur uppercase letters");
        }
    }

    public void isInRotationRange(int rotation)
    {
        try
        {
            if (rotation > 25)
            {
                throw new Exception();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Bitte nur Zahlen von 1-25 eingeben");
        }
    }

    public void HelloUser(out string word, out int rotation)
    {
        Console.WriteLine("Hallo User bitte gebe ein Wort ein (nur uppercase letters)");
        word = Console.ReadLine();
        Console.WriteLine("Bitte gebe eine Rotation von 1-25 ein");
        rotation = int.Parse(Console.ReadLine());
    }

    public void DoChiffre(string word, int rotation)
    {
        string letters = "ABCDEFGHIJKLMNOPQRSTUVXYZABCDEFGHIJKLMNOPQRSTUVXYZ";
        char[] letterArray = letters.ToCharArray();
        char[] wordArray = word.ToCharArray();

        for (int i = 0; i < wordArray.Length; i++)
        {
            for (int j = 0; j < letterArray.Length; j++)
            {
                if (wordArray[i] == letterArray[j])
                {
                    wordArray[i] = letterArray[j+rotation];
                    break;
                }
                else
                {
                    continue; 
                }
            }
            Console.WriteLine(wordArray);
        }

        
        

    }

  
}