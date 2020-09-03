/*
 * Author: Jacob Beck
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the Briarheart Burger entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger
    {
        /// <summary>
        /// Gets the price of the burger.
        /// </summary>
        public double Price => 6.32;

        /// <summary>
        /// Gets the calories of the burger.
        /// </summary>
        public uint Calories => 743;

        /// <summary>
        /// Gets the calories of the burger.
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Gets/sets the ketchup for the burger. 
        /// </summary>
        private bool ketchup = true;
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                ketchup = value;
            }
        }

        /// <summary>
        /// Gets/sets the mustard for the burger. 
        /// </summary>
        private bool mustard = true;
        public bool Mustard
        {
            get => mustard;
            set => mustard = value;
        }

        /// <summary>
        /// Gets/sets the pickles for the burger. 
        /// </summary>
        private bool pickle = true;
        public bool Pickle
        {
            get => pickle;
            set => pickle = value;
        }

        /// <summary>
        /// Gets/sets the cheese for the burger. 
        /// </summary
        private bool cheese = true;
        public bool Cheese
        {
            get => cheese;
            set => cheese = value;
        }

        /// <summary>
        /// Gets/sets the instructions for the burger. 
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                return instructions;
            }

        }

        /// <summary>
        /// ToString override for the entree. 
        /// </summary>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
