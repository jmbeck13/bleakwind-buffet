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
    /// <summary>
    /// Class for representing the burger.
    /// </summary>
    public class BriarheartBurger : Entree
    {
        /// <summary>
        /// Private variable declaration for the burger.
        /// </summary>
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool bun = true;

        /// <summary>
        /// Gets the price of the burger.
        /// </summary>
        public override double Price => 6.32;

        /// <summary>
        /// Gets the calories of the burger.
        /// </summary>
        public override uint Calories => 743;

        /// <summary>
        /// Gets the calories of the burger.
        /// </summary>
        public bool Bun { get => bun; set { bun = value; InvokePropertyChangedEvent("Bun"); } }

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
            }
        }

        /// <summary>
        /// Gets/sets the mustard for the burger. 
        /// </summary>
        public bool Mustard
        {
            get => mustard;
            set { mustard = value; InvokePropertyChangedEvent("Mustard"); }
        }

        /// <summary>
        /// Gets/sets the pickles for the burger. 
        /// </summary>
        public bool Pickle
        {
            get => pickle;
            set { pickle = value; InvokePropertyChangedEvent("Pickle"); }
        }

        /// <summary>
        /// Gets/sets the cheese for the burger. 
        /// </summary
        public bool Cheese
        {
            get => cheese;
            set { cheese = value; InvokePropertyChangedEvent("Cheese"); }
        }

        /// <summary>
        /// Gets/sets the instructions for the burger. 
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Bun) instructions.Add("Hold bun");
                if (Ketchup) instructions.Add("Hold ketchup");
                if (Mustard) instructions.Add("Hold mustard");
                if (Pickle) instructions.Add("Hold pickle");
                if (Cheese) instructions.Add("Hold cheese");
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the entree. 
        /// </summary>
        /// <returns>A string describing the burger</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
