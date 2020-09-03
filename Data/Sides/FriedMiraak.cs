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
    public class FriedMiraak
    {
        /// <summary>
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
        public override string ToString()
        {
            return Size + " Fried Miraak";
        }
    }
}
