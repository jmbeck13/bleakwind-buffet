﻿/*
 * Author: Jacob Beck
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent the Thalmor Triple entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for representing the burger.
    /// </summary>
    public class ThalmorTriple : Entree
    {
        /// <summary>
        /// Private variable declaration for the burger.
        /// </summary>
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;
        private bool bacon = true;
        private bool egg = true;
        private bool bun = true;

        /// <summary>
        /// Gets the price of the burger.
        /// </summary>
        public override double Price => 8.32;

        /// <summary>
        /// Gets the calories of the burger.
        /// </summary>
        public override uint Calories => 943;

        /// <summary>
        /// Gets/sets the bun for the burger.
        /// </summary>
        public bool Bun { get => bun; set { bun = value; InvokePropertyChangedEvent("Bun"); InvokePropertyChangedEvent("SpecialInstructions"); } }

        /// <summary>
        /// Gets/sets the ketchup for the burger. 
        /// </summary>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                ketchup = value; InvokePropertyChangedEvent("Ketchup");
                InvokePropertyChangedEvent("SpecialInstructions");
            }
        }

        /// <summary>
        /// Gets/sets the mustard for the burger. 
        /// </summary>
        public bool Mustard
        {
            get => mustard;
            set { mustard = value; InvokePropertyChangedEvent("Mustard"); InvokePropertyChangedEvent("SpecialInstructions"); }
        }

        /// <summary>
        /// Gets/sets the pickles for the burger. 
        /// </summary>
        public bool Pickle
        {
            get => pickle;
            set { pickle = value; InvokePropertyChangedEvent("Pickle"); InvokePropertyChangedEvent("SpecialInstructions"); }
        }

        /// <summary>
        /// Gets/sets the cheese for the burger. 
        /// </summary>
        public bool Cheese
        {
            get => cheese;
            set { cheese = value; InvokePropertyChangedEvent("Cheese"); InvokePropertyChangedEvent("SpecialInstructions"); }
        }

        /// <summary>
        /// Gets/sets the tomato for the burger. 
        /// </summary>
        public bool Tomato
        {
            get => tomato;
            set { tomato = value; InvokePropertyChangedEvent("Tomato"); InvokePropertyChangedEvent("SpecialInstructions"); }
        }

        /// <summary>
        /// Gets/sets the lettuce for the burger. 
        /// </summary>
        public bool Lettuce
        {
            get => lettuce;
            set { lettuce = value; InvokePropertyChangedEvent("Lettuce"); InvokePropertyChangedEvent("SpecialInstructions"); }
        }

        /// <summary>
        /// Gets/sets the mayo for the burger. 
        /// </summary>
        public bool Mayo
        {
            get => mayo;
            set { mayo = value; InvokePropertyChangedEvent("Mayo"); InvokePropertyChangedEvent("SpecialInstructions"); }
        }

        /// <summary>
        /// Gets/sets the bacon for the burger. 
        /// </summary>
        public bool Bacon
        {
            get => bacon;
            set { bacon = value; InvokePropertyChangedEvent("Bacon"); InvokePropertyChangedEvent("SpecialInstructions"); }
        }

        /// <summary>
        /// Gets/sets the egg for the burger. 
        /// </summary>
        public bool Egg
        {
            get => egg;
            set { egg = value; InvokePropertyChangedEvent("Egg"); InvokePropertyChangedEvent("SpecialInstructions"); }
        }

        /// <summary>
        /// Gets/sets the instructions for the burger. 
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the entree. 
        /// </summary>
        /// <returns>A string describing the burger</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
