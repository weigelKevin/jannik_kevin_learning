namespace _2_Fahrzeugverleih;

public interface ICalc
{
    double CalculateRentalCost(int days);
}
public class Vehicle:ICalc
{
    public string ID { get; set; }
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public string Year { get; set; }
    public double Mileage { get; set; }
    public bool Availability { get; set; }
    public double Rental { get; set; }

    public Vehicle(string id, string manufacturer, string model, string year, double mileage, bool availability, double rental)
    {
        ID = id;
        Manufacturer = manufacturer;
        Model = model;
        Year = year;
        Mileage = mileage;
        Availability = availability;
        Rental = rental;
    }

    public double CalculateRentalCost(int days)
    {
        return Rental * days;
    }
}