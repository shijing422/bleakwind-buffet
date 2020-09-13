using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Entrees;
using Xunit;

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


            Assert.All(result, item => item.ToString().Contains("Briarheart Burger"));
            Assert.All(result, item => item.ToString().Contains("Double Draugr"));
            Assert.All(result, item => item.ToString().Contains("Garden Orc Omelette"));
            Assert.All(result, item => item.ToString().Contains("Philly Poacher"));
            Assert.All(result, item => item.ToString().Contains("Smokehouse Skeleton"));
            Assert.All(result, item => item.ToString().Contains("Thalmor Triple"));
            Assert.All(result, item => item.ToString().Contains("Thugs T-Bone"));

        }
        [Fact]
        public void MenuReturnALLSides()
        {
            IEnumerable<IOrderItem> result = Menu.Sides();
            Assert.All(result, item => item.ToString().Contains("Small Vokun Salad"));
            Assert.All(result, item => item.ToString().Contains("Medium Vokun Salad"));
            Assert.All(result, item => item.ToString().Contains("Large Vokun Salad"));
            Assert.All(result, item => item.ToString().Contains("Small Dragonborn Waffle Fries"));
            Assert.All(result, item => item.ToString().Contains("Medium Dragonborn Waffle Fries"));
            Assert.All(result, item => item.ToString().Contains("Large Dragonborn Waffle Fries"));
            Assert.All(result, item => item.ToString().Contains("Small Fried Miraak"));
            Assert.All(result, item => item.ToString().Contains("Medium Fried Miraak"));
            Assert.All(result, item => item.ToString().Contains("Large Fried Miraak"));
            Assert.All(result, item => item.ToString().Contains("Small Mad Otar Grits"));
            Assert.All(result, item => item.ToString().Contains("Medium Mad Otar Grits"));
            Assert.All(result, item => item.ToString().Contains("Large Mad Otar Grits"));


        }
        [Fact]
        public void ShouldReturnAllDrinks()
        {
            IEnumerable<IOrderItem> result = Menu.Drinks();
            Assert.All(result, item => item.ToString().Contains("Small Aretino Apple Juice"));
            Assert.All(result, item => item.ToString().Contains("Medium Aretino Apple Juice"));
            Assert.All(result, item => item.ToString().Contains("Large Aretino Apple Juice"));

            Assert.All(result, item => item.ToString().Contains("Small Candlehearth Coffee"));
            Assert.All(result, item => item.ToString().Contains("Medium Candlehearth Coffee"));
            Assert.All(result, item => item.ToString().Contains("Large Candlehearth Coffee"));
            Assert.All(result, item => item.ToString().Contains("Small Decaf Candlehearth Coffee"));
            Assert.All(result, item => item.ToString().Contains("Medium Decaf Candlehearth Coffee"));
            Assert.All(result, item => item.ToString().Contains("Large Decaf Candlehearth Coffee"));

            Assert.All(result, item => item.ToString().Contains("Small Markarth Milk"));
            Assert.All(result, item => item.ToString().Contains("Medium Markarth Milk"));
            Assert.All(result, item => item.ToString().Contains("Large Markarth Milk"));

            Assert.All(result, item => item.ToString().Contains("Small Warrior Water"));
            Assert.All(result, item => item.ToString().Contains("Medium Warrior Water"));
            Assert.All(result, item => item.ToString().Contains("Large Warrior Water"));

            Assert.All(result, item => item.ToString().Contains("Small Cherry Sailor Soda"));
            Assert.All(result, item => item.ToString().Contains("Medium Cherry Sailor Soda"));
            Assert.All(result, item => item.ToString().Contains("Large Cherry Sailor Soda"));

            Assert.All(result, item => item.ToString().Contains("Small Blackberry Sailor Soda"));
            Assert.All(result, item => item.ToString().Contains("Medium Blackberry Sailor Soda"));
            Assert.All(result, item => item.ToString().Contains("Large Blackberry Sailor Soda"));

            Assert.All(result, item => item.ToString().Contains("Small Grapefruit Sailor Soda"));
            Assert.All(result, item => item.ToString().Contains("Medium Grapefruit Sailor Soda"));
            Assert.All(result, item => item.ToString().Contains("Large Grapefruit Sailor Soda"));

            Assert.All(result, item => item.ToString().Contains("Small Lemon Sailor Soda"));
            Assert.All(result, item => item.ToString().Contains("Medium Lemon Sailor Soda"));
            Assert.All(result, item => item.ToString().Contains("Large Lemon Sailor Soda"));

            Assert.All(result, item => item.ToString().Contains("Small Peach Sailor Soda"));
            Assert.All(result, item => item.ToString().Contains("Medium Peach Sailor Soda"));
            Assert.All(result, item => item.ToString().Contains("Large Peach Sailor Soda"));

            Assert.All(result, item => item.ToString().Contains("Small Watermelon Sailor Soda"));
            Assert.All(result, item => item.ToString().Contains("Medium Watermelon Sailor Soda"));
            Assert.All(result, item => item.ToString().Contains("Large Watermelon Sailor Soda"));

        }
        [Fact]
        public void ShouldReturnAllItems()
        {
            IEnumerable<IOrderItem> result = Menu.FullMenu();
            Assert.All(result, item => item.ToString().Contains("Briarheart Burger"));
            Assert.All(result, item => item.ToString().Contains("Double Draugr"));
            Assert.All(result, item => item.ToString().Contains("Garden Orc Omelette"));
            Assert.All(result, item => item.ToString().Contains("Philly Poacher"));
            Assert.All(result, item => item.ToString().Contains("Smokehouse Skeleton"));
            Assert.All(result, item => item.ToString().Contains("Thalmor Triple"));
            Assert.All(result, item => item.ToString().Contains("Thugs T-Bone"));

            Assert.All(result, item => item.ToString().Contains("Small Vokun Salad"));
            Assert.All(result, item => item.ToString().Contains("Medium Vokun Salad"));
            Assert.All(result, item => item.ToString().Contains("Large Vokun Salad"));
            Assert.All(result, item => item.ToString().Contains("Small Dragonborn Waffle Fries"));
            Assert.All(result, item => item.ToString().Contains("Medium Dragonborn Waffle Fries"));
            Assert.All(result, item => item.ToString().Contains("Large Dragonborn Waffle Fries"));
            Assert.All(result, item => item.ToString().Contains("Small Fried Miraak"));
            Assert.All(result, item => item.ToString().Contains("Medium Fried Miraak"));
            Assert.All(result, item => item.ToString().Contains("Large Fried Miraak"));
            Assert.All(result, item => item.ToString().Contains("Small Mad Otar Grits"));
            Assert.All(result, item => item.ToString().Contains("Medium Mad Otar Grits"));
            Assert.All(result, item => item.ToString().Contains("Large Mad Otar Grits"));

            Assert.All(result, item => item.ToString().Contains("Small Aretino Apple Juice"));
            Assert.All(result, item => item.ToString().Contains("Medium Aretino Apple Juice"));
            Assert.All(result, item => item.ToString().Contains("Large Aretino Apple Juice"));

            Assert.All(result, item => item.ToString().Contains("Small Candlehearth Coffee"));
            Assert.All(result, item => item.ToString().Contains("Medium Candlehearth Coffee"));
            Assert.All(result, item => item.ToString().Contains("Large Candlehearth Coffee"));
            Assert.All(result, item => item.ToString().Contains("Small Decaf Candlehearth Coffee"));
            Assert.All(result, item => item.ToString().Contains("Medium Decaf Candlehearth Coffee"));
            Assert.All(result, item => item.ToString().Contains("Large Decaf Candlehearth Coffee"));

            Assert.All(result, item => item.ToString().Contains("Small Markarth Milk"));
            Assert.All(result, item => item.ToString().Contains("Medium Markarth Milk"));
            Assert.All(result, item => item.ToString().Contains("Large Markarth Milk"));

            Assert.All(result, item => item.ToString().Contains("Small Warrior Water"));
            Assert.All(result, item => item.ToString().Contains("Medium Warrior Water"));
            Assert.All(result, item => item.ToString().Contains("Large Warrior Water"));

            Assert.All(result, item => item.ToString().Contains("Small Cherry Sailor Soda"));
            Assert.All(result, item => item.ToString().Contains("Medium Cherry Sailor Soda"));
            Assert.All(result, item => item.ToString().Contains("Large Cherry Sailor Soda"));

            Assert.All(result, item => item.ToString().Contains("Small Blackberry Sailor Soda"));
            Assert.All(result, item => item.ToString().Contains("Medium Blackberry Sailor Soda"));
            Assert.All(result, item => item.ToString().Contains("Large Blackberry Sailor Soda"));

            Assert.All(result, item => item.ToString().Contains("Small Grapefruit Sailor Soda"));
            Assert.All(result, item => item.ToString().Contains("Medium Grapefruit Sailor Soda"));
            Assert.All(result, item => item.ToString().Contains("Large Grapefruit Sailor Soda"));

            Assert.All(result, item => item.ToString().Contains("Small Lemon Sailor Soda"));
            Assert.All(result, item => item.ToString().Contains("Medium Lemon Sailor Soda"));
            Assert.All(result, item => item.ToString().Contains("Large Lemon Sailor Soda"));

            Assert.All(result, item => item.ToString().Contains("Small Peach Sailor Soda"));
            Assert.All(result, item => item.ToString().Contains("Medium Peach Sailor Soda"));
            Assert.All(result, item => item.ToString().Contains("Large Peach Sailor Soda"));

            Assert.All(result, item => item.ToString().Contains("Small Watermelon Sailor Soda"));
            Assert.All(result, item => item.ToString().Contains("Medium Watermelon Sailor Soda"));
            Assert.All(result, item => item.ToString().Contains("Large Watermelon Sailor Soda"));

        }
    
    }
}
