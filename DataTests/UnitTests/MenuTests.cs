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
          
           
            Assert.Contains(result, (item) => { return item.ToString().Equals("Briarheart Burger"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Double Draugr"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Garden Orc Omelette"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Philly Poacher"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Smokehouse Skeleton"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Thalmor Triple"); });
            Assert.Contains(result, (item) => { return item.ToString().Equals("Thugs T-Bone"); });
        }
    }
}
