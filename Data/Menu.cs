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

        /// <summary>
        /// Potential types of items.
        /// </summary>
        public static string[] ItemTypes
        {
            get => new string[] { "Entree", "Side", "Drink"};
        }

        /// <summary>
        /// Gets all the items that are on the menu.
        /// </summary>
        public static IEnumerable<IOrderItem> ReturnFullMenu { get { return FullMenu(); } }

        /// <summary>
        /// An IEnumerable<IOrderItem> that returns what the user searches for.
        /// </summary>
        /// <param name="items">Menu items</param>
        /// <param name="search">What the user entered</param>
        /// <returns>List that comes back with the items that fit the search criteria</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> items, string search)
        {
            List<IOrderItem> menu = new List<IOrderItem>();

            if (search == null ) return ReturnFullMenu;

            foreach(IOrderItem i in ReturnFullMenu)
            {
                if(i.ToString().ToLower().Contains(search.ToLower()))
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
        /// <returns>List with the filtered menu items</returns>
        public static IEnumerable<IOrderItem> FilterByOrderItem(IEnumerable<IOrderItem> items, IEnumerable<string> search)
        {
            if (search == null || search.Count() == 0) return items;

            List<IOrderItem> menu = new List<IOrderItem>();

            foreach (IOrderItem i in items)
            {
                if (search.Contains(i.Type) && i.Type != null) menu.Add(i);
            }

            return menu;
        }

        /// <summary>
        /// An IEnumerable<IOrderItem> that returns items that are in the calorie range the user entered
        /// </summary>
        /// <param name="items">Menu items</param>
        /// <param name="min">Min calories</param>
        /// /// <param name="max">Max calories</param>
        /// <returns>List that fits the filtered calories</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max)
        {
            // null values return all
            if (min == null && max == null) return items;

            var menu = new List<IOrderItem>();

            // only min value entered
            if (max == null)
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
        /// <returns>List that fits in the filtered price range</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            // null values return all
            if (min == null && max == null) return items;

           var menu = new List<IOrderItem>();


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
