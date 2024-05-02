namespace fahrzeugverleih;



public abstract class Vehicle
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

   public virtual double CalculateRentalCost(int days)
   {
      return (days * this.Rental);
   }

   public override string ToString()
   {
      return $"ID: {Id}, Manufacturer: {Manufacturer}, Model: {Model}, Year: {Year}, Mileage: {Mileage} km, Availability: {Avaibility}, Rental: ${Rental}/day";
   }

  
      
}
public class Motorcyle:Vehicle
{
   private int AnzahlRaeder { get; set; }
   private double Motorhubraum { get; set; }
   private string Fahrzeugtyp { get; set; }
      
   public Motorcyle(string id, string manufacturer, string model, string year, double mileage, bool avaibility, double rental, int anzahlRaeder, double motorhubraum, string fahrzeugtyp) : base(id, manufacturer, model, year, mileage, avaibility, rental)
   {
      AnzahlRaeder = anzahlRaeder;
      Motorhubraum = motorhubraum;
      Fahrzeugtyp = fahrzeugtyp;
   }
}

public class Car:Vehicle
{
   private int AnzahlTueren { get; set; }
   private string Kraftstofftyp { get; set; }
   private double Kofferraumkapazitaet { get; set; }

   public Car(string id, string manufacturer, string model, string year, double mileage, bool avaibility, double rental, int anzahlTueren, string kraftstofftyp, double kofferraumkapazitaet) : base(id, manufacturer, model, year, mileage, avaibility, rental)
   {
      AnzahlTueren = anzahlTueren;
      Kraftstofftyp = kraftstofftyp;
      Kofferraumkapazitaet = kofferraumkapazitaet;
   }
}

public class Truck:Vehicle
{
   private double Ladelast { get; set; }
   private int AnzahlAchsen { get; set; }
   private double Ladeflaeche { get; set; }

   public Truck(string id, string manufacturer, string model, string year, double mileage, bool avaibility, double rental, double ladelast, int anzahlAchsen, double ladeflaeche) : base(id, manufacturer, model, year, mileage, avaibility, rental)
   {
      Ladelast = ladelast;
      AnzahlAchsen = anzahlAchsen;
      Ladeflaeche = ladeflaeche;
   }

   public override double CalculateRentalCost(int days)
   {
      return base.CalculateRentalCost(days)*this.Ladeflaeche;
   }
}