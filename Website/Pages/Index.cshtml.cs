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
        public IEnumerable<IOrderItem> Menus { get; set; }
        public string[] Types { get; set; }
        public double PriceMin { get; set; } = 0;
        public double PriceMax { get; set; } = 100;
        public uint CalMin { get; set; } = 0;
        public uint CalMax { get; set; } = 3000;

        public void OnGet()
        {
            SearchTerms = Request.Query["SearchTerms"];
            Menus = Menu.Search(SearchTerms);
            Types = Request.Query["Types"];
            string pmin = Request.Query["PriceMin"];
            string pmax = Request.Query["PriceMax"];
            string cmin = Request.Query["CalMin"];
            string cmax = Request.Query["CalMax"];
            if (!String.IsNullOrEmpty(pmin))
            {
                PriceMin = double.Parse(pmin);
            }
            if (!String.IsNullOrEmpty(pmax))
            {
                PriceMax = double.Parse(pmax);
            }

            if (!String.IsNullOrEmpty(cmin))
            {
                CalMin = uint.Parse(cmin);
            }
            if (!String.IsNullOrEmpty(cmax))
            {
               CalMax = uint.Parse(cmax);
            }

            Menus = Menu.FilterByType(Menus,Types);
            Menus = Menu.FilterByPrice(Menus, PriceMin, PriceMax);
            Menus = Menu.FilterByCal(Menus, CalMin, CalMax);
        }
    }
}
