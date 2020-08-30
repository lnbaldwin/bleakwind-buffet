using System;
using System.Collections.Generic;
/*
 * Author: Laura Baldwin
 * Date Written: Aug 30th 2020
 * Class Name: BriarheartBurger
 * Purpose: To store information about a BriarheartBurger order
 */
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to describe an order of a "Briarheart Burger" aka a 1/4lb burger
    /// "Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese."
    /// </summary>
    class BriarheartBurger
    {
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;

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
        /// Getter for the Price property
        /// </summary>
        public double Price { get => 6.32; }

        /// <summary>
        /// Getter for the Calories property
        /// </summary>
        public uint Calories { get => 743; }

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
            return "Briarheart Burger";
        }
    }
}
