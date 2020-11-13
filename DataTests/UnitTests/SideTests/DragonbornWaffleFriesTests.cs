/*
 * Author: Shijing Zhang
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// unit test for the DragonbornWaffleFries.cs
    /// </summary>
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void CheckDescription()
        {
            var A = new DragonbornWaffleFries();

            string expected = "Crispy fried potato waffle fries.";
            Assert.Equal(expected, A.Description);
        }
        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var A = new DragonbornWaffleFries();

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
        public void ShouldBeASide()
        {
            DragonbornWaffleFries a = new DragonbornWaffleFries();

            Assert.IsAssignableFrom<Side>(a);

        }
        [Fact]
        public void ShouldBeAssignToIORderItem()
        {

            DragonbornWaffleFries a = new DragonbornWaffleFries();

            Assert.IsAssignableFrom<IOrderItem>(a);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries a = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, a.Size);

        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries a = new DragonbornWaffleFries();
            a.Size = Size.Large;
            Assert.Equal(Size.Large, a.Size);
            a.Size = Size.Small;
            Assert.Equal(Size.Small, a.Size);
            a.Size = Size.Medium;
            Assert.Equal(Size.Medium, a.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries a = new DragonbornWaffleFries();
            Assert.Empty(a.SpecialInstructions);

        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries a = new DragonbornWaffleFries();
            a.Size = size;
            Assert.Equal(price, a.Price);

        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries a = new DragonbornWaffleFries();
            a.Size = size;
            Assert.Equal(calories, a.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries a = new DragonbornWaffleFries();
            a.Size = size;
         
            Assert.Equal(name, a.ToString());
        }
    }
}