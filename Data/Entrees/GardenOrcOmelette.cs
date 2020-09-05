using System;
using System.Collections.Generic;
/*
 * Author: Laura Baldwin
 * Date Written: Aug 30th 2020
 * Class Name: GardenOrcOmelette
 * Purpose: To store information about a GardenOrcOmelette order
 */
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to describe an order of a "Garden Orc Omelette" aka a vegetarian omlette
    /// "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. 
    /// Topped with cheddar cheese."
    /// </summary>
    public class GardenOrcOmelette
    {
        private bool broccoli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool cheddar = true;

        /// <summary>
        /// Getter and setter for the Broccoli property
        /// </summary>
        public bool Broccoli
        {
            get { return broccoli; }
            set
            {
                if (value) specialInstructions.Remove("Hold broccoli");
                else specialInstructions.Add("Hold broccoli");
                broccoli = value;
            }
        }

        /// <summary>
        /// Getter and setter for the Mushrooms property
        /// </summary>
        public bool Mushrooms
        {
            get { return mushrooms; }
            set
            {
                if (value) specialInstructions.Remove("Hold mushrooms");
                else specialInstructions.Add("Hold mushrooms");
                mushrooms = value;
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
        /// Getter and setter for the Cheddar property
        /// </summary>
        public bool Cheddar
        {
            get { return cheddar; }
            set
            {
                if (value) specialInstructions.Remove("Hold cheddar");
                else specialInstructions.Add("Hold cheddar");
                cheddar = value;
            }
        }
        /// <summary>
        /// Getter for the Price property
        /// </summary>
        public double Price { get => 4.57; }

        /// <summary>
        /// Getter for the Calories Property
        /// </summary>
        public uint Calories { get => 404; }

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
            return "Garden Orc Omelette";
        }
    }
}
