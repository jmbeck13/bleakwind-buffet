﻿/*
 * Author: Jacob Beck
 * Class name: Drink.cs
 * Purpose: Class used to represent the base class for drinks.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of drinks
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {

        private string desc = ""; // Description backing variable

        /// <summary>
        /// Gets the description based on the type of item
        /// </summary>
        public virtual string Description
        {
            get
            {
                if (Name.Contains("Apple"))
                {
                    desc = "Fresh squeezed apple juice.";
                }
                if (Name.Contains("Sailor"))
                {
                    desc = "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";
                }
                if (Name.Contains("Milk"))
                {
                    desc = "Hormone-free organic 2% milk.";
                }
                if (Name.Contains("Coffee"))
                {
                    desc = "Fair trade, fresh ground dark roast coffee.";

                }
                if (Name.Contains("Warrior"))
                {
                    desc = "It’s water. Just water.";
                }
                return desc;
            }
        }

        public virtual string Type => "Drink";

        protected Size size = Size.Small;

        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size 
        {
            get => size;
            set
            {
                size = value;
                InvokePropertyChangedEvent("Size");
                InvokePropertyChangedEvent("Price");
                InvokePropertyChangedEvent("Calories");
                InvokePropertyChangedEvent("Name");
            }
        }

        /// <summary>
        /// A public property to get the name of the current drink item.
        /// </summary>
        public string Name
        {
            get => this.ToString();
        }

        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value>In US dollars</value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// The special instructions to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Handles property change events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Method to change the property of an item.
        /// </summary>
        /// <param name="name">The name of property we're changing</param>
        protected void InvokePropertyChangedEvent(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
