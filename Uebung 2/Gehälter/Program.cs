namespace Gehälter;

class Program
{
    static void Main(string[] args)
    {
        hourlyWorker h1 = new hourlyWorker("Hans", "Test", 20, 18);
        h1.calculateSalery();
    }
}