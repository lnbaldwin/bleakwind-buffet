using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;
/*
 * Author: Laura Baldwin
 * Last Edited: Sept. 12th 2020
 * Class Name: VokunSalad
 * Purpose: To store information about a VokunSalad order
 */
namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class to describe an order of a "Vokun Salad" aka a fruit salad
    /// </summary>
    public class VokunSalad : Side
    {
        /// <summary>
        /// Getter for the Price of the Salad
        /// Will throw NotImplementedException if Size is not small, medium, or large
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return .93;
                else if (Size == Size.Medium) return 1.28;
                else if (Size == Size.Large) return 1.82;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Getter for the Calories of the Salad
        /// Will throw NotImplementedException if Size is not small, medium, or large
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) return 41;
                else if (Size == Size.Medium) return 52;
                else if (Size == Size.Large) return 73;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Override of the ToString() method
        /// </summary>
        /// <returns>The Size and the name of the side</returns>
        public override string ToString()
        {
            return $"{Size} Vokun Salad";
        }

    }
}
