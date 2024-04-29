namespace VehicleHouse;

public class Motorcycle : Vehicle
{
    private int Wheels { get; set; }

    private string? EngineDisplacement { get; set; }

    private string VehicleType { get; set; }

    public Motorcycle(string id, string manufacturer, string model, string year, string mileAge, bool availability,
        double rental, int wheels, string engineDisplacement, string vehicleType) : base(id, manufacturer, model, year,
        mileAge, availability, rental)
    {
        Wheels = wheels;
        EngineDisplacement = engineDisplacement;
        VehicleType = vehicleType;
    }
}