namespace Fahrzeugverleih;



public class Vehicle
{
    private string Id { get; set; }
    private string Manufacturer { get; set; }
    private string Model { get; set; }
    private string Year { get; set; }
    private double Mileage { get; set; }
    private bool Avaibility { get; set; }
    private double Rental { get; set; }

    public Vehicle(string id, string manufacturer, string model, string year, double mileage, bool avaibility, double rental)
    {
        Id = id;
        Manufacturer = manufacturer;
        Model = model;
        Year = year;
        Mileage = mileage;
        Avaibility = avaibility;
        Rental = rental;
    }

    public virtual double  CalculateRentalCost(int days, double rental)
    {
        double ergebnis = days * rental;
        return ergebnis;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Manufacturer: {Manufacturer}, Model: {Model}, Year: {Year}, Mileage: {Mileage} km, Availability: {Avaibility}, Rental: ${Rental}/day";
    }
}

public class Motorcycle:Vehicle
{
    private int anzahlRaeder { get; set; }
    private double MotorGroesse { get; set; }
    
    private string FahrzeugTyp { get; set; }

    public Motorcycle(string id, string manufacturer, string model, string year, double mileage, bool avaibility, double rental, int anzahlRaeder, double motorGroesse,string fahrzeugTyp) : base(id, manufacturer, model, year, mileage, avaibility, rental)
    {
        this.anzahlRaeder = anzahlRaeder;
        MotorGroesse = motorGroesse;
        FahrzeugTyp = fahrzeugTyp;
    }
}

public class Car : Vehicle
{
    private int anzahlTueren { get; set; }
    private string kraftStoff { get; set; }
    private double KofferaumKapazität { get; set; }

    public Car(string id, string manufacturer, string model, string year, double mileage, bool avaibility, double rental, int anzahlTueren, string kraftStoff, double kofferaumKapazität) : base(id, manufacturer, model, year, mileage, avaibility, rental)
    {
        this.anzahlTueren = anzahlTueren;
        this.kraftStoff = kraftStoff;
        KofferaumKapazität = kofferaumKapazität;
    }

    
}

public class truck : Vehicle
{
    private int LadeLast { get; set; }
    private int AnzahlAchse { get; set; }
    private int LadeFlaeche { get; set; }

    public truck(string id, string manufacturer, string model, string year, double mileage, bool avaibility, double rental, int ladeLast, int anzahlAchse, int ladeFlaeche) : base(id, manufacturer, model, year, mileage, avaibility, rental)
    {
        LadeLast = ladeLast;
        AnzahlAchse = anzahlAchse;
        LadeFlaeche = ladeFlaeche;
    }

    public override double CalculateRentalCost(int days, double rental)
    {

        double preis = base.CalculateRentalCost(days, rental) * this.LadeFlaeche;
        Console.WriteLine(preis);
        return preis;
    }
}