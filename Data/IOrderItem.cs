using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Laura Baldwin
 * Last Edited: Sept. 12th 2020
 * Class Name: IOrderItem.cs
 * Purpose: To be an interface implimneted by every food Class in the project that will be on the Menu
*/

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Interface to impliment in objects inheriting from the types Drink, Entree, and Side
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The Price of the OrderItem
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The Calorie count of the OrderItem
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the OrderItem
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
