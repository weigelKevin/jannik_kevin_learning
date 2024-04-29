namespace fahrzeugverleih;



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

   public double CalculateRentalCost(int days, double rental)
   {
      return (days * Rental);
   }

   public override string ToString()
   {
      return $"ID: {Id}, Manufacturer: {Manufacturer}, Model: {Model}, Year: {Year}, Mileage: {Mileage} km, Availability: {Avaibility}, Rental: ${Rental}/day";
   }
}