using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
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
