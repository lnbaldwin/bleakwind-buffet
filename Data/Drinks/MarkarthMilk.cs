using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Laura Baldwin
 * Last Edited: Sept. 12th 2020
 * Class Name: MarkarthMilk
 * Purpose: To store information about a MarkarthMilk order
 */
namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk : Drink
    {
        /// <value>
        /// If the order needs ice or not
        /// </value>
        private bool ice = false;

        /// <summary>
        /// Getter and setter for the ice bool:
        /// </summary>
        public override bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                if (value) specialInstructions.Add("Add ice");
                else specialInstructions.Remove("Add ice");
                ice = value;
            }
        }

        /// <summary>
        /// Getter for the Price:
        /// If Size is not small, medium, or large, will throw a NotImplementedEception
        /// </summary>
        public override double Price
        {
            get
            {
                if(Size == Size.Small)
                {
                    return 1.05;
                }
                else if(Size == Size.Medium)
                {
                    return 1.11;
                }
                else if(Size == Size.Large)
                {
                    return 1.22;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Getter for the Calories:
        /// If Size is not small, medium, or large, will throw a NotImplementedEception
        /// </summary>
        public override uint Calories
        {
            get
            {
                if(Size == Size.Small)
                {
                    return 56;
                }
                else if(Size == Size.Medium)
                {
                    return 72;
                }
                else if(Size == Size.Large)
                {
                    return 93;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// List to store any Special Instructions for the order
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Getter for the Special Instructions:
        /// if ice is true, will return List containing "Add Ice" 
        /// else will return an empty list
        /// </summary>
        public override List<string> SpecialInstructions { get { return new List<string>(specialInstructions); } }

        /// <summary>
        /// Override the ToString method
        /// </summary>
        /// <returns>The Size and name of the drink</returns>
        public override string ToString()
        {
            return $"{Size} Markarth Milk";
        }
    }
}
