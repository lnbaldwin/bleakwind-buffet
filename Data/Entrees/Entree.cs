using System;
using System.Collections.Generic;
using System.Text;


/*
 * Author: Laura Baldwin
 * Last Edited: Sept. 12th 2020
 * Class Name: Entree.cs
 * Purpose: A base class with common properties shared between all Entrees
*/

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Base class for all Entree objects
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// Price of the Entree
        /// </summary>
        public abstract double Price{get; }

        /// <summary>
        /// The Calorie count of the Entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions to prepare the entree, returns an empty List
        /// </summary>
        public virtual List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }

    }
}
