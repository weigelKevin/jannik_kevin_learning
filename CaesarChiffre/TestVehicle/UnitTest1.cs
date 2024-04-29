using NUnit.Framework;
using Fahrzeugverleih; // Stellen Sie sicher, dass der Namespace korrekt importiert wird

namespace Fahrzeugverleih.Tests
{
    [TestFixture]
    public class VehicleTests
    {
        [Test]
        public void DefaultConstructor_InitializesFieldsCorrectly()
        {
            // Arrange
            string id = "ABC123";
            string manufacture = "Toyota";
            string model = "Corolla";
            string year = "2020";
            double mileage = 5000.0;
            bool availability = true;
            double rentalCost = 50.0;

            // Act
            Vehicle vehicle = new Vehicle(id, manufacture, model, year, mileage, availability, rentalCost);

            // Assert
            Assert.AreEqual(id, vehicle.Id);
            Assert.AreEqual(manufacture, vehicle.Manufacture);
            Assert.AreEqual(model, vehicle.Model);
            Assert.AreEqual(year, vehicle.Year);
            Assert.AreEqual(mileage, vehicle.Mileage);
            Assert.AreEqual(availability, vehicle.Availability);
            Assert.AreEqual(rentalCost, vehicle.RentalCOst);
        }
    }
}