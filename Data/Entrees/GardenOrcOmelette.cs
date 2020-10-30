/*
 * Author: Jacob Beck
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for representing the entree.
    /// </summary>
    public class GardenOrcOmelette : Entree
    {
        /// <summary>
        /// Private variable declaration for the entree.
        /// </summary>
        private bool broccoli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool cheddar = true;

        /// <summary>
        /// Gets the price of the entree.
        /// </summary>
        public override double Price => 4.57;

        /// <summary>
        /// Gets the calories of the entree.
        /// </summary>
        public override uint Calories => 404;

        /// <summary>
        /// Gets/sets the broccoli for the entree. 
        /// </summary>
        public bool Broccoli
        {
            get => broccoli;
            set { broccoli = value; InvokePropertyChangedEvent("Broccoli"); InvokePropertyChangedEvent("SpecialInstructions"); }
        }

        /// <summary>
        /// Gets/sets the mushrooms for the entree. 
        /// </summary>
        public bool Mushrooms
        {
            get => mushrooms;
            set { mushrooms = value; InvokePropertyChangedEvent("Mushrooms"); InvokePropertyChangedEvent("SpecialInstructions"); }
        }

        /// <summary>
        /// Gets/sets the tomato for the entree. 
        /// </summary>
        public bool Tomato
        {
            get => tomato;
            set { tomato = value; InvokePropertyChangedEvent("Tomato"); InvokePropertyChangedEvent("SpecialInstructions"); }
        }

        /// <summary>
        /// Gets/sets the cheddar for the entree. 
        /// </summary>
        public bool Cheddar
        {
            get => cheddar;
            set { cheddar = value; InvokePropertyChangedEvent("Cheddar"); InvokePropertyChangedEvent("SpecialInstructions"); }
        }

        /// <summary>
        /// Gets/sets the instructions for the entree. 
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }

        }

        /// <summary>
        /// ToString override for the entree. 
        /// </summary>
        /// <returns>A string describing the entree</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
