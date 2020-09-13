using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;
/*
 * Author: Laura Baldwin
 * Last Edited: Sept. 12th 2020
 * Class Name: MadOtarGrits
 * Purpose: To store information about a MadOtarGrits order
 */
namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class to describe an order of a "Mad Otar Grits" aka cheesy grits
    /// </summary>
    public class MadOtarGrits : Side
    {
        /// <summary>
        /// Getter for the Price of the grits
        /// Will throw NotImplementedException if Size is not small, medium, or large
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 1.22;
                else if (Size == Size.Medium) return 1.58;
                else if (Size == Size.Large) return 1.93;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Getter for the Calories of the grits
        /// Will throw NotImplementedException if Size is not small, medium, or large
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) return 105;
                else if (Size == Size.Medium) return 142;
                else if (Size == Size.Large) return 179;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Override of the ToString() method
        /// </summary>
        /// <returns>The Size and the name of the side</returns>
        public override string ToString()
        {
            return $"{Size} Mad Otar Grits";
        }
    }
}
