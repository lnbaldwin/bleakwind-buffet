using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;
/*
 * Author: Laura Baldwin
 * Date Written: Aug 30th 2020
 * Class Name: VokunSalad
 * Purpose: To store information about a VokunSalad order
 */
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to describe an order of a "Vokun Salad" aka a fruit salad
    /// </summary>
    class VokunSalad
    {
        private Size size = Size.Small;
        /// <summary>
        /// Getter and setter for the size of the salad
        /// </summary>
        public Size Size { get => size; set => size = value; }

        /// <summary>
        /// Getter for the Price of the Salad
        /// Will throw NotImplementedException if size is not small, medium, or large
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) return .93;
                else if (size == Size.Medium) return 1.28;
                else if (size == Size.Large) return 1.82;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Getter for the Calories of the Salad
        /// Will throw NotImplementedException if size is not small, medium, or large
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) return 41;
                else if (size == Size.Medium) return 52;
                else if (size == Size.Large) return 73;
                else throw new NotImplementedException();
            }
        }
        /// <summary>
        /// Getter for the SpecailInstructions List,
        /// will always return an empty List
        /// </summary>
        public List<string> SpecialInstructions { get => new List<string>(); }

        /// <summary>
        /// Override of the ToString() method
        /// </summary>
        /// <returns>The size and the name of the side</returns>
        public override string ToString()
        {
            return $"{size} Vokun Salad";
        }

    }
}
