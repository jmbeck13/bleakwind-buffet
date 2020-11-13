/*
 * Author: Jacob Beck
 * Class name: Side.cs
 * Purpose: Class used to represent the base class for sides.
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing the properties of a side
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {

        private string desc = ""; // Description backing variable

        /// <summary>
        /// Gets the description based on the type of item
        /// </summary>
        public virtual string Description
        {
            get
            {
                if (Name.Contains("Salad"))
                {
                    desc = "A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.";
                }
                if (Name.Contains("Miraak"))
                {
                    desc = "Perfectly prepared hash brown pancakes.";
                }
                if (Name.Contains("Otar"))
                {
                    desc = "Cheesey Grits.";
                }
                if (Name.Contains("Waffle"))
                {
                    desc = "Crispy fried potato waffle fries.";

                }
                return desc;
            }
        }

        public virtual string Type => "Side";

        private Size size = Size.Small;
        /// <summary>
        /// The size of the side
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
        /// The price of the side
        /// </summary>
        /// <value>In US dollars</value>
        public abstract double Price { get; }

        /// <summary>
        /// A public property to get the name of the current side item.
        /// </summary>
        public string Name
        {
            get => this.ToString();
        }

        /// <summary>
        /// The calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// The special instructions to prepare the side
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
