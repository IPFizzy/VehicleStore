/*
 * Keon Bushman
 * CST - 250
 * 05/24/2026
 * Vehicle Class Library
 * Activity 1
 * Activity 1 Guide
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleClassLibrary.Models
{
    public class CarModel : VehicleModel
    {
        // Class level properties
        public bool IsConvertible { get; set; }
        public decimal TrunkSize { get; set; } // In cubic feet

        /// <summary>
        /// Default constructor for the car model.
        /// </summary>
        public CarModel() : base()
        {
            IsConvertible = false;
            TrunkSize = 0m;
        }

        /// <summary>
        /// Parameterized constructor for a car model.
        /// </summary>
        /// <param name="id">The vehicle id.</param>
        /// <param name="make">The vehicle make.</param>
        /// <param name="model">The vehicle model.</param>
        /// <param name="year">The vehicle year.</param>
        /// <param name="price">The vehicle price.</param>
        /// <param name="numWheels">The number of wheels on the vehicle.</param>
        /// <param name="isConvertible">Whether the car is convertible.</param>
        /// <param name="trunkSize">The trunk size in cubic feet.</param>
        public CarModel(
            int id,
            string make,
            string model,
            int year,
            decimal price,
            int numWheels,
            string color,
            int mileage,
            bool isConvertible,
            decimal trunkSize) : base(id, make, model, year, price, numWheels, color, mileage)
        {
            IsConvertible = isConvertible;
            TrunkSize = trunkSize;
        }

        /// <summary>
        /// ToString method for printing a car.
        /// </summary>
        /// <returns>A formatted string with the car information.</returns>
        public override string ToString()
        {
            // Use a ternary operator to get the convertible string
            // Condition ? string if true : string if false
            string convertible = IsConvertible ? "with" : "without";

            // Print the car in the following format
            // 1: 2019 Jeep Wrangler with 4 wheels and a 14.7 cubic foot trunk
            // with(out) a convertible top - $27000.00
            return $"{Id}: {Year} {Color} {Make} {Model} with {NumWheels} wheels, {Mileage} miles, " +
                $"and a {TrunkSize} cubic foot trunk {convertible} a convertible top - {Price:C2}";
        }

        /// <summary>
        /// Compare car objects to prevent duplicate entries.
        /// </summary>
        /// <param name="obj">The object being compared.</param>
        /// <returns>True if the cars match.</returns>
        public override bool Equals(object? obj)
        {
            // Make sure the object is a CarModel
            if (obj is not CarModel car)
            {
                return false;
            }

            // Compare base vehicle and car properties
            return base.Equals(obj) &&
                IsConvertible == car.IsConvertible &&
                TrunkSize == car.TrunkSize;
        }

        /// <summary>
        /// Gets the hash code for the car object.
        /// </summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), IsConvertible, TrunkSize);
        }
    }
}