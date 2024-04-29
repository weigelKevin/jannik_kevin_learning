using System;

public class caesar_chiffre
{
    static void Main(string[] args)
    {
        Console.WriteLine("HAlllo");
        Console.WriteLine("Geben Sie einen Text ein");
        string eingabe = Console.ReadLine();

        if (eingabe == eingabe.ToUpper())
        {
            Console.WriteLine("Eingabe enthält nur Großbuchstaben");

            Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 25 ein: " );
            int zahl = Convert.ToInt32(Console.ReadLine());

            if (zahl>=1 && zahl<=25)
            { 
                Console.WriteLine("erfüllt");

                for (int i = 0; i < zahl; i++)
                {
                    string verschieben = eingabe[i]
                }
            }
            else
            {
                Console.WriteLine("nicht erfüllt");
            }
            

        }
        else
        {
            Console.WriteLine("Eingabe enthält keine Großbuchstaben");
        }
    }
}