using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Laura Baldwin
 * Last Edited: Sept. 12th 2020
 * Class Name: CandlehearthCoffee
 * Purpose: To store information about a CandlehearthCoffee order
 */
namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee : Drink
    {
       
        /// <value>
        /// bool to store if ice is requested for the order
        /// </value>
        private bool ice = false;
        /// <summary>
        /// Getter and setter for the ice property
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
        
        /// <value>
        /// If the Coffee includes cream
        /// </value>
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

        /// <value>
        /// If the coffee is decaf
        /// </value>
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
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return .75;
                else if (Size == Size.Medium) return 1.25;
                else if (Size == Size.Large) return 1.75;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Getter for the Calories:
        /// If size is not small, medium, or large, will throw a NotImplementedEception
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) return 7;
                else if (Size == Size.Medium) return 10;
                else if (Size == Size.Large) return 20;
                else throw new NotImplementedException();
            }
        }

        /// <value>
        /// List to store the special instructions for the order
        /// </value>
        
        private List<string> specialInstructions = new List<string>();

        /// <summary>
        /// Getter for the string List of SpecialInstructions
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
        /// <returns>The size, if it's decaf or not, and name of the drink</returns>
        public override string ToString()
        {
            if (decaf) return $"{Size} Decaf Candlehearth Coffee";
            else return $"{Size} Candlehearth Coffee";
        }
    }
}
