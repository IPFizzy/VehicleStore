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
    public class PickupModel : VehicleModel
    {
        // Class level properties
        public bool HasBedCover { get; set; }
        public decimal BedSize { get; set; } // In cubic feet

        /// <summary>
        /// Default constructor for a pickup.
        /// </summary>
        public PickupModel() : base()
        {
            HasBedCover = false;
            BedSize = 0m;
        }

        /// <summary>
        /// Parameterized constructor for a pickup.
        /// </summary>
        /// <param name="id">The vehicle id.</param>
        /// <param name="make">The vehicle make.</param>
        /// <param name="model">The vehicle model.</param>
        /// <param name="year">The vehicle year.</param>
        /// <param name="price">The vehicle price.</param>
        /// <param name="numWheels">The number of wheels on the vehicle.</param>
        /// <param name="hasBedCover">Whether the pickup has a bed cover.</param>
        /// <param name="bedSize">The pickup bed size in cubic feet.</param>
        public PickupModel(
            int id,
            string make,
            string model,
            int year,
            decimal price,
            int numWheels,
            string color,
            int mileage,
            bool hasBedCover,
            decimal bedSize) : base(id, make, model, year, price, numWheels, color, mileage)
        {
            HasBedCover = hasBedCover;
            BedSize = bedSize;
        }

        /// <summary>
        /// ToString method for printing a pickup.
        /// </summary>
        /// <returns>A formatted string with the pickup information.</returns>
        public override string ToString()
        {
            // Use a ternary operator to get the bed cover string
            // Condition ? string if true : string if false
            string bedCover = HasBedCover ? "with" : "without";

            // Print the pickup in the following format
            // 1: 2001 Toyota Tundra with 4 wheels and a 8.3 cubic foot bed with(out) a bed cover - $5000.00
            return $"{Id}: {Year} {Color} {Make} {Model} with {NumWheels} wheels, {Mileage} miles, " +
                $"and a {BedSize} cubic foot bed {bedCover} a bed cover - {Price:C2}";
        }

        /// <summary>
        /// Compare pickup objects to prevent duplicate entries.
        /// </summary>
        /// <param name="obj">The object being compared.</param>
        /// <returns>True if the pickups match.</returns>
        public override bool Equals(object? obj)
        {
            // Make sure the object is a PickupModel
            if (obj is not PickupModel pickup)
            {
                return false;
            }

            // Compare base vehicle and pickup properties
            return base.Equals(obj) &&
                HasBedCover == pickup.HasBedCover &&
                BedSize == pickup.BedSize;
        }

        /// <summary>
        /// Gets the hash code for the pickup object.
        /// </summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), HasBedCover, BedSize);
        }
    }
}