/*
 * Keon Bushman
 * CST - 250
 * 05/19/2026
 * Vehicle Class Library
 * Activity 1
 * Activity 1 Guide
 */

using System;
using System.Collections.Generic;
using System.Text;
using VehicleClassLibrary.Models;

namespace VehicleClassLibrary.Services.DataAccessLayer
{
    public class StoreDAO
    {
        // VehicleModel list for the store's inventory
        private List<VehicleModel> _inventory;

        // VehicleModel list for the user's shopping cart
        private List<VehicleModel> _shoppingCart;

        // The directory for the inventory text file
        private string _fileDirectory = "Data";

        // The name of the inventory text file
        private string _textFile = "Inventory.txt";

        // The full path to the text file
        private string _filePath;

        /// <summary>
        /// Default constructor for StoreDAO.
        /// </summary>
        public StoreDAO()
        {
            // Initialize the vehicle model lists
            _inventory = new List<VehicleModel>();
            _shoppingCart = new List<VehicleModel>();

            // Set up the file path to the inventory text file
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _fileDirectory, _textFile);
        }

        /// <summary>
        /// Gets the inventory list.
        /// </summary>
        /// <returns>The inventory list.</returns>
        public List<VehicleModel> GetInventory()
        {
            // Return the current inventory list
            return _inventory;
        }

        /// <summary>
        /// Gets the shopping cart list.
        /// </summary>
        /// <returns>The shopping cart list.</returns>
        public List<VehicleModel> GetShoppingCart()
        {
            // Return the current shopping cart list
            return _shoppingCart;
        }

        /// <summary>
        /// Adds a vehicle to the inventory.
        /// </summary>
        /// <param name="vehicle">The vehicle being added to the inventory.</param>
        /// <returns>The id of the added vehicle.</returns>
        public int AddVehicleToInventory(VehicleModel vehicle)
        {
            // Set the vehicle id based on the inventory count
            vehicle.Id = _inventory.Count + 1;

            // Add the vehicle to the inventory
            _inventory.Add(vehicle);

            // Return the new vehicle id
            return vehicle.Id;
        }

        /// <summary>
        /// Add a vehicle to the shopping cart based on the vehicle's id.
        /// </summary>
        /// <param name="vehicleId">The id of the vehicle to add to the shopping cart.</param>
        /// <returns>The number of items in the shopping cart.</returns>
        public int AddVehicleToCart(int vehicleId)
        {
            // Loop through the inventory to find the correct vehicle
            for (int i = 0; i < _inventory.Count; i++)
            {
                // Check if the inventory vehicle id matches the parameter
                if (_inventory[i].Id == vehicleId)
                {
                    // If so, add the vehicle to the shopping cart
                    _shoppingCart.Add(_inventory[i]);
                }
            }

            // Return the number of items in the shopping cart
            return _shoppingCart.Count;
        }
    }
}