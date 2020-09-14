/*
 * Author: Jacob Beck
 * Class name: Entre.cs
 * Purpose: Class used to represent the base class for entrees.
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the properties of an entree
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        /// <value>In US dollars</value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// The special instructions to prepare the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
