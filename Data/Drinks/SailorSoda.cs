/*
 * Author: Jacob Beck
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Sailor Soda drink option.
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
    public class SailorSoda : Drink
    {

        /// <summary>
        /// Private variable declaration for the drink.
        /// </summary>
        private Size size = Size.Small;
        private bool ice = true;
        private SodaFlavor flavor = SodaFlavor.Cherry;

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
                size = value;
            }
        }

        /// <summary>
        /// Gets the price of the drink.
        /// </summary>
        public override double Price 
        {
            get
            { 
                if (Size == Size.Medium) return 1.74;
                if (Size == Size.Large) return 2.07;
                return 1.42;
            }
        }

        /// <summary>
        /// Gets the calories of the drink.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium) return 153;
                if (Size == Size.Large) return 205;
                return 117;
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
        /// Gets the price of the drink.
        /// </summary>
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value; InvokePropertyChangedEvent("Flavor");
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
                if (Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the drink. 
        /// </summary>
        /// <returns>A string describing the drink</returns>
        public override string ToString()
        {
            return Size + " " + Flavor + " Sailor Soda";
        }  
    }
}
