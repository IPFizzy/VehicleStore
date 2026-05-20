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

namespace VehicleClassLibrary.Models
{
    public class VehicleModel
    {
        // Class level properties
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public int NumWheels { get; set; }

        /// <summary>
        /// Default constructor for the vehicle model.
        /// </summary>
        public VehicleModel()
        {
            Id = 0;
            Make = "Unknown";
            Model = "Unknown";
            Year = 0;
            Price = 0m;
            NumWheels = 0;
        }

        /// <summary>
        /// Parameterized constructor for the vehicle model class.
        /// </summary>
        /// <param name="id">The vehicle id.</param>
        /// <param name="make">The vehicle make.</param>
        /// <param name="model">The vehicle model.</param>
        /// <param name="year">The vehicle year.</param>
        /// <param name="price">The vehicle price.</param>
        /// <param name="numWheels">The number of wheels on the vehicle.</param>
        public VehicleModel(int id, string make, string model, int year, decimal price, int numWheels)
        {
            Id = id;
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            NumWheels = numWheels;
        }

        /// <summary>
        /// ToString method for printing a vehicle.
        /// </summary>
        /// <returns>A formatted string with the vehicle information.</returns>
        public override string ToString()
        {
            // Print the vehicle in the following format
            // 1: 2013 Ford Fiesta with 4 wheels - $800.00
            return $"{Id}: {Year} {Make} {Model} with {NumWheels} wheels - {Price:C2}";
        }
    }
}