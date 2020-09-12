using System;
using System.Collections.Generic;
/*
 * Author: Laura Baldwin
 * Date Written: Aug 30th 2020
 * Class Name: ThalmorTriple
 * Purpose: To store information about a ThalmorTriple order
 */
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to describe an order of a "Thalmor Triple" aka a 1/2lb burger
    /// "Think you are strong enough to take on the Thalmor? 
    /// Inlcudes two 1/4lb patties with a 1/2lb patty inbetween 
    /// with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg."
    /// </summary>
    public class ThalmorTriple : Entree, IOrderItem
    {
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;
        private bool bacon = true;
        private bool egg = true;

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
        /// Getter and setter for the Bacon property
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set
            {
                if (value) specialInstructions.Remove("Hold bacon");
                else specialInstructions.Add("Hold bacon");
                bacon = value;
            }
        }

        /// <summary>
        /// Getter and setter for the Egg property
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set
            {
                if (value) specialInstructions.Remove("Hold egg");
                else specialInstructions.Add("Hold egg");
                egg = value;
            }
        }

        /// <summary>
        /// Getter for the price
        /// </summary>
        public override double Price { get => 8.32; }

        /// <summary>
        /// Getter for the Calories property
        /// </summary>
        public override uint Calories { get => 943; }

        private List<string> specialInstructions = new List<string>();

        /// <summary>
        /// Getter for the List of Special Instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get { return new List<string>(specialInstructions); }
        }

        /// <summary>
        /// Override of the ToString() method
        /// </summary>
        /// <returns>Name of the burger</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
