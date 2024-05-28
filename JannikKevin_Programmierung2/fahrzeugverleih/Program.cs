namespace fahrzeugverleih;

class Program
{
    static void Main(string[] args)
    {
        /*
         
         //Inhalt aus Teil A
        Vehicle v1 = new Vehicle("V001", "Toyota", "Corolla", "2020", 15000, true, 35);
        Vehicle v2 = new Vehicle("V002", "Honda", "Civic", "2019", 25000, true, 30);
        Vehicle v3 = new Vehicle("V003", "Ford", "Focus", "2018", 36000, false, 25);
        Vehicle v4 = new Vehicle("V004", "Chevrolet", "Impala", "2021", 5000, true, 40);
        Vehicle v5 = new Vehicle("V005", "BMW", "3 Series", "2017", 45000, false, 45);
        Vehicle v6 = new Vehicle("V006", "Audi", "A4", "2022", 10000, true, 50);


        Vehicle[] vc1 = { v1, v2, v3, v4, v5, v6 };
        


        for (int i = 0; i < vc1.Length; i++)
        {
            Console.WriteLine(vc1[i].ToString());
        }
        */

        Vehicle v1 = new Car("V001", "Toyota", "Corolla", "2020", 15000, true, 35, 4, "Benzin", 500);
        Vehicle v2 = new Motorcyle("V002", "Honda", "Civic", "2019", 25000, true, 30, 2, 600, "Sport");
        Vehicle v3 = new Truck("V003", "Ford", "Focus", "2018", 36000, false, 25, 500, 4, 30);

        Vehicle.GetVehicleCount();
        


    }
}