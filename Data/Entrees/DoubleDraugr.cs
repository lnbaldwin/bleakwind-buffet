using System;
using System.Collections.Generic;
/*
 * Author: Laura Baldwin
 * Date Written: Aug 30th 2020
 * Class Name: DoubleDraugr
 * Purpose: To store information about a DoubleDraugr order
 */
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to describe an order of a "Double Draugr" aka a 1/2lb burger
    /// "Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo."
    /// </summary>
    public class DoubleDraugr
    {
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;

        /// <summary>
        /// Getter and setter for the Bun property
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set
            {
                if (value) specialInstructions.Remove("Hold bun");
                else specialInstructions.Add("Hold bun");
                bun = value;
            }
        }

        /// <summary>
        /// Getter and setter for the Ketchup property
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                if (value) specialInstructions.Remove("Hold ketchup");
                else specialInstructions.Add("Hold ketchup");
                ketchup = value;
            }
        }

        /// <summary>
        /// Getter and setter for the Mustard property
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                if (value) specialInstructions.Remove("Hold mustard");
                else specialInstructions.Add("Hold mustard");
                mustard = value;
            }
        }

        /// <summary>
        /// Getter and setter for the Pickle property
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                if (value) specialInstructions.Remove("Hold pickle");
                else specialInstructions.Add("Hold pickle");
                pickle = value;
            }
        }

        /// <summary>
        /// Getter and setter for the Cheese property
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                if (value) specialInstructions.Remove("Hold cheese");
                else specialInstructions.Add("Hold cheese");
                cheese = value;
            }
        }

        /// <summary>
        /// Getter and setter for the Tomato property
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                if (value) specialInstructions.Remove("Hold tomato");
                else specialInstructions.Add("Hold tomato");
                tomato = value;
            }
        }

        /// <summary>
        /// Getter and setter for the Lettuce property
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set
            {
                if (value) specialInstructions.Remove("Hold lettuce");
                else specialInstructions.Add("Hold lettuce");
                lettuce = value;
            }
        }

        /// <summary>
        /// Getter and setter for the Mayo property
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set
            {
                if (value) specialInstructions.Remove("Hold mayo");
                else specialInstructions.Add("Hold mayo");
                mayo = value;
            }
        }
        /// <summary>
        /// Getter for the Price of the burger
        /// </summary>
        public double Price { get => 7.32; }
        /// <summary>
        /// Getter for the Calories of the burger
        /// </summary>
        public uint Calories { get => 843; }

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
        /// <returns>Name of the burger</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
