
namespace RateSpiel;

public class StartGame
{
 
    private bool win = false;

    
    
    public void Try(int numGen)
    {
        
        while (win == false)
        {
            string input1_string = Console.ReadLine();
            int input1 = int.Parse(input1_string);
            if (input1<numGen)
            {
                Console.WriteLine("zu klein");
            }
            else
            {
                if (input1>numGen)
                {
                    Console.WriteLine("zu Groß");
                }
                else
                {
                    if (input1==numGen)
                    {
                        Console.WriteLine("Korrekt");
                    }
                }
            }
        }
    }
}