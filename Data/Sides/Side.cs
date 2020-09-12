using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public abstract class Side
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
