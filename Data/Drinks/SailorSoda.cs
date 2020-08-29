/*
 * Author: Jacob Beck
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Sailor Soda drink option.
 */
using BleakwindBuffet.Data.Enums;
using Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drinks
{
    public class SailorSoda
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
                if (Size == Size.Medium) return 1.74;
                if (Size == Size.Large) return 2.07;
                return 1.42;
            }
        }

        /// <summary>
        /// Gets the calories of the drink.
        /// </summary>
        public uint Calories
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
        private bool ice = true;
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Gets the price of the drink.
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }

        /// <summary>
        /// Gets the instructions for the drink. 
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the drink. 
        /// </summary>
        public override string ToString()
        {
            return Size + " " + Flavor + " Sailor Soda";
        }  
    }
}
