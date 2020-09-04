using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;
/*
 * Author: Laura Baldwin
 * Date Written: Aug 30th 2020
 * Class Name: FriedMiraak
 * Purpose: To store information about a FriedMiraak order
 */
namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class to describe an order of "Fried Miraak" aka hash brown pancakes
    /// </summary>
    class FriedMiraak
    {
        private Size size = Size.Small;
        /// <summary>
        /// Getter and setter for the size of the order
        /// </summary>
        public Size Size { get => size; set => size = value; }

        /// <summary>
        /// Getter for the Price of the side
        /// Will throw NotImplementedException if size is not small, medium, or large
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) return 1.78;
                else if (size == Size.Medium) return 2.01;
                else if (size == Size.Large) return 2.88;
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
                if (size == Size.Small) return 151;
                else if (size == Size.Medium) return 236;
                else if (size == Size.Large) return 306;
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
            return $"{size} Fried Miraak";
        }

    }
}
