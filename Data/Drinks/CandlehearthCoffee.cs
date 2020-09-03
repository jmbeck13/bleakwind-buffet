/*
 * Author: Jacob Beck
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent the Candlehearth Coffee drink option.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
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
                if (Size == Size.Medium) return 1.25;
                if (Size == Size.Large) return 1.75;
                return 0.75;
            }
        }

        /// <summary>
        /// Gets the calories of the drink.
        /// </summary>
        public uint Calories
        {
            get
            { 
                if (Size == Size.Medium) return 10;
                if (Size == Size.Large) return 20;
                return 7;
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
        /// Gets/sets cream for the drink.
        /// </summary>
        private bool roomForCream = false;
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }

        /// <summary>
        /// Gets/sets decaf for the drink.
        /// </summary>
        private bool decaf = false;
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }

        /// <summary>
        /// Gets the instructions for the drink. 
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Add ice");
                if (!RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the drink. 
        /// </summary>
        public override string ToString()
        {
             if (!Decaf) return Size + " Decaf Candlehearth Coffee";
             return Size + " Candlehearth Coffee";
        }
    }
}
