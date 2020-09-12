using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Laura Baldwin
 * Date Written: Aug 28th 2020
 * Class Name: SailorSoda
 * Purpose: To store information about a SailorSoda order
 */

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing an order for "Sailor Soda" aka old-fashioned soda
    /// </summary>
    public class SailorSoda : Drink, IOrderItem
    {
        private bool ice = true;
        private SodaFlavor flavor = SodaFlavor.Cherry;

        /// <summary>
        /// Getter and Setter for the ice bool
        /// </summary>
        public override bool Ice
        {
            get
            {
                
                return ice;
            }
            set
            {
                if (value) specialInstructions.Remove("Hold ice");
                else specialInstructions.Add("Hold ice");
                ice = value;
            }
        }

        /// <summary>
        /// Getter and Setter for the SodaFlavor enum flavor
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }
        /// <summary>
        /// Getter for the Price:
        /// If Size is not small, medium, or large, will throw a NotImplementedEception
        /// </summary>
        public override double Price 
        { 
            get
            {
                if (Size == Size.Small)
                {
                    return 1.42;
                }
                else if (Size == Size.Medium)
                {
                    return 1.74;
                }
                else if(Size == Size.Large)
                {
                    return 2.07;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        ///Getter for the Calories:
        /// If Size is not small, medium, or large, will throw a NotImplementedEception
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 117;
                }
                else if (Size == Size.Medium)
                {
                    return 153;
                }
                else if (Size == Size.Large)
                {
                    return 205;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Getter for the List of SpecialInstructions, which is initalized as a new List of strings
        /// </summary>
        public override List<string> SpecialInstructions { get { return new List<string>(specialInstructions); } }


        /// <summary>
        /// Override of the ToString() method.
        /// </summary>
        /// <returns>The Size, flavor, and name of the drink</returns>/// <returns></returns>
        public override string ToString()
        {
            return $"{Size} {flavor} Sailor Soda";
        }
    }
}
