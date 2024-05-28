namespace IteratorUngeradeZahlen;

class Program
{
    static void Main(string[] args)
    {
        foreach (var var in OddNumberIterator().Take(10))
        {
            Console.WriteLine(var);
        }
    }

    public static IEnumerable<int> OddNumberIterator()
    {
        for (int i = 0; i < 1000; i=i+2)
        {
            yield return i;
        }
    }
}