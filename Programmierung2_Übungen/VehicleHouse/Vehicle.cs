namespace VehicleHouse
{

    public class Vehicle
    {
        private string Id { get; set; }
        private string Manufacturer { get; set; }
        private string Model { get; set; }
        private string Year { get; set; }
        private string MileAge { get; set; }
        private bool Availability { get; set; }
        protected double Rental { get; set; }

        public Vehicle(string id, string manufacturer, string model, string year, string mileAge, bool availability, double rental)
        {
            this.Id = id;
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Year = year;
            this.MileAge = mileAge;
            this.Availability = availability;
            this.Rental = rental;
        }

        public virtual double CalculateRentalCost(int days)
        {
            double toPay = Rental * days;
            return toPay;
        }

        public override string ToString()
        {
            return $"ID: {Id}. \n Manufacturer: {Manufacturer}. \n Model: {Model}. \n Year: {Year}. \n Mileage: {MileAge}. \n Availability: {Availability}. \n Rental: {Rental}. \n";
        }
      
    }
    
    
    
}