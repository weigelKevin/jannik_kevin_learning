namespace Programmierung2_Übungen;

class Program
{

    
    static void Main(string[] args)
    {
        Console.WriteLine("Geben Sie bitte ein Wort ein, um zu prüfen, ob es sich um ein Palindrom handelt");
        string? input1 = Console.ReadLine();
        checkInputIfNull check1 = new checkInputIfNull();
        check1.CheckIfNull(input1);
        char[] originalStringArray = input1.ToCharArray();
        Array.Reverse(originalStringArray);
        string reversedStringArray = new string(originalStringArray);

        if (input1 == reversedStringArray)
        {
            Console.WriteLine("Palindrom!");
            Console.WriteLine(input1);
            Console.WriteLine(reversedStringArray);
         
        }
        else
        {
            Console.WriteLine("Kein Palindrom");
            Console.WriteLine(input1);
            Console.WriteLine(reversedStringArray);
        }

    }
}