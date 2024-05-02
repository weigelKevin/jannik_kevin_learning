using System.Security.Cryptography;

namespace Fahrzeugverleih;

class Program
{
    static void Main(string[] args)
    {
        truck t1 = new truck("1234", "23", "FR", "2018", 100, true, 200, 200, 2, 200);
        t1.CalculateRentalCost(20, 10);
    }
}