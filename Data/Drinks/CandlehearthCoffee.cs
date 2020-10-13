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
    /// <summary>
    /// Class for representing the drink.
    /// </summary>
    public class CandlehearthCoffee : Drink
    {
        /// <summary>
        /// Private variable declaration for the drink.
        /// </summary>
        private Size size = Size.Small;
        private bool ice = false;
        private bool roomForCream = false;
        private bool decaf = false;


        /// <summary>
        /// Gets/sets the size of the drink.
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
        /// Gets the price of the drink.
        /// </summary>
        public override double Price
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
        public override uint Calories
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
        public bool Ice
        {
            get { return ice; }
            set { ice = value; InvokePropertyChangedEvent("Ice"); }
        }
        /// <summary>
        /// Gets/sets cream for the drink.
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; InvokePropertyChangedEvent("Cream"); }
        }

        /// <summary>
        /// Gets/sets decaf for the drink.
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set 
            {
                decaf = value; InvokePropertyChangedEvent("Decaf");

            }
        }

        /// <summary>
        /// Gets the instructions for the drink. 
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the drink. 
        /// </summary>
        /// <returns>A string describing the drink</returns>
        public override string ToString()
        {
            if (Decaf == true)
            {
                InvokePropertyChangedEvent("ToSting");
                return Size + " Decaf Candlehearth Coffee";
            }
            else
            {
                InvokePropertyChangedEvent("ToSting");
                return Size + " Candlehearth Coffee";
            }
        }
    }
}
