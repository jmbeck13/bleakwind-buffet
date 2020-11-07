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
    [BindProperties(SupportsGet = true)]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IEnumerable<IOrderItem> menu { get; set; } = Menu.FullMenu();

        /// <summary>
        /// Property that gets the type of Order Item.
        /// </summary>
        
        public string[] OrderItem { get; set; } = new string[0];

        /// <summary>
        /// Property to keep track of the terms that have been searched.
        /// </summary>
        public string SearchTerms { get; set; }

        public void OnGet(string SearchTerms, int? MINCal, int? MAXCal, double? MINPrice, double? MAXPrice)
        {
            menu = Menu.Search(menu, SearchTerms);
            menu = Menu.FilterByOrderItem(menu, OrderItem);
            menu = Menu.FilterByCalories(menu, MINCal, MAXCal);
            menu = Menu.FilterByPrice(menu, MINPrice, MAXPrice);
        }
    }
}
