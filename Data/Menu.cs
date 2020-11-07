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
using System.Linq;
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

        public static string[] OrderItem
        {
            get => new string[] { "Entree", "Side", "Drink",};
        }

        /// <summary>
        /// An IEnumerable<IOrderItem> that returns what the user searches for.
        /// </summary>
        /// <param name="items">Menu items</param>
        /// <param name="search">What the user entered</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> items, string search)
        {
            List<IOrderItem> menu = new List<IOrderItem>();

            if (search == null || items == null) return items;

            foreach(IOrderItem i in items)
            {
                if(i.ToString().Contains(search) && i.ToString() != null)
                {
                    menu.Add(i);
                }
            }

            return menu;
        }

        /// <summary>
        /// An IEnumerable<IOrderItem> that returns what the user searches for.
        /// </summary>
        /// <param name="items">Menu items</param>
        /// <param name="search">What the user entered</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByOrderItem(IEnumerable<IOrderItem> items, IEnumerable<string> search)
        {
            List<IOrderItem> menu = new List<IOrderItem>();

            if (search == null || search.Count() == 0) return items;

            foreach(IOrderItem i in items)
            {
                if (search.Contains("Entree") && i is Entree) menu.Add(i);

                else if (search.Contains("Drink") && i is Drink) menu.Add(i);

                else if (search.Contains("Side") && i is Side) menu.Add(i);

                else return menu;
            }

            return menu;
        }

        /// <summary>
        /// An IEnumerable<IOrderItem> that returns items that are in the calorie range the user entered
        /// </summary>
        /// <param name="items">Menu items</param>
        /// <param name="min">Min calories</param>
        /// /// <param name="max">Max calories</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max)
        {
            List<IOrderItem> menu = new List<IOrderItem>();

            // null values return all
            if (min == null && max == 0) return items;

            // only min value entered
            if(max == null)
            {
                foreach (IOrderItem i in items)
                {
                    if (i.Calories >= min) menu.Add(i);
                }

                return menu;
            }

            // only max value entered
            if (min == null)
            {
                foreach (IOrderItem i in items)
                {
                    if (i.Calories <= max) menu.Add(i);
                }

                return menu;
            }

            // both values entered
            foreach (IOrderItem i in items)
            {
                if (i.Calories <= max && i.Calories >= min) menu.Add(i);
            }

            return menu;
        }


        /// <summary>
        /// An IEnumerable<IOrderItem> that returns items that are in the calorie range the user entered
        /// </summary>
        /// <param name="items">Menu items</param>
        /// <param name="min">Min calories</param>
        /// /// <param name="max">Max calories</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            List<IOrderItem> menu = new List<IOrderItem>();

            // null values return all
            if (min == null && max == 0) return items;

            // only min value entered
            if (max == null)
            {
                foreach (IOrderItem i in items)
                {
                    if (i.Price >= min) menu.Add(i);
                }

                return menu;
            }

            // only max value entered
            if (min == null)
            {
                foreach (IOrderItem i in items)
                {
                    if (i.Price <= max) menu.Add(i);
                }

                return menu;
            }

            // both values entered
            foreach (IOrderItem i in items)
            {
                if (i.Price <= max && i.Price >= min) menu.Add(i);
            }

            return menu;
        }
    }
}
