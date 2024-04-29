using System.Security.Cryptography;

namespace Tier;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Dog rex = new Dog(4, "black", true, true);
        Cat belial = new Cat(4, "white", true, true);
        
        belial.DoMiau();
        rex.Bark();
        belial.MakeSound();
        rex.MakeSound();
    }
}