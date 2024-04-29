namespace Testsh;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Eingabe: ");
    string ? eingabe = Console.ReadLine();
    if (eingabe==eingabe.ToUpper())
    {
      Console.WriteLine(":)");
      char[] eingabe1 = eingabe.ToCharArray();

      for (int i = 0; i < eingabe1.Length-1; i++)
      for (int j = eingabe.Length-1; j>=0; j--)
      {
        if (eingabe1[i]== eingabe1[j])
        {
          Console.WriteLine("Palidrom");
        }
      }
      {
        
      }
    }
    else
    {
      Console.WriteLine(":(");
    }
    
  }
}
