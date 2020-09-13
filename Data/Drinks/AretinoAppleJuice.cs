using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Laura Baldwin
 * Last Edited: Sept. 12th 2020
 * Class Name: AretinoAppleJuice
 * Purpose: To store information about an AretinoAppleJuice order
 */
namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class to represent an AretinoAppleJuce object
    /// </summary>
    public class AretinoAppleJuice : Drink
    {        
        /// <value>
        /// bool to store if ice was requested for this order
        /// </value>
        private bool ice = false;

        /// <summary>
        /// Getter and setter for the Ice property
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set
            {
                if (value) specialInstructions.Add("Add ice");
                else specialInstructions.Remove("Add ice");
                ice = value;
            }
        }
        /// <summary>
        /// Getter for the Price whitch returns a double
        /// </summary>
        /// <exception cref="System.NotImplementedException">Given a size not in the Size enum</exception>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 0.62;
                else if (Size == Size.Medium) return 0.87;
                else if (Size == Size.Large) return 1.01;
                else
                {
                    throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// Getter for the Calories, which returns a unsigned int
        /// </summary>
        /// <exception cref="System.NotImplementedException">Given a size not in the Size enum</exception>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) return 44;
                else if (Size == Size.Medium) return 88;
                else if (Size == Size.Large) return 132;
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        /// <value>
        /// A List of strings storing any special instructions to apply to the order
        /// </value>
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Getter for the List of specialInstructions for the order
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get 
            {
                return new List<string>(specialInstructions);
            }
        }

        /// <summary>
        /// Override of the ToString method
        /// </summary>
        /// /// <returns>The size and name of the drink</returns>
        public override string ToString()
        {
            return $"{Size} Aretino Apple Juice";
        }

    }
}
