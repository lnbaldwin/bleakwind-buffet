using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Base class for all Entree objects
    /// </summary>
    public abstract class Entree
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
