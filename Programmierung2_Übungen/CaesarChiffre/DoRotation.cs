namespace CaesarChiffre;

public class DoRotation
{
    public void DoRotate(string input1, string input2)
    {
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char[] inputArray = input1.ToCharArray();
        char[] letterArray = alphabet.ToCharArray();

        int num = int.Parse(input2);

        for (int i = 0; i < inputArray.Length; i++)
        {
            for (int j = 0; j < letterArray.Length; j++)
            {
                if (inputArray[i] == letterArray[j])
                {
                    
                    inputArray[i] = letterArray[num + j];
                    Console.WriteLine(inputArray[i]);
                    break;


                }
               
                
            }
            
        }

      
        
    }
}
