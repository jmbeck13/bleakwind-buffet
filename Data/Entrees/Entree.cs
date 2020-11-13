/*
 * Author: Jacob Beck
 * Class name: Entre.cs
 * Purpose: Class used to represent the base class for entrees.
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the properties of an entree
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {

        private string desc = ""; // Description backing variable

        /// <summary>
        /// Gets the description based on the type of item
        /// </summary>
        public virtual string Description
        {
            get
            {
                if(Name.Contains("Briarheart"))
                {
                    desc = "Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.";
                }
                if(Name.Contains("Draugr"))
                {
                    desc = "Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.";
                }
                if(Name.Contains("Thalmor"))
                {
                    desc = "Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.";
                }
                if(Name.Contains("Skeleton"))
                {
                    desc = "Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.";

                }
                if(Name.Contains("Garden"))
                {
                    desc = "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";
                }
                if(Name.Contains("Philly"))
                {
                    desc = "Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.";
                }
                if (Name.Contains("T-Bone"))
                {
                    desc = "Juicy T-Bone, not much else to say.";
                }
                return desc;
            }
        }

        public virtual string Type => "Entree";

        /// <summary>
        /// The price of the entree
        /// </summary>
        /// <value>In US dollars</value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// A public property to get the name of the current Entree item.
        /// </summary>
        public string Name
        {
            get => this.ToString();
        }

        /// <summary>
        /// The special instructions to prepare the entree
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
