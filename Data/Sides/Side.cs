using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

/*
 * Author: Laura Baldwin
 * Last Edited: Sept. 12th 2020
 * Class Name: Side.cs
 * Purpose: A base class with common properties shared between all Sides
*/

namespace BleakwindBuffet.Data.Sides
{
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// The Size of the Side order
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// The Price of the Side order
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// The Calorie count of the Side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions for the side order
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
