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
    public class MotorcycleModel : VehicleModel
    {
        // Class level properties
        public bool HasSideCar { get; set; }
        public decimal SeatHeight { get; set; } // In inches

        /// <summary>
        /// Default constructor for the motorcycle model.
        /// </summary>
        public MotorcycleModel() : base()
        {
            HasSideCar = false;
            SeatHeight = 0m;
        }

        /// <summary>
        /// Parameterized constructor for the motorcycle model.
        /// </summary>
        /// <param name="id">The vehicle id.</param>
        /// <param name="make">The vehicle make.</param>
        /// <param name="model">The vehicle model.</param>
        /// <param name="year">The vehicle year.</param>
        /// <param name="price">The vehicle price.</param>
        /// <param name="numWheels">The number of wheels on the vehicle.</param>
        /// <param name="hasSideCar">Whether the motorcycle has a side car.</param>
        /// <param name="seatHeight">The motorcycle seat height in inches.</param>
        public MotorcycleModel(
            int id,
            string make,
            string model,
            int year,
            decimal price,
            int numWheels,
            string color,
            int mileage,
            bool hasSideCar,
            decimal seatHeight) : base(id, make, model, year, price, numWheels, color, mileage)
        {
            HasSideCar = hasSideCar;
            SeatHeight = seatHeight;
        }

        /// <summary>
        /// ToString method for printing a motorcycle.
        /// </summary>
        /// <returns>A formatted string with the motorcycle information.</returns>
        public override string ToString()
        {
            // Use a ternary operator to get the side car string
            // Condition ? string if true : string if false
            string sideCar = HasSideCar ? "with" : "without";

            // Print the motorcycle in the following format
            // 1: 2015 Yamaha Bolt with 2 wheels and a 44.1 inch seat with(out) a side car - $8000.00
            return $"{Id}: {Year} {Color} {Make} {Model} with {NumWheels} wheels, {Mileage} miles, " +
                $"and a {SeatHeight} inch seat {sideCar} a side car - {Price:C2}";
        }
    }
}