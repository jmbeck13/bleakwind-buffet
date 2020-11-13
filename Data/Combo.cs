/*
 * Author: Jacob Beck
 * Class name: Combo.cs
 * Purpose: Class used to represent the combos for menu items.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A class representing combo items of entrees, drinks, and sides.
    /// </summary>
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        public virtual string Description => "Combo";
        public virtual string Type => "Combo";

        public Combo(Entree o, Side s, Drink d)
        {
            this.Entree = entree;
            this.Side = s;
            this.Drink = d;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Method to change the property of an item.
        /// </summary>
        /// <param name="name">The name of property we're changing</param>
        protected void InvokePropertyChangedEvent(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        private Entree entree;

        /// <summary>
        /// An Entree item in the combo
        /// </summary>
        public Entree Entree
        {
            get => entree;
            set
            {
                entree = value;
                InvokePropertyChangedEvent("Entree");
                InvokePropertyChangedEvent("Price");
                InvokePropertyChangedEvent("Calories");
                InvokePropertyChangedEvent("SpecialInstructions");
            }
        }

        private Drink drink;

        /// <summary>
        /// A Drink item in the combo
        /// </summary>
        public Drink Drink
        {
            get => drink;
            set
            {
                drink = value;
                InvokePropertyChangedEvent("Drink");
                InvokePropertyChangedEvent("Price");
                InvokePropertyChangedEvent("Calories");
                InvokePropertyChangedEvent("SpecialInstructions");
            }
        }

        private Side side;

        /// <summary>
        /// A side item in the combo
        /// </summary>
        public Side Side
        {
            get => side;
            set
            {
                side = value;
                InvokePropertyChangedEvent("Side");
                InvokePropertyChangedEvent("Price");
                InvokePropertyChangedEvent("Calories");
                InvokePropertyChangedEvent("SpecialInstructions");
            }
        }

        /// <summary>
        /// The calories of the combo items
        /// </summary>
        public uint Calories
        {
            get
            {
                uint cal = 0;
                if (Entree != null)
                {
                    cal += Entree.Calories;
                }
                if (Drink != null)
                {
                    cal += Drink.Calories;
                }
                if (Side != null)
                {
                    cal += Side.Calories;
                }
                return cal;
            }
        }

        /// <summary>
        /// The price of the combo items
        /// </summary>
        public double Price
        {
            get
            {
                double price = 0.0;
                if (Entree != null)
                {
                    price += Entree.Price;
                }
                if (Drink != null)
                {
                    price += Drink.Price;
                }
                if (Side != null)
                {
                    price += Side.Price;
                }
                return price - 1.0;
            }
        }

        /// <summary>
        /// The items and their special instructions that are in the combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> si = new List<string>();
                si.Add(Entree.ToString());
                si.Add(Entree.SpecialInstructions.ToString());
                si.Add(Drink.ToString());
                si.Add(Drink.SpecialInstructions.ToString());
                si.Add(Side.SpecialInstructions.ToString());
                return si;
            }
        }
    }
}


    
