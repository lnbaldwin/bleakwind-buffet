using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;
/*
 * Author: Laura Baldwin
 * Date Written: Aug 30th 2020
 * Class Name: DragonbornWaffleFries
 * Purpose: To store information about a DragonbornWaffleFries order
 */
namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class to describe an order of "Dragonborn Waffle Fries" aka Cajun Fries
    /// </summary>
    class DragonbornWaffleFries
    {
        private Size size = Size.Small;

        /// <summary>
        /// Getter and setter for the size of the order
        /// </summary>
        public Size Size { get => size; set => size = value; }

        /// <summary>
        /// Getter for the Price of the fries
        /// Will throw NotImplementedException if size is not small, medium, or large
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) return 0.42;
                else if (size == Size.Medium) return 0.76;
                else if (size == Size.Large) return 0.96;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Getter for the Calories of the fries
        /// Will throw NotImplementedException if size is not small, medium, or large
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) return 77;
                else if (size == Size.Medium) return 89;
                else if (size == Size.Large) return 100;
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
            return $"{size} Dragonborn Waffle Fries";
        }
    }
}
