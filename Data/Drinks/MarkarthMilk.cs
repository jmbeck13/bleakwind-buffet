/*
 * Author: Jacob Beck
 * Class name: Markarth Milk.cs
 * Purpose: Class used to represent the Markarth Milk drink option.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk
    {
        /// <summary>
        /// Gets/sets the size of the drink.
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
        /// Gets the price of the drink.
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Medium) return 1.11;
                if (Size == Size.Large) return 1.22;
                return 1.05;
            }
        }

        /// <summary>
        /// Gets the calories of the drink.
        /// </summary>
        public uint Calories
        {
            get
            { 
                if (Size == Size.Medium) return 72;
                if (Size == Size.Large) return 93;
                return 56;
            }
        }


        /// <summary>
        /// Gets/sets ice for the drink.
        /// </summary>
        private bool ice = false;
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Gets the instructions for the drink. 
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the drink. 
        /// </summary>
        public override string ToString()
        {
            return Size + " Markarth Milk";
        }
    }
}

