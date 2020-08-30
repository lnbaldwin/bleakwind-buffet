using System;
using System.Collections.Generic;
/*
 * Author: Laura Baldwin
 * Date Written: Aug 30th 2020
 * Class Name: ThugsTBone
 * Purpose: To store information about a ThugsTBone order
 */
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to describe an order of a "Thugs T-Bone" aka a T-Bone
    /// "Juicy T-Bone not much else to say"
    /// </summary>
    class ThugsTBone
    {
        /// <summary>
        /// Getter for the Price
        /// </summary>
        public double Price { get => 6.44; }

        /// <summary>
        /// Getter for the Calories
        /// </summary>
        public uint Calories { get => 982; }

        /// <summary>
        /// Getter for the SpecialInstructions
        /// Will always return an empty list.
        /// </summary>
        public List<string> SpecialInstructions { get => new List<string>(); }

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
