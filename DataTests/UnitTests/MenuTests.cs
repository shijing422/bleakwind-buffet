using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Entrees;
using Xunit;
using System.Linq;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests
{
    /// <summary>
    /// unit text for menu.cs
    /// </summary>
    public class MenuTests
    {
        [Fact]
        public void MenuReturnALlEntree()
        {

            IEnumerable<IOrderItem> result = Menu.Entrees();


            Assert.Contains(result, (item) => { return item.ToString().Equals("Briarheart Burger"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Double Draugr"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Garden Orc Omelette"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Smokehouse Skeleton"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Thugs T-Bone"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Thalmor Triple"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Philly Poacher"); });



            

        }
        [Fact]
        public void MenuReturnALLSides()
        {
            IEnumerable<IOrderItem> result = Menu.Sides();
            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Vokun Salad"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Vokun Salad"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Vokun Salad"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Dragonborn Waffle Fries"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Fried Miraak"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Fried Miraak"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Fried Miraak"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Mad Otar Grits"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Mad Otar Grits"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Mad Otar Grits"); });



        }
        [Fact]
        public void ShouldReturnAllDrinks()
        {
            IEnumerable<IOrderItem> result = Menu.Drinks();
            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Aretino Apple Juice"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Aretino Apple Juice"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Aretino Apple Juice"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Candlehearth Coffee"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Candlehearth Coffee"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Candlehearth Coffee"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Decaf Candlehearth Coffee"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Decaf Candlehearth Coffee"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Decaf Candlehearth Coffee"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Markarth Milk"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Markarth Milk"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Markarth Milk"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Warrior Water"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Warrior Water"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Cherry Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Cherry Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Cherry Sailor Soda"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Blackberry Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Blackberry Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Blackberry Sailor Soda"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Grapefruit Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Grapefruit Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Grapefruit Sailor Soda"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Lemon Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Lemon Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Lemon Sailor Soda"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Peach Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Peach Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Peach Sailor Soda"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Watermelon Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Watermelon Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Watermelon Sailor Soda"); });

        }
        [Fact]
        public void ShouldReturnAllItems()
        {
            IEnumerable<IOrderItem> result = Menu.FullMenu();

            Assert.Contains(result, (item) => { return item.ToString().Equals("Briarheart Burger"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Double Draugr"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Garden Orc Omelette"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Smokehouse Skeleton"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Thugs T-Bone"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Thalmor Triple"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Philly Poacher"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Vokun Salad"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Vokun Salad"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Vokun Salad"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Dragonborn Waffle Fries"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Fried Miraak"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Fried Miraak"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Fried Miraak"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Mad Otar Grits"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Mad Otar Grits"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Mad Otar Grits"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Aretino Apple Juice"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Aretino Apple Juice"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Aretino Apple Juice"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Candlehearth Coffee"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Candlehearth Coffee"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Candlehearth Coffee"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Decaf Candlehearth Coffee"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Decaf Candlehearth Coffee"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Decaf Candlehearth Coffee"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Markarth Milk"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Markarth Milk"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Markarth Milk"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Warrior Water"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Warrior Water"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Cherry Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Cherry Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Cherry Sailor Soda"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Blackberry Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Blackberry Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Blackberry Sailor Soda"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Grapefruit Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Grapefruit Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Grapefruit Sailor Soda"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Lemon Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Lemon Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Lemon Sailor Soda"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Peach Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Peach Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Peach Sailor Soda"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Watermelon Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Watermelon Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Watermelon Sailor Soda"); });

        }

        [Fact]
        public void ShouldReturnFullMenuWithNullSearch()
        {
            string s = null;
            IEnumerable<IOrderItem> result = Menu.Search(s);
            Assert.Contains(result, (item) => { return item.ToString().Equals("Briarheart Burger"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Double Draugr"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Garden Orc Omelette"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Smokehouse Skeleton"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Thugs T-Bone"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Thalmor Triple"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Philly Poacher"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Vokun Salad"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Vokun Salad"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Vokun Salad"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Dragonborn Waffle Fries"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Fried Miraak"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Fried Miraak"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Fried Miraak"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Mad Otar Grits"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Mad Otar Grits"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Mad Otar Grits"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Aretino Apple Juice"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Aretino Apple Juice"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Aretino Apple Juice"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Candlehearth Coffee"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Candlehearth Coffee"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Candlehearth Coffee"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Decaf Candlehearth Coffee"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Decaf Candlehearth Coffee"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Decaf Candlehearth Coffee"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Markarth Milk"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Markarth Milk"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Markarth Milk"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Warrior Water"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Warrior Water"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Cherry Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Cherry Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Cherry Sailor Soda"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Blackberry Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Blackberry Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Blackberry Sailor Soda"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Grapefruit Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Grapefruit Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Grapefruit Sailor Soda"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Lemon Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Lemon Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Lemon Sailor Soda"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Peach Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Peach Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Peach Sailor Soda"); });

            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Watermelon Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Watermelon Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Watermelon Sailor Soda"); });




        }



        [Fact]
        public void ShouldReturnCorrectMenuBySearch()
        {
            string s = "water";
            IEnumerable<IOrderItem> result = Menu.Search(s);
            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Warrior Water"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Warrior Water"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Small Watermelon Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Medium Watermelon Sailor Soda"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Large Watermelon Sailor Soda"); });



        }

        [Fact]
        public void ShouldReturnAllItemsWithNullFilter()
        {
            List<string> s = null;
            IEnumerable<IOrderItem> result = Menu.Entrees();
            IEnumerable<IOrderItem> results = Menu.FilterByType(result, s);
            Assert.Contains(results, (item) => { return item.ToString().Equals("Briarheart Burger"); });
            Assert.Contains(results, (item) => { return item.ToString().Equals("Double Draugr"); });
            Assert.Contains(results, (item) => { return item.ToString().Equals("Garden Orc Omelette"); });
            Assert.Contains(results, (item) => { return item.ToString().Equals("Smokehouse Skeleton"); });
            Assert.Contains(results, (item) => { return item.ToString().Equals("Thugs T-Bone"); });
            Assert.Contains(results, (item) => { return item.ToString().Equals("Thalmor Triple"); });
            Assert.Contains(results, (item) => { return item.ToString().Equals("Philly Poacher"); });

        }


    }



}
