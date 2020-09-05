using System;
using System.Collections.Generic;
/*
 * Author: Laura Baldwin
 * Date Written: Aug 30th 2020
 * Class Name: PhillyPoacher
 * Purpose: To store information about a PhillyPoacher order
 */
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to describe an order of a "Philly Poacher" aka a philly cheesesteak sandwich
    /// "Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll."
    /// </summary>
    public class PhillyPoacher
    {
        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;

        /// <summary>
        /// Getter and setter for the Sirloin property
        /// </summary>
        public bool Sirloin
        {
            get { return sirloin; }
            set
            {
                if (value) specialInstructions.Remove("Hold sirloin");
                else specialInstructions.Add("Hold sirloin");
                sirloin = value;
            }
        }

        /// <summary>
        /// Getter and setter for the Onion property
        /// </summary>
        public bool Onion
        {
            get { return onion; }
            set
            {
                if (value) specialInstructions.Remove("Hold onion");
                else specialInstructions.Add("Hold onion");
                onion = value;
            }
        }

        /// <summary>
        /// Getter and setter for the Roll property
        /// </summary>
        public bool Roll
        {
            get { return roll; }
            set
            {
                if (value) specialInstructions.Remove("Hold roll");
                else specialInstructions.Add("Hold roll");
                roll = value;
            }
        }

        /// <summary>
        /// Getter for the Price of the sandwich
        /// </summary>
        public double Price { get => 7.23; }
        /// <summary>
        /// Getter for the Calories of the sandwich
        /// </summary>
        public uint Calories { get => 784; }

        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Getter for the List of Special Instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get { return new List<string>(specialInstructions); }
        }
        /// <summary>
        /// Override of the ToString() method
        /// </summary>
        /// <returns>Name of the sandwich</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
