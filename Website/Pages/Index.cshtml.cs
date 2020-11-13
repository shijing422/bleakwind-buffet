using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
/*
* Author: Shijing Zhang
* Class name: index.cshtml.cs
* Purpose: Class used to represent the IndexModel
*/
namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        /// <value>
        /// A string represent the Search Terms 
        /// </value>
        public string SearchTerms { get; set; }
        /// <value>
        /// A IEnumerable<IOrderItem> list represent the menu items
        /// </value>
        public IEnumerable<IOrderItem> Menus { get; set; }
        /// <value>
        /// A string[] list represent the selected type
        /// </value>
        public string[] Types { get; set; }
        /// <value>
        /// A string[] list represent the terms from SearchTerms in case multiple search terms are included
        /// </value>
        public string[] SearchTermArray { get; set; }
        /// <value>
        /// The min value of price to filter
        /// </value>
        public double PriceMin { get; set; } = 0;
        /// <value>
        /// The max value of price to filter
        /// </value>
        public double PriceMax { get; set; } = 100;
        /// <value>
        /// The min value of calories to filter
        /// </value>
        public uint CalMin { get; set; } = 0;
        /// <value>
        /// The max value of calories to filter
        /// </value>
        public uint CalMax { get; set; } = 3000;


        public void OnGet()
        {
            SearchTerms = Request.Query["SearchTerms"];
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

            if (!String.IsNullOrEmpty(SearchTerms))
            {
                SearchTermArray = SearchTerms.ToLower().Split(' ');
            }

            Menus = Menu.FullMenu();
            //Filter by SearchTerms
            if(SearchTermArray != null && SearchTermArray.Length != 0)
            {
                Menus = Menus.Where(IOrderItem=> SearchTermArray.Any(IOrderItem.ToString().ToLower().Contains) || SearchTermArray.Any(IOrderItem.Description.ToLower().Contains));

            }
        





            //Menus = Menu.FilterByType(Menus,Types);
            //Filter by type
            if(Types != null && Types.Length != 0)
            {
                if (!(Types.Contains("Entree")))
                {
                    Menus = Menus.Where(IOrderItem => !(IOrderItem is Entree));

                }
                if (!(Types.Contains("Side")))
                {
                    Menus = Menus.Where(IOrderItem => !(IOrderItem is Side));

                }
                if (!(Types.Contains("Drink")))
                {
                    Menus = Menus.Where(IOrderItem => !(IOrderItem is Drink));

                }
            }







            //Menus = Menu.FilterByPrice(Menus, PriceMin, PriceMax);
            //Filter by Price
            Menus = Menus.Where(IOrderItem => IOrderItem.Price <= PriceMax && IOrderItem.Price >= PriceMin);
            //Menus = Menu.FilterByCal(Menus, CalMin, CalMax);
            //Folter by Calories
            Menus = Menus.Where(IOrderItem => IOrderItem.Calories <= CalMax && IOrderItem.Calories >= CalMin);
        }
    }
}
