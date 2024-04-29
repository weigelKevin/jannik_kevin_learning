namespace VehicleHouse;

public class Truck:Vehicle
{
    private double LoadCapacity { get; set; }
    private int Axle { get; set; }
    private double LoadArea { get; set; }
    
    public Truck(string id, string manufacturer, string model, string year, string mileAge, bool availability,
        double rental, double loadCapacity, int axle, double loadArea) : base(id, manufacturer, model, year, mileAge, availability, rental)
    {
        LoadArea = loadArea;
        Axle = axle;
        LoadCapacity = loadCapacity;
    }

    public double CalculateRentalCost(int days,double fee)
    {
        return (Rental * days) + (LoadArea * fee);
    }
}