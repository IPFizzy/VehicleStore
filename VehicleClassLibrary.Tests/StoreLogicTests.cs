using VehicleClassLibrary.Models;
using VehicleClassLibrary.Services.BusinessLogicLayer;

namespace VehicleClassLibrary.Tests
{
    public class StoreLogicTests
    {
        // Mark this method as a unit test using the [Fact] attribute from xUnit
        [Fact]
        public void AddVehicleToInventory_ShouldIncreaseInventoryCount()
        {
            // Arrange: Create an instance of StoreLogic (System Under Test - SUT)
            StoreLogic store = new StoreLogic();

            // Create a new CarModel object to add to inventory
            CarModel car = new CarModel
            {
                Id = 1,
                Make = "Toyota",
                Model = "Camry",
                Year = 2020,
                Price = 25000m,
                NumWheels = 4,
                IsConvertible = true,
                TrunkSize = 2.5m
            };

            // Act: Add the vehicle to the inventory
            store.AddVehicleToInventory(car);

            // Retrieve the current inventory
            List<VehicleModel> inventory = store.GetInventory();

            // Assert: Verify that the vehicle was added to inventory
            Assert.Contains(car, inventory);
        }
    }
}