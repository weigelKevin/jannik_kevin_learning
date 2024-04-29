using System.Threading.Channels;

namespace Fahrzeugverleih;

class Program
{
    static void Main(string[] args)
    {
        Vehicle v1 = new Vehicle("V001", "Toyota", "Corolla", "2020", 1500, true, 35);
        Vehicle v2 = new Vehicle("V002", "Honda", "Civic", "2019", 25000, true, 30);
        Vehicle v3 = new Vehicle("V003", "Ford", "Focus", "2018", 36000, false, 25);
        Vehicle v4 = new Vehicle("V004", "Chevrolet", "Impala", "2021", 5000, true, 40);
        Vehicle v5 = new Vehicle("V005", "BMW", "3 Series", "2017", 45000, false, 45);
        Vehicle v6 = new Vehicle("V006", "Audi", "A4", "2022", 10000, true, 50);

        Vehicle[] vo1 = { v1, v2, v3, v4, v5, v6 };

        foreach (var Test in vo1)
        {
            Console.WriteLine(Test);
        }
    }
}