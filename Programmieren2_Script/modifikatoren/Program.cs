namespace modifikatoren;

class Math
{
    public double SumOut(out double a, out double b)
    {
        a = 5.9D;
        b = 1.1D;
        return a + b;
    }

    public double OverrideVarWithRef(ref double value, double AddNum)
    {
        value = value + AddNum;
        return value;
    }

    public void SumArray(params double[] parameter)
    {
        double summe = 0.0;
        foreach (double arg in parameter)
        {
            summe = summe + arg;
        }

        Console.WriteLine(summe);
    }

    public void PrintOuterParameter(out int a, out int b)
    {
        a = 5;
        b = 7;

        void PrintInnerParameter(int c)
        {
            Console.WriteLine($"Innen: {c+1}");
        }

        PrintInnerParameter(a);
        Console.WriteLine($"Außen: a: {a} b: {b}");
    }

    /*
    public double InExample(in int i)
    {
        int i = 5; // i kann nicht überschrieben werden, da diese variable durch den in modifikator schreibgeschützt ist
        return i+1;
    }*/
}
class Program
{
    static void Main(string[] args)
    {
        int a, b;
        double refNum = 3;
        
        double result, valueA, valueB;
        Math m1 = new Math();
        
        double ergebnis = m1.SumOut(out valueA, out valueB );
        Console.WriteLine(ergebnis);

        Console.WriteLine($"RefNum before: {refNum}");
        m1.OverrideVarWithRef(ref refNum, 2.0D);
        Console.WriteLine($"RefNum after: {refNum}");

        m1.SumArray(1.1, 2.2, 3.3, 4.4,5.5);
        m1.PrintOuterParameter(out a, out b);
    }
}