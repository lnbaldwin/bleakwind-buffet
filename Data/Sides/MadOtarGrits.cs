using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;
/*
 * Author: Laura Baldwin
 * Date Written: Aug 30th 2020
 * Class Name: MadOtarGrits
 * Purpose: To store information about a MadOtarGrits order
 */
namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class to describe an order of a "Mad Otar Grits" aka cheesy grits
    /// </summary>
    class MadOtarGrits
    {
        private Size size = Size.Small;

        /// <summary>
        /// Getter and setter for the size of the order
        /// </summary>
        public Size Size { get => size; set => size = value; }

        /// <summary>
        /// Getter for the Price of the grits
        /// Will throw NotImplementedException if size is not small, medium, or large
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) return 1.22;
                else if (size == Size.Medium) return 1.58;
                else if (size == Size.Large) return 1.93;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Getter for the Calories of the grits
        /// Will throw NotImplementedException if size is not small, medium, or large
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) return 105;
                else if (size == Size.Medium) return 142;
                else if (size == Size.Large) return 179;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Getter for the SpecialInstructions List,
        /// will always return an empty List
        /// </summary>
        public List<string> SpecialInstructions { get => new List<string>(); }

        /// <summary>
        /// Override of the ToString() method
        /// </summary>
        /// <returns>The size and the name of the side</returns>
        public override string ToString()
        {
            return $"{size} Mad Otar Grits";
        }
    }
}
