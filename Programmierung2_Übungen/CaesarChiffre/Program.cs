namespace CaesarChiffre;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Greetings p = new Greetings();
        p.HelloUser();
        string input1 = Console.ReadLine();
        checkIf check1 = new checkIf();
        check1.isUpper(input1);
        Console.WriteLine("How often rotate");
        string input2 = Console.ReadLine();
        check1.checkRotationAmount(input2);
        DoRotation dR = new DoRotation();
        dR.DoRotate(input1, input2);

    }
}