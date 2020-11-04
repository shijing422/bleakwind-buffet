using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public string SearchTerms { get; set; }
        public IEnumerable<IOrderItem> Entrees { get; set; }
        public IEnumerable<IOrderItem> Drinks { get; set; }
        public IEnumerable<IOrderItem> Sides { get; set; }
        public void OnGet()
        {
            SearchTerms = Request.Query["SearchTerms"];
            Entrees = Menu.SearchEntrees(SearchTerms);
            Drinks = Menu.SearchDrinks(SearchTerms);
            Sides = Menu.SearchSides(SearchTerms);
        }
    }
}
