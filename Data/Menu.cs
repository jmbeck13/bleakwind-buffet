/*
 * Author: Jacob Beck
 * Class name: Menu.cs
 * Purpose: Class used to represent the Menu.
 */
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A public static class that represents the menu of the resturant.
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// An IEnumerable<IOrderItem> that returns all the entrees.
        /// </summary>
        /// <returns>A list of the all the available entree options</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entree = new List<IOrderItem>();
            entree.Add(new BriarheartBurger());
            entree.Add(new DoubleDraugr());
            entree.Add(new GardenOrcOmelette());
            entree.Add(new PhillyPoacher());
            entree.Add(new SmokehouseSkeleton());
            entree.Add(new ThalmorTriple());
            entree.Add(new ThugsTBone());
            return entree;
        }

        /// <summary>
        /// An IEnumerable<IOrderItem> that returns all the sides.
        /// </summary>
        /// <returns>A list of the all the available side options</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> side = new List<IOrderItem>();

            foreach(Size s in Enum.GetValues(typeof(Size)))
            {
                side.Add(new DragonbornWaffleFries()
                {
                    Size = s
                });

                side.Add(new FriedMiraak()
                {
                    Size = s
                });

                side.Add(new MadOtarGrits()
                {
                    Size = s
                });

                side.Add(new VokunSalad()
                {
                    Size = s
                });
            }
            return side;
        }

        /// <summary>
        /// An IEnumerable<IOrderItem> that returns all the drinks.
        /// </summary>
        /// <returns>A list of the available drink options</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drink = new List<IOrderItem>();

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                drink.Add(new AretinoAppleJuice()
                {
                    Size = s
                });

                drink.Add(new CandlehearthCoffee()
                {
                    Size = s,
                    Decaf = true
                });

                drink.Add(new CandlehearthCoffee()
                {
                    Size = s,
                    Decaf = false
                });

                drink.Add(new MarkarthMilk()
                {
                    Size = s
                });

                drink.Add(new WarriorWater()
                {
                    Size = s
                });

                foreach(SodaFlavor sf in Enum.GetValues(typeof(SodaFlavor)))
                {
                    drink.Add(new SailorSoda()
                    {
                        Size = s,
                        Flavor = sf
                    }) ;
                }
               
            }
            return drink;
        }

        /// <summary>
        /// An IEnumerable<IOrderItem> that returns the full menu.
        /// </summary>
        /// <returns>A list containing all of the items on the menu</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> menu = new List<IOrderItem>();
            IEnumerable<IOrderItem> entree = Entrees();
            menu.AddRange(entree);

            IEnumerable<IOrderItem> side = Sides();
            menu.AddRange(side);

            IEnumerable<IOrderItem> drink = Drinks();
            menu.AddRange(drink);

            return menu;
        }
    }
}
