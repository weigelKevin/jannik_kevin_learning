namespace RateSpiel;

class Program
{
    static void Main(string[] args)
    {
        StartGame stg1 = new StartGame();
        Random rndm = new Random();
        
        
        

        stg1.Try(rndm.Next(10));
    }
}