namespace Tiere;

class Program
{
    static void Main(string[] args)
    {
        Katze k1 = new("Wiskas","Hello Kitty",100);
        Hund h1 = new("Fluffy",2,"Jannik");
        k1.MakeSound();
        h1.MakeSound();
    }
}