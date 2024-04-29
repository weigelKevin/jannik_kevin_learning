namespace countVowel;

public class CountVowel
{
    public int count(string input)
    {
        char[] wordArray = input.ToCharArray();
        char[] vowelArray = ['A', 'E', 'I', 'O', 'U'];
        
        int counter=0;

        for (int i = 0; i < wordArray.Length; i++)
        {
            for (int j = 0; j < vowelArray.Length; j++)
            {
                if (char.ToUpper(wordArray[i]) == vowelArray[j])
                {
                    counter++;
                }
            }
        }

        return counter;
    }
}