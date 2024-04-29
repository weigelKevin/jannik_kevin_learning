namespace VehicleHouse;

public class Car:Vehicle
{
    private int Dors { get; set; }
    private string? FuelType { get; set; }
    private double TrunkCapacity { get; set; }
    
    public Car(string id, string manufacturer, string model, string year, string mileAge, bool availability,
        double rental, int dors, string fuelType, double trunkCapacity) : base(id, manufacturer, model, year,
        mileAge, availability, rental)
    {
        Dors = dors;
        FuelType = fuelType;
        TrunkCapacity = trunkCapacity;
    }
    
    
}