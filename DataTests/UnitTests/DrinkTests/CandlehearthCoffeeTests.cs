/*
 * Author: Shijing Zhang
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// unit test for the CandlehearthCoffee.cs class
    /// </summary>
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ChangingSizeNotifiesProperty()
        {
            var A = new CandlehearthCoffee();

            Assert.PropertyChanged(A, "Size", () =>
            {
                A.Size = Size.Small;
            });

            Assert.PropertyChanged(A, "Size", () =>
            {
                A.Size = Size.Medium;
            });
            Assert.PropertyChanged(A, "Size", () =>
            {
                A.Size = Size.Large;
            });
        }
        [Fact]
        public void ChangingIceNotifiesProperty()
        {
            var A = new CandlehearthCoffee();

            Assert.PropertyChanged(A, "Ice", () =>
            {
                A.Ice = true;
            });

            Assert.PropertyChanged(A, "Ice", () =>
            {
                A.Ice = false;
            });

        }
        [Fact]
        public void ChangingRoomforCreamNotifiesProperty()
        {
            var A = new CandlehearthCoffee();

            Assert.PropertyChanged(A, "RoomForCream", () =>
            {
                A.RoomForCream = true;
            });

            Assert.PropertyChanged(A, "RoomForCream", () =>
            {
                A.RoomForCream = false;
            });

        }
        [Fact]
        public void ChangingDecafNotifiesProperty()
        {
            var A = new CandlehearthCoffee();

            Assert.PropertyChanged(A, "Decaf", () =>
            {
                A.Decaf = true;
            });

            Assert.PropertyChanged(A, "Decaf", () =>
            {
                A.Decaf = false;
            });

        }
        [Fact]
        public void ChangingSpecialInstructionsNotifiesProperty()
        {
            var A = new CandlehearthCoffee();

            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Ice = true;
            });

            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Ice = false;
            });
 
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.RoomForCream = true;
            });

            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.RoomForCream = false;
            });

        }
        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee a = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(a);

        }
        [Fact]
        public void ShouldBeAssignToIORderItem()
        {
            CandlehearthCoffee a = new CandlehearthCoffee();


            Assert.IsAssignableFrom<IOrderItem>(a);
        }
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee a = new CandlehearthCoffee();
            Assert.False(a.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee a = new CandlehearthCoffee();
            Assert.False(a.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee a = new CandlehearthCoffee();
            Assert.False(a.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee a = new CandlehearthCoffee();
            Assert.Equal(Size.Small, a.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee a = new CandlehearthCoffee();
            a.Ice = true;
            Assert.True(a.Ice);
            a.Ice = false;
            Assert.False(a.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee a = new CandlehearthCoffee();
            a.Decaf = true;
            Assert.True(a.Decaf);
            a.Decaf = false;
            Assert.False(a.Decaf);

        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee a = new CandlehearthCoffee();
            a.RoomForCream = true;
            Assert.True(a.RoomForCream);
            a.RoomForCream = false;
            Assert.False(a.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee a = new CandlehearthCoffee();
            a.Size = Size.Large;
            Assert.Equal(Size.Large, a.Size);
            a.Size = Size.Small;
            Assert.Equal(Size.Small, a.Size);
            a.Size = Size.Medium;
            Assert.Equal(Size.Medium, a.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee a = new CandlehearthCoffee();
            a.Size = size;
            Assert.Equal(price, a.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee a = new CandlehearthCoffee();
            a.Size = size;
            Assert.Equal(cal, a.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee a = new CandlehearthCoffee();
            a.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", a.SpecialInstructions);
           
            a.RoomForCream = includeCream;
            if (includeCream) Assert.Contains("Add cream", a.SpecialInstructions);


        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee a = new CandlehearthCoffee();
            a.Size = size;
            a.Decaf = decaf;
            Assert.Equal(name, a.ToString());
        }
    }
}
