/*
 * Author: Jacob Beck
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the fried miraak side option.
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
    public class FriedMiraak
    {
        /// <summary>
        /// Private variable declaration for the burger.
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets/sets the size of the side.
        /// </summary>
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
                if (Size == Size.Medium) return 2.01;
                if (Size == Size.Large) return 2.88;
                return 1.78;
            }
        }

        /// <summary>
        /// Gets the calories of the side.
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Medium) return 236;
                if (Size == Size.Large) return 306;
                return 151;
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
        /// <returns>A string describing the side</returns>
        public override string ToString()
        {
            return Size + " Fried Miraak";
        }
    }
}
