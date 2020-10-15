/*
 * Author: Jacob Beck
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent the Aretino Apple Juice drink option.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for representing the drink.
    /// </summary>
    public class AretinoAppleJuice : Drink
    {

        /// <summary>
        /// Private variable declaration for the drink.
        /// </summary>
        private Size size = Size.Small;
        private bool ice = false;


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
                size = value; InvokePropertyChangedEvent("Size"); InvokePropertyChangedEvent("Name");
            }
        }

        /// <summary>
        /// Gets the price of the drink.
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Medium) return 0.87;
                if (Size == Size.Large) return 1.01;
                return 0.62;
            }
        }

        /// <summary>
        /// Gets the calories of the drink.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium) return 88;
                if (Size == Size.Large) return 132;
                return 44;
            }
        }


        /// <summary>
        /// Gets/sets ice for the drink.
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set 
            { 
                ice = value;
                InvokePropertyChangedEvent("Ice");
                InvokePropertyChangedEvent("SpecialInstructions");
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
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the drink. 
        /// </summary>
        /// <returns>A string describing the drink</returns>
        public override string ToString()
        {
            return Size + " Aretino Apple Juice";
        }
    }
}
