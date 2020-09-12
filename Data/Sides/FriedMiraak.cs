using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;
/*
 * Author: Laura Baldwin
 * Date Written: Aug 30th 2020
 * Class Name: FriedMiraak
 * Purpose: To store information about a FriedMiraak order
 */
namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class to describe an order of "Fried Miraak" aka hash brown pancakes
    /// </summary>
    public class FriedMiraak : Side, IOrderItem
    {
        /// <summary>
        /// Getter for the Price of the side
        /// Will throw NotImplementedException if Size is not small, medium, or large
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 1.78;
                else if (Size == Size.Medium) return 2.01;
                else if (Size == Size.Large) return 2.88;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Getter for the Calories of the Salad
        /// Will throw NotImplementedException if Size is not small, medium, or large
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) return 151;
                else if (Size == Size.Medium) return 236;
                else if (Size == Size.Large) return 306;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Override of the ToString() method
        /// </summary>
        /// <returns>The Size and the name of the side</returns>
        public override string ToString()
        {
            return $"{Size} Fried Miraak";
        }

    }
}
