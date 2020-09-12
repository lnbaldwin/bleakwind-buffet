using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;
/*
 * Author: Laura Baldwin
 * Date Written: Aug 30th 2020
 * Class Name: WarriorWater
 * Purpose: To store information about a WarriorWater order
 */
namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater : Drink, IOrderItem
    {
        
        private bool ice = true;
        /// <summary>
        /// Getter and setter for the Ice property
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set
            {
                if (value) specialInstructions.Remove("Hold ice");
                else specialInstructions.Add("Hold ice");
                ice = value;
            }
        }

        
        private bool lemon = false;
        /// <summary>
        /// Getter and setter for the Lemon property
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set 
            {
                if (value) specialInstructions.Add("Add lemon");
                else specialInstructions.Remove("Add lemon");
                lemon = value; 
            }
        }

        /// <summary>
        /// Getter for the Price property
        /// </summary>
        public override double Price { get { return 0; } }
        /// <summary>
        /// Getter for the Calories property
        /// </summary>
        public override uint Calories { get { return 0; } }

        
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Getter for the List of Special Instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get { return new List<string>(specialInstructions); }
        }

        /// <summary>
        /// Override of the ToString method
        /// </summary>
        /// <returns>The Size and name of the drink</returns>
        public override string ToString()
        {
            return $"{Size} Warrior Water";
        }


    }
}
