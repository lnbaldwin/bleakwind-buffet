using System;
using System.Collections.Generic;
/*
 * Author: Laura Baldwin
 * Last Edited: Sept. 12th 2020
 * Class Name: ThugsTBone
 * Purpose: To store information about a ThugsTBone order
 */
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to describe an order of a "Thugs T-Bone" aka a T-Bone
    /// "Juicy T-Bone not much else to say"
    /// </summary>
    public class ThugsTBone : Entree
    {
        /// <summary>
        /// Getter for the Price
        /// </summary>
        public override double Price { get => 6.44; }

        /// <summary>
        /// Getter for the Calories
        /// </summary>
        public override uint Calories { get => 982; }

        /// <summary>
        /// Override of the ToString() method
        /// </summary>
        /// <returns>The name of the entree</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
