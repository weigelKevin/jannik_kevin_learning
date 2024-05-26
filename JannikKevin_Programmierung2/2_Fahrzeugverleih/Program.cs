using System.Runtime.Intrinsics;

namespace _2_Fahrzeugverleih;

class Program
{
    static void Main(string[] args)
    {
        
        Vehicle vehicle1 = new Vehicle("V001", "Toyota", "Corolla", "2021", 15000.0, true, 50.0);
        Vehicle vehicle2 = new Vehicle("V002", "Ford", "Mustang", "2020", 25000.0, false, 75.0);
        Vehicle vehicle3 = new Vehicle("V003", "Honda", "Civic", "2019", 30000.0, true, 45.0);
        Vehicle vehicle4 = new Vehicle("V004", "Tesla", "Model 3", "2022", 5000.0, true, 100.0);
        Vehicle vehicle5 = new Vehicle("V005", "BMW", "X5", "2018", 40000.0, false, 80.0);

        double rent = vehicle1.CalculateRentalCost(2);
        Console.WriteLine(rent);
    }
}