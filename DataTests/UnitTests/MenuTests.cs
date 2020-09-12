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
    }
}
