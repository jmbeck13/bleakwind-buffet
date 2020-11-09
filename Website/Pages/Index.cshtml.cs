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
            Entrees = Menu.Search(Menu.Entrees(), SearchTerms);
            Drinks = Menu.Search(Menu.Drinks(), SearchTerms);
            Sides = Menu.Search(Menu.Sides(), SearchTerms);

            Entrees = Menu.FilterByOrderItem(Entrees, ItemTypes);
            Drinks = Menu.FilterByOrderItem(Drinks, ItemTypes);
            Sides = Menu.FilterByOrderItem(Sides, ItemTypes);

            Entrees = Menu.FilterByCalories(Entrees, MINCal, MAXCal);
            Drinks = Menu.FilterByCalories(Drinks, MINCal, MAXCal);
            Sides = Menu.FilterByCalories(Sides, MINCal, MAXCal);

            Entrees = Menu.FilterByPrice(Entrees, MINPrice, MAXPrice);
            Drinks = Menu.FilterByPrice(Drinks, MINPrice, MAXPrice);
            Sides = Menu.FilterByPrice(Sides, MINPrice, MAXPrice);
        }
    }
}
