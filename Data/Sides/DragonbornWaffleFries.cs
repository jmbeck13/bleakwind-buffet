/*
 * Author: Jacob Beck
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent the Dragonborn Waffle Fries side option.
 */
using BleakwindBuffet.Data.Enums;
using Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sides
{
    public class DragonbornWaffleFries
    {
        // <summary>
        /// Gets/sets the size of the side.
        /// </summary>
        private Size size = Size.Small;
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
        /// Gets the price of the side.
        /// </summary>
        public double Price
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
        public uint Calories
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
        public List<string> SpecialInstructions
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
        public override string ToString()
        {
            return Size + " Dragonborn Waffle Fries";
        }
    }
}
