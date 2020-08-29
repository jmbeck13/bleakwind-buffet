/*
 * Author: Jacob Beck
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent the vokun salad side option.
 */
using BleakwindBuffet.Data.Enums;
using Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sides
{
    public class VokunSalad
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
                if (Size == Size.Medium) return 1.28;
                if (Size == Size.Large) return 1.82;
                return 0.93;
            }
        }

        /// <summary>
        /// Gets the calories of the side.
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Medium) return 52;
                if (Size == Size.Large) return 73;
                return 41;
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
            return Size + " Vokun Salad";
        }
    }
}
