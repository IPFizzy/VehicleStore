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
using VehicleClassLibrary.Services.DataAccessLayer;

namespace VehicleClassLibrary.Services.BusinessLogicLayer
{
    public class StoreLogic
    {
        // Declare class level variables
        private StoreDAO _storeDAO;

        /// <summary>
        /// Default constructor for StoreLogic
        /// </summary>
        public StoreLogic()
        {
            // Initialize the DAO variable
            _storeDAO = new StoreDAO();
        }

        /// <summary>
        /// Get a list of vehicles in the inventory.
        /// </summary>
        /// <returns>The inventory list.</returns>
        public List<VehicleModel> GetInventory()
        {
            // Call and return the GetInventory method in the DAO
            return _storeDAO.GetInventory();
        }

        /// <summary>
        /// Get a list of the vehicles in the user's shopping cart.
        /// </summary>
        /// <returns>The shopping cart list.</returns>
        public List<VehicleModel> GetShoppingCart()
        {
            // Call and return the GetShoppingCart method in the DAO
            return _storeDAO.GetShoppingCart();
        }

        /// <summary>
        /// Add a vehicle to the inventory.
        /// </summary>
        /// <param name="vehicle">The vehicle being added to the inventory.</param>
        /// <returns>The id of the added vehicle.</returns>
        public int AddVehicleToInventory(VehicleModel vehicle)
        {
            // Call and return the AddVehicleToInventory method in the DAO
            return _storeDAO.AddVehicleToInventory(vehicle);
        }

        /// <summary>
        /// Add a vehicle to the shopping cart based on the vehicle id.
        /// </summary>
        /// <param name="vehicleId">The id of the vehicle being added to the shopping cart.</param>
        /// <returns>The number of items in the shopping cart.</returns>
        public int AddVehicleToCart(int vehicleId)
        {
            // Call and return the AddVehicleToCart method in the DAO
            return _storeDAO.AddVehicleToCart(vehicleId);
        }

        /// <summary>
        /// Write the inventory to a text file.
        /// </summary>
        public void WriteInventory()
        {
            // Call the WriteInventory method in the DAO
            _storeDAO.WriteInventory();
        }

        /// <summary>
        /// Read the list of vehicles from a text file.
        /// </summary>
        /// <returns>The inventory list.</returns>
        public List<VehicleModel> ReadInventory()
        {
            // Call and return the ReadInventory method in the DAO
            return _storeDAO.ReadInventory();
        }

        /// <summary>
        /// Get the total of the user's shopping cart and clear the cart.
        /// </summary>
        /// <returns>The total price of the shopping cart.</returns>
        public decimal Checkout()
        {
            // Call and return the Checkout method in the DAO
            return _storeDAO.Checkout();
        }
    }
}
