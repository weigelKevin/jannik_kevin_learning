namespace jannik;
class Math
{
    public double Methode(ref double y)
    {
        y = y + 1.1;
        return y;
    }

}
class Program
{
    static void Main(string[] args)
    {
        double y = 5.5D;
        Math m1 = new();
        m1.Methode(ref y);
        Console.WriteLine(y);
    }
}