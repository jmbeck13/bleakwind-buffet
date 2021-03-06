﻿/*
 * Author: Jacob Beck
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent the vokun salad side option.
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
    public class VokunSalad : Side
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
                size = value; InvokePropertyChangedEvent("Size");
            }
        }

        /// <summary>
        /// Gets the price of the side.
        /// </summary>
        public override double Price
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
        public override uint Calories
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
            return Size + " Vokun Salad";
        }
    }
}
