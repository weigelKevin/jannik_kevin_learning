namespace _2_Caesar;

class Program
{
    static void Main(string[] args)
    {
        Caesar c1 = new Caesar();

        string word;
        int rotation;
        c1.HelloUser(out word,out rotation);
        c1.isUpper(word);
        c1.isInRotationRange(rotation);
        c1.DoChiffre(word,rotation);
    }
}