using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Laura Baldwin
 * Date Written: Aug 30th 2020
 * Class Name: AretinoAppleJuice
 * Purpose: To store information about an AretinoAppleJuice order
 */
namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice
    {
        
        private Size size = Size.Small;
        /// <summary>
        /// Getter and setter for the Size of the AretinoAppleJuice
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        
        private bool ice = false;
        /// <summary>
        /// Getter and setter for the Ice property
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
        /// <summary>
        /// Getter for the Price:
        /// If size is not small, medium, or large, will throw a NotImplementedEception
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) return 0.62;
                else if (size == Size.Medium) return 0.87;
                else if (size == Size.Large) return 1.01;
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
                if (size == Size.Small) return 44;
                else if (size == Size.Medium) return 88;
                else if (size == Size.Large) return 132;
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Getter for the List of specialInstructions for the order
        /// </summary>
        public List<string> SpecialInstructions
        {
            get { return new List<string>(specialInstructions); }
        }

        /// <summary>
        /// Override of the ToString method
        /// </summary>
        /// /// <returns>The size and name of the drink</returns>
        public override string ToString()
        {
            return $"{size} Aretino Apple Juice";
        }

    }
}
