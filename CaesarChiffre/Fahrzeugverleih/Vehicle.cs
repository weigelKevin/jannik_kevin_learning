namespace Fahrzeugverleih;

public class Vehicle
{
    private string Id { get; set; }
    private string Manufacture { get; set; }
    private string Model { get; set; }
    private string Year { get; set; }
    private double Mileage { get; set; }
    private bool Availability { get; set; }
    private double RentalCOst { get; set; }

    public Vehicle(string id, string manufacture, string model, string year, double mileage, bool availability, double rentalCOst)
    {
        Id = id;
        Manufacture = manufacture;
        Model = model;
        Year = year;
        Mileage = mileage;
        Availability = availability;
        RentalCOst = rentalCOst;
    }

    public double CalcuteRenatlCost(int days, double rentalCost)
    {
        return days * rentalCost;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Manufacturer: {Manufacture}, Model: {Model}, Year: {Year}, Mileage: {Mileage} km, Availability: {Availability}, Rental Cost: ${RentalCOst}/day"; 
    }
}