using System.Runtime.InteropServices;

namespace VehicleHouse;

class Program
{
    
    
    static void Main(string[] args)
    {
        /*
        Vehicle v1 = new Vehicle("1", "Audi", "R8", "2023", "NEW", true, 300.50D);
        Vehicle v2 = new Vehicle("2", "BMW", "M3", "2022", "USED", true, 280.00D);
        Vehicle v3 = new Vehicle("3", "Mercedes", "C300", "2021", "USED", true, 270.75D);
        Vehicle v4 = new Vehicle("4", "Tesla", "Model S", "2023", "NEW", true, 320.00D);
        Vehicle v5 = new Vehicle("5", "Ford", "Mustang", "2020", "USED", false, 250.00D);
        Vehicle v6 = new Vehicle("6", "Chevrolet", "Camaro", "2022", "NEW", true, 295.00D);

        Vehicle[] vc = new Vehicle[]
        {
            v1,v2,v3,v4,v5,v6
        };
        
        Console.WriteLine(v1.CalculateRentalCost(2));
        Console.WriteLine(v1.ToString());

        for (int i = 0; i < vc.Length; i++)
        {
            Console.WriteLine(vc[i].ToString());
        }
        */

        Truck t1 = new Truck("T1", "Trumph", "keine Ahnung", "2001", "345897", true, 1000.5D, 200D, 4, 2000);
        Console.WriteLine(t1.CalculateRentalCost(2,2));
    }
}