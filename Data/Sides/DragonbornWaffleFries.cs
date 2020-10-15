/*
 * Author: Jacob Beck
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent the Dragonborn Waffle Fries side option.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class for representing the side.
    /// </summary>
    public class DragonbornWaffleFries : Side
    {
        /// <summary>
        /// Private variable declaration for the burger.
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets/sets the size of the side.
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value; InvokePropertyChangedEvent("Size"); InvokePropertyChangedEvent("Name");
            }
        }

        /// <summary>
        /// Gets the price of the side.
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Medium) return 0.76;
                if (Size == Size.Large) return 0.96;
                return 0.42;
            }
        }

        /// <summary>
        /// Gets the calories of the side.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium) return 89;
                if (Size == Size.Large) return 100;
                return 77;
            }
        }

        /// <summary>
        /// Gets the instructions for the side. 
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the side. 
        /// </summary>
        /// <returns>A string describing the side</returns>
        public override string ToString()
        {
            return Size + " Dragonborn Waffle Fries";
        }
    }
}
