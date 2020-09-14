/*
 * Author: Jacob Beck
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly Poacher entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for representing the entree.
    /// </summary>
    public class PhillyPoacher : Entree
    {
        /// <summary>
        /// Private variable declaration for the entree.
        /// </summary>
        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;

        /// <summary>
        /// Gets the price of the entree.
        /// </summary>
        public override double Price => 7.23;

        /// <summary>
        /// Gets the calories of the entree.
        /// </summary>
        public override uint Calories => 784;

        /// <summary>
        /// Gets/sets the sirloin for the entree. 
        /// </summary>
        public bool Sirloin
        {
            get => sirloin;
            set => sirloin = value;
        }

        /// <summary>
        /// Gets/sets the onion for the entree. 
        /// </summary>
        public bool Onion
        {
            get => onion;
            set => onion = value;
        }

        /// <summary>
        /// Gets/sets the roll for the entree. 
        /// </summary>
        public bool Roll
        {
            get => roll;
            set => roll = value;
        }

        /// <summary>
        /// Gets/sets the instructions for the entree. 
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Sirloin) instructions.Add("Hold sirloin");
                if (Onion) instructions.Add("Hold onions");
                if (Roll) instructions.Add("Hold roll");
                return instructions;
            }

        }

        /// <summary>
        /// ToString override for the entree. 
        /// </summary>
        /// <returns>A string describing the entree</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
