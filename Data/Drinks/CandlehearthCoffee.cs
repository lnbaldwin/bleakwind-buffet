﻿using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Laura Baldwin
 * Date Written: Aug 30th 2020
 * Class Name: CandlehearthCoffee
 * Purpose: To store information about a CandlehearthCoffee order
 */
namespace BleakwindBuffet.Data.Drinks
{
    class CandlehearthCoffee
    {
       
        private Size size = Size.Small;
        /// <summary>
        /// Getter for the size
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        
        private bool ice = false;
        /// <summary>
        /// Getter and setter for the ice property
        /// </summary>
        public bool Ice 
        {
            get { return ice; }
            set 
            {
                if (value) specialInstructions.Add("Add ice");
                else specialInstructions.Remove("Add ice");
                ice = value; 
            }
        }
        
        private bool roomForCream = false;
        /// <summary>
        /// Getter and setter for the roomForCream property
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }
            set
            {
                if (value) specialInstructions.Add("Add cream");
                else specialInstructions.Remove("Add cream");
                roomForCream = value;
            }
        }

        
        private bool decaf = false;
        /// <summary>
        /// Getter and setter for the decaf property
        /// Don't add to specialInstructions, but used in the ToString()
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
            }
        }


        /// <summary>
        /// Getter for the Price:
        /// If size is not small, medium, or large, will throw a NotImplementedEception
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) return .75;
                else if (size == Size.Medium) return 1.25;
                else if (size == Size.Large) return 1.75;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Getter for the Calories:
        /// If size is not small, medium, or large, will throw a NotImplementedEception
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) return 7;
                else if (size == Size.Medium) return 10;
                else if (size == Size.Large) return 20;
                else throw new NotImplementedException();
            }
        }

        
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Getter for the string List of SpecialInstructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                return new List<string>(specialInstructions);
            }
        }
        /// <summary>
        /// Override of the ToString method
        /// </summary>
        /// <returns>The size, if it's decaf or not, and name of the drink</returns>
        public override string ToString()
        {
            if (decaf) return $"{size} Decaf Candlehearth Coffee";
            else return $"{size} Candlehearth Coffee";
        }
    }
}
