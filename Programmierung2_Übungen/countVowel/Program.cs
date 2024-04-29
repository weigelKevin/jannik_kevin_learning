namespace countVowel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to start vowel count");
        string? word = Console.ReadLine();
        CountVowel cv = new CountVowel();
        
        Console.WriteLine(cv.count(word));
    }
}