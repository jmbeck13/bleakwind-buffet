﻿/*
 * Author: Jacob Beck
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the warrior water drink option.
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
    public class WarriorWater : Drink
    {
        /// <summary>
        /// Private variable declaration for the drink.
        /// </summary>
        private Size size = Size.Small;
        private bool ice = true;
        private bool lemon = false;

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
                return 0;
            }
        }

        /// <summary>
        /// Gets the calories of the drink.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;  
            }
        }

        /// <summary>
        /// Gets/sets ice for the drink.
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; InvokePropertyChangedEvent("Ice"); InvokePropertyChangedEvent("SpecialInstructions"); }
        }

        /// <summary>
        /// Gets/sets lemon for the drink.
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; InvokePropertyChangedEvent("Lemon"); InvokePropertyChangedEvent("SpecialInstructions"); }
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
                if (Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the drink. 
        /// </summary>
        /// <returns>A string describing the drink</returns>
        public override string ToString()
        {
            return Size + " Warrior Water";
        }
    }
}
