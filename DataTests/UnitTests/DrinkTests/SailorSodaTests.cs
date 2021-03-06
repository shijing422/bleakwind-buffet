﻿/*
 * Author: Shijing Zhang
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// unit test for the SailorSoda.cs class
    /// </summary>
    public class SailorSodaTests
    {
        [Fact]
        public void CheckDescription()
        {
            var A = new SailorSoda();

            string expected = "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";
            Assert.Equal(expected, A.Description);
        }
        [Fact]
        public void ChangingSizeNotifiesProperty()
        {
            var A = new SailorSoda();

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
        public void ChangingFlavorNotifiesProperty()
        {
            var A = new SailorSoda();

            Assert.PropertyChanged(A, "Flavor", () =>
            {
                A.Flavor = SodaFlavor.Blackberry;
            });

            Assert.PropertyChanged(A, "Flavor", () =>
            {
                A.Flavor = SodaFlavor.Cherry;
            });
            Assert.PropertyChanged(A, "Flavor", () =>
            {
                A.Flavor = SodaFlavor.Grapefruit;
            });
            Assert.PropertyChanged(A, "Flavor", () =>
            {
                A.Flavor = SodaFlavor.Lemon;
            });

            Assert.PropertyChanged(A, "Flavor", () =>
            {
                A.Flavor = SodaFlavor.Peach;
            });
            Assert.PropertyChanged(A, "Flavor", () =>
            {
                A.Flavor = SodaFlavor.Watermelon;
            });
        }
        [Fact]
        public void ChangingIceNotifiesProperty()
        {
            var A = new SailorSoda();

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
        public void ChangingSpecialInstructionsNotifiesProperty()
        {
            var A = new SailorSoda();

            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Ice = true;
            });

            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Ice = false;
            });

        }
        [Fact]
        public void ShouldBeADrink()
        {
            SailorSoda a = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(a);

        }
        [Fact]
        public void ShouldBeAssignToIORderItem()
        {
            SailorSoda a = new SailorSoda();


            Assert.IsAssignableFrom<IOrderItem>(a);
        }
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda a = new SailorSoda();
            Assert.True(a.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda a = new SailorSoda();
            Assert.Equal(Size.Small, a.Size);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda a = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, a.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda a = new SailorSoda();
            a.Ice = true;
            Assert.True(a.Ice);
            a.Ice = false;
            Assert.False(a.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorSoda a = new SailorSoda();
            a.Size = Size.Large;
            Assert.Equal(Size.Large, a.Size);
            a.Size = Size.Small;
            Assert.Equal(Size.Small, a.Size);
            a.Size = Size.Medium;
            Assert.Equal(Size.Medium, a.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSoda a = new SailorSoda();
            a.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, a.Flavor);
            a.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, a.Flavor);
            a.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, a.Flavor);
            a.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, a.Flavor);
            a.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, a.Flavor);
            a.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, a.Flavor);


        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSoda a = new SailorSoda();
            a.Size = size;
            Assert.Equal(price, a.Price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda a = new SailorSoda();
            a.Size = size;
            Assert.Equal(cal, a.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorSoda a = new SailorSoda();
            a.Ice = includeIce;
            if (includeIce == false) Assert.Contains("Hold ice", a.SpecialInstructions);
            else Assert.Empty(a.SpecialInstructions);
        }
        
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            SailorSoda a = new SailorSoda();
            a.Size = size;
            a.Flavor = flavor;
            Assert.Equal(name, a.ToString());
        }
    }
}
