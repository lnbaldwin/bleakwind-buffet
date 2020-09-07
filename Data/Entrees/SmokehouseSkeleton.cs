using System;
using System.Collections.Generic;
/*
 * Author: Laura Baldwin
 * Date Written: Aug 30th 2020
 * Class Name: SmokehouseSkeleton
 * Purpose: To store information about a SmokehouseSkeleton order
 */
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to describe an order of a "Smokehouse Skeleton" aka the breakfast combo
    /// "Put some meat on those bones with a small stack of pancakes. 
    /// Includes sausage links, eggs, and hash browns on the side. 
    /// Topped with the syrup of your choice."
    /// </summary>
    public class SmokehouseSkeleton
    {
        private bool sausageLink = true;
        private bool egg = true;
        private bool hashBrowns = true;
        private bool pancake = true;

        /// <summary>
        /// Getter and setter for the SausageLink property
        /// </summary>
        public bool SausageLink
        {
            get { return sausageLink; }
            set
            {
                if (value) specialInstructions.Remove("Hold sausage");
                else specialInstructions.Add("Hold sausage");
                sausageLink = value;
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
                if (value) specialInstructions.Remove("Hold eggs");
                else specialInstructions.Add("Hold eggs");
                egg = value;
            }
        }

        /// <summary>
        /// Getter and setter for the HashBrowns property
        /// </summary>
        public bool HashBrowns
        {
            get { return hashBrowns; }
            set
            {
                if (value) specialInstructions.Remove("Hold hash browns");
                else specialInstructions.Add("Hold hash browns");
                hashBrowns = value;
            }
        }

        /// <summary>
        /// Getter and setter for the Pancake property
        /// </summary>
        public bool Pancake
        {
            get { return pancake; }
            set
            {
                if (value) specialInstructions.Remove("Hold pancakes");
                else specialInstructions.Add("Hold pancakes");
                pancake = value;
            }
        }

        /// <summary>
        /// Getter for the Price property
        /// </summary>
        public double Price { get => 5.62; }

        /// <summary>
        /// Getter for the Calories Property
        /// </summary>
        public uint Calories { get => 602; }

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
        /// <returns>Name of the entree</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
