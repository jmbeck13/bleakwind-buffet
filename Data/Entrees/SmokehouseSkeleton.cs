/*
 * Author: Jacob Beck
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for representing the entree.
    /// </summary>
    public class SmokehouseSkeleton : Entree
    {
        /// <summary>
        /// Private variable declaration for the entree.
        /// </summary>
        private bool sausageLink = true;
        private bool egg = true;
        private bool hashBrowns = true;
        private bool pancake = true;

        /// <summary>
        /// Gets the price of the entree.
        /// </summary>
        public override double Price => 5.62;

        /// <summary>
        /// Gets the calories of the entree.
        /// </summary>
        public override uint Calories => 602;

        /// <summary>
        /// Gets/sets the sausage for the entree. 
        /// </summary>
        public bool SausageLink
        {
            get => sausageLink;
            set { sausageLink = value; InvokePropertyChangedEvent("SausageLinks"); InvokePropertyChangedEvent("SpecialInstructions"); }
        }

        /// <summary>
        /// Gets/sets the eggs for the entree. 
        /// </summary>
        public bool Egg
        {
            get => egg;
            set { egg = value; InvokePropertyChangedEvent("Egg"); InvokePropertyChangedEvent("SpecialInstructions"); }
        }

        /// <summary>
        /// Gets/sets the hash browns for the entree. 
        /// </summary>
        public bool HashBrowns
        {
            get => hashBrowns;
            set { hashBrowns = value; InvokePropertyChangedEvent("HashBrowns"); InvokePropertyChangedEvent("SpecialInstructions"); }
        }

        /// <summary>
        /// Gets/sets the pancakes for the entree. 
        /// </summary>
        public bool Pancake
        {
            get => pancake;
            set { pancake = value; InvokePropertyChangedEvent("Pancake"); InvokePropertyChangedEvent("SpecialInstructions"); }
        }

        /// <summary>
        /// Gets/sets the instructions for the entree. 
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (SausageLink) instructions.Add("Hold sausage");
                if (Egg) instructions.Add("Hold eggs");
                if (HashBrowns) instructions.Add("Hold hash browns");
                if (Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the entree. 
        /// </summary>
        /// <returns>A string describing the entree</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
