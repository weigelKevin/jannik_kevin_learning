using System;
class MyClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Geben Sie einen String ein: ");
        string eingabe_lesen = Console.ReadLine();
        string wort = eingabe_lesen.ToLower();

        if (wort == new string(wort.Reverse().ToArray()))
        {
            Console.WriteLine("Palidrom");
        }
        else
        {
            Console.WriteLine("Kein Palidrom");
        }
    }
    
}