using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of a Drink
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// The Size of the Drink
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// If the Drink contains Ice
        /// </summary>
        public abstract bool Ice { get; set; }
        /// <summary>
        /// The Price of the Drink
        /// </summary>
        /// <value>In US dollars</value>
        public abstract double Price { get; }
        /// <summary>
        /// The Calorie count of the Drink 
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Special instructions to prepare the Drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

    }
}
