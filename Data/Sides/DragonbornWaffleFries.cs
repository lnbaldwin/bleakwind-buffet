using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;
/*
 * Author: Laura Baldwin
 * Last Edited: Sept. 12th 2020
 * Class Name: DragonbornWaffleFries
 * Purpose: To store information about a DragonbornWaffleFries order
 */
namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class to describe an order of "Dragonborn Waffle Fries" aka Cajun Fries
    /// </summary>
    public class DragonbornWaffleFries : Side
    {
        /// <summary>
        /// Getter for the Price of the fries
        /// Will throw NotImplementedException if Size is not small, medium, or large
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 0.42;
                else if (Size == Size.Medium) return 0.76;
                else if (Size == Size.Large) return 0.96;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Getter for the Calories of the fries
        /// Will throw NotImplementedException if Size is not small, medium, or large
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) return 77;
                else if (Size == Size.Medium) return 89;
                else if (Size == Size.Large) return 100;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Override of the ToString() method
        /// </summary>
        /// <returns>The Size and the name of the side</returns>
        public override string ToString()
        {
            return $"{Size} Dragonborn Waffle Fries";
        }
    }
}
