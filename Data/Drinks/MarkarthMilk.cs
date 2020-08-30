using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Laura Baldwin
 * Date Written: Aug 28th 2020
 * Class Name: MarkarthMilk
 * Purpose: To store information about a MarkarthMilk order
 */
namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk
    {
        private bool ice = false;
        private Size size = Size.Small;

        /// <summary>
        /// Getter and setter for the ice bool:
        /// </summary>
        public bool Ice
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
        /// Getter and setter for the Size size
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
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
                if(size == Size.Small)
                {
                    return 1.05;
                }
                else if(size == Size.Medium)
                {
                    return 1.11;
                }
                else if(size == Size.Large)
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
        /// If size is not small, medium, or large, will throw a NotImplementedEception
        /// </summary>
        public uint Calories
        {
            get
            {
                if(size == Size.Small)
                {
                    return 56;
                }
                else if(size == Size.Medium)
                {
                    return 72;
                }
                else if(size == Size.Large)
                {
                    return 93;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Getter for the Special Instructions:
        /// if ice is true, will return List containing "Add Ice" 
        /// else will return an empty list
        /// </summary>
        public List<string> SpecialInstructions { get { return new List<string>(specialInstructions); } }

        /// <summary>
        /// Override the ToString method
        /// </summary>
        /// <returns>The size and name of the drink</returns>
        public override string ToString()
        {
            return $"{size} Markarth Milk";
        }
    }
}
