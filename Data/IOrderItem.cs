/*
 * Author: Jacob Beck
 * Class name: IOrderItem.cs
 * Purpose: Class used to represent the interface when ordering an item.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// An interfeace representing the properties of an item when being ordered
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Gets the description of the item.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Gets the type of item the iorderitem is
        /// </summary>
        string Type { get; }

        /// <summary>
        /// The price of the item
        /// </summary>
        /// <value>In US dollars</value>
        double Price { get; }

        /// <summary>
        /// The calories of the item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// The special instructions needed when the item is ordered
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
