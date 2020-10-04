/*
 * Author: ShijingZhang
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// unit test for the MarkarthMilk.cs class
    /// </summary>
    public class MarkarthMilkTests
    {
        [Fact]
        public void ChangingSizeNotifiesProperty()
        {
            var A = new MarkarthMilk();

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
            var A = new MarkarthMilk();

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
            var A = new MarkarthMilk();

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
            MarkarthMilk a = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(a);

        }
        [Fact]
        public void ShouldBeAssignToIORderItem()
        {
            MarkarthMilk a = new MarkarthMilk();
                


            Assert.IsAssignableFrom<IOrderItem>(a);
        }
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk a = new MarkarthMilk();
            Assert.False(a.Ice);

        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk a = new MarkarthMilk();
            Assert.Equal(Size.Small, a.Size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk a = new MarkarthMilk();
            a.Ice = true;
            Assert.True(a.Ice);
            a.Ice = false;
            Assert.False(a.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk a = new MarkarthMilk();
            a.Size = Size.Large;
            Assert.Equal(Size.Large, a.Size);
            a.Size = Size.Small;
            Assert.Equal(Size.Small, a.Size);
            a.Size = Size.Medium;
            Assert.Equal(Size.Medium, a.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk a = new MarkarthMilk();
            a.Size = size;
            Assert.Equal(price, a.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk a = new MarkarthMilk();
            a.Size = size;
            Assert.Equal(cal, a.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk a = new MarkarthMilk();
            a.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", a.SpecialInstructions);
            else Assert.Empty(a.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk a = new MarkarthMilk();
            a.Size = size;
            Assert.Equal(name, a.ToString());
        }
    }
}