/* Jacob Beck
 * Index.cshtml.cs
 * Purpose: Class used to be the page model for the razor page Index
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Property for min cal.
        /// </summary>
        public double? MINPrice { get; set; }

        /// <summary>
        /// Property for max price.
        /// </summary>
        public double? MAXPrice { get; set; }

        /// <summary>
        /// Property for min cal.
        /// </summary>
        public int? MINCal { get; set; }

        /// <summary>
        /// Property for max cal.
        /// </summary>
        public int? MAXCal { get; set; }

        /// <summary>
        /// A list of all entrees.
        /// </summary>
        public IEnumerable<IOrderItem> Entrees { get; set; } = Menu.Entrees();

        /// <summary>
        /// A list of all sides.
        /// </summary>
        public IEnumerable<IOrderItem> Sides { get; set; } = Menu.Sides();

        /// <summary>
        /// A list of all drinks.
        /// </summary>
        public IEnumerable<IOrderItem> Drinks { get; set; } = Menu.Drinks();

        /// <summary>
        /// Property that gets the type of Order Item.
        /// </summary>
        public string[] ItemTypes { get; set; } = new string[0];

        /// <summary>
        /// Property to keep track of the terms that have been searched.
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// On get method that controls the filters/searches
        /// </summary>
        /// <param name="SearchTerms">words the user entered</param>
        /// <param name="ItemTypes">type of item</param>
        /// <param name="MINCal">min cal</param>
        /// <param name="MAXCal">max cal</param>
        /// <param name="MINPrice">min price</param>
        /// <param name="MAXPrice">max price</param>
        public void OnGet(string SearchTerms, string[] ItemTypes, int? MINCal, int? MAXCal,
                          double? MINPrice, double? MAXPrice)
        {
            // Search menu item names for the SearchTerms
            if(SearchTerms != null)
            {
               Entrees = Entrees.Where(entree => entree.ToString() != null && entree.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
               Drinks = Drinks.Where(drink => drink.ToString() != null && drink.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
               Sides = Sides.Where(side => side.ToString() != null && side.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
            }

            // Filter by ItemType
            if (ItemTypes != null && ItemTypes.Length != 0)
            {
                Entrees = Entrees.Where(entree =>
                    entree.Type != null &&
                    ItemTypes.Contains(entree.Type)
                    );

                Drinks = Drinks.Where(drink =>
                    drink.Type != null &&
                    ItemTypes.Contains(drink.Type)
                    );

                Sides = Sides.Where(side =>
                   side.Type != null &&
                   ItemTypes.Contains(side.Type)
                   );
            }

            // Filter by Calories
            if (MINCal != null && MAXCal != null)
            {
                Entrees = Entrees.Where(entree => entree.Calories >= MINCal && entree.Calories <= MAXCal);
                Drinks = Drinks.Where(drink => drink.Calories >= MINCal && drink.Calories <= MAXCal);
                Sides = Sides.Where(side => side.Calories >= MINCal && side.Calories <= MAXCal);
            }
            else if (MINCal != null)
            {
                Entrees = Entrees.Where(entree => entree.Calories >= MINCal);
                Sides = Sides.Where(side => side.Calories >= MINCal);
                Drinks = Drinks.Where(drink => drink.Calories >= MINCal);
            }
            else if (MAXCal != null)
            {
                Entrees = Entrees.Where(entree => entree.Calories <= MAXCal);
                Drinks = Drinks.Where(drink => drink.Calories <= MAXCal);
                Sides = Sides.Where(side => side.Calories <= MAXCal);
            }
            else
            {
                Entrees = Menu.FilterByCalories(Entrees, MINCal, MAXCal);
                Drinks = Menu.FilterByCalories(Drinks, MINCal, MAXCal);
                Sides = Menu.FilterByCalories(Sides, MINCal, MAXCal);
            }

            // Filter by Price
            if (MINPrice != null && MAXPrice != null)
            {
                Entrees = Entrees.Where(entree => entree.Price >= MINPrice && entree.Price <= MAXPrice);
                Drinks = Drinks.Where(drink => drink.Price >= MINPrice && drink.Price <= MAXPrice);
                Sides = Sides.Where(side => side.Price >= MINPrice && side.Price <= MAXPrice);
            }
            else if (MINPrice != null)
            {
                Entrees = Entrees.Where(entree => entree.Price >= MINPrice);
                Sides = Sides.Where(side => side.Price >= MINPrice);
                Drinks = Drinks.Where(drink => drink.Price >= MINPrice);
            }
            else if (MAXPrice != null)
            {
                Entrees = Entrees.Where(entree => entree.Price <= MAXPrice);
                Drinks = Drinks.Where(drink => drink.Price <= MAXPrice);
                Sides = Sides.Where(side => side.Price <= MAXPrice);
            }
            else
            {
                Entrees = Menu.FilterByPrice(Entrees, MINPrice, MAXPrice);
                Drinks = Menu.FilterByPrice(Drinks, MINPrice, MAXPrice);
                Sides = Menu.FilterByPrice(Sides, MINPrice, MAXPrice);
            }
        }
    }
}
