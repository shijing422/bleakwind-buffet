/*
 * Author: Shijing Zhang
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// unit test for the FriedMiraak.cs class
    /// </summary>
    public class FriedMiraakTests
    {
        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var A = new FriedMiraak();

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
            FriedMiraak a = new FriedMiraak();

            Assert.IsAssignableFrom<Side>(a);

        }
        [Fact]
        public void ShouldBeAssignToIORderItem()
        {

            FriedMiraak a = new FriedMiraak();

            Assert.IsAssignableFrom<IOrderItem>(a);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak a = new FriedMiraak();
            Assert.Equal(Size.Small, a.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak a = new FriedMiraak();
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
            FriedMiraak a = new FriedMiraak();
            Assert.Empty(a.SpecialInstructions);

        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak a = new FriedMiraak();
            a.Size = size;
            Assert.Equal(price, a.Price);

        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak a = new FriedMiraak();
            a.Size = size;
            Assert.Equal(calories, a.Calories);

        }

        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak a = new FriedMiraak();
            a.Size = size;
            Assert.Equal(name, a.ToString());
        }
    }
}