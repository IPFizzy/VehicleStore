/*
 * Keon Bushman
 * CST - 250
 * 05/19/2026
 * Vehicle Class Library
 * Activity 1
 * Activity 1 Guide
 */

using System.Collections.Generic;
using Xunit;
using VehicleClassLibrary.Models;
using VehicleClassLibrary.Services.DataAccessLayer;

namespace VehicleClassLibrary.Tests
{
    public class StoreLogicTests
    {
        // Mark this method as a unit test using the [Fact] attribute from xUnit
        [Fact]
        public void AddVehicleToInventory_ShouldIncreaseInventoryCount()
        {
            // Arrange: Create an instance of StoreDAO
            StoreDAO store = new StoreDAO();

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

        // Test for GetInventory when no vehicles have been added
        [Fact]
        public void GetInventory_ShouldReturnEmptyList_WhenNoVehiclesAdded()
        {
            // Arrange: Create an instance of StoreDAO
            StoreDAO store = new StoreDAO();

            // Act: Retrieve the inventory without adding any vehicles
            List<VehicleModel> inventory = store.GetInventory();

            // Assert: The inventory should be empty
            Assert.Empty(inventory);
        }

        // Test adding a vehicle to the shopping cart
        [Fact]
        public void AddVehicleToCart_ShouldAddVehicle_WhenValidVehicleIdGiven()
        {
            // Arrange: Create an instance of StoreDAO
            StoreDAO store = new StoreDAO();

            // Create and add a vehicle to the inventory
            CarModel car = new CarModel
            {
                Id = 1,
                Make = "Honda",
                Model = "Civic",
                Year = 2019,
                Price = 20000m,
                NumWheels = 4,
                IsConvertible = true,
                TrunkSize = 2.5m
            };

            store.AddVehicleToInventory(car);

            // Act: Add the vehicle to the shopping cart using its Id
            int result = store.AddVehicleToCart(car.Id);

            // Retrieve the shopping cart contents
            List<VehicleModel> cart = store.GetShoppingCart();

            // Assert: Verify that AddVehicleToCart returned the cart count
            Assert.Equal(1, result);

            // Assert: Verify that the cart contains the correct vehicle
            Assert.Contains(cart, verify => verify.Id == car.Id);
        }

        // Test that GetShoppingCart returns an empty list when no vehicles are added
        [Fact]
        public void GetShoppingCart_ShouldReturnEmptyList_WhenNoVehiclesAdded()
        {
            // Arrange: Create an instance of StoreDAO
            StoreDAO store = new StoreDAO();

            // Act: Retrieve the shopping cart without adding any vehicles
            List<VehicleModel> cart = store.GetShoppingCart();

            // Assert: The shopping cart should be empty
            Assert.Empty(cart);
        }
    }
}