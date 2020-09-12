/*
 * Author: Shijing Zhang
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWaterTests.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// unit test for the WarriorWaterTests.cs class
    /// </summary>
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            WarriorWater a = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(a);

        }
        [Fact]
        public void ShouldBeAssignToIORderItem()
        {
            WarriorWater a = new WarriorWater();


            Assert.IsAssignableFrom<IOrderItem>(a);
        }
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater a = new WarriorWater();
            Assert.True(a.Ice);
        }
        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater a = new WarriorWater();
            Assert.False(a.Lemon);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater a = new WarriorWater();
            Assert.Equal(Size.Small, a.Size);
        }
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater a = new WarriorWater();
            a.Ice = true;
            Assert.True(a.Ice);
            a.Ice = false;
            Assert.False(a.Ice);
        }
        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater a = new WarriorWater();
            a.Lemon = true;
            Assert.True(a.Lemon);
            a.Lemon = false;
            Assert.False(a.Lemon);
        }
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater a = new WarriorWater();
            a.Size = Size.Large;
            Assert.Equal(Size.Large, a.Size);
            a.Size = Size.Small;
            Assert.Equal(Size.Small, a.Size);
            a.Size = Size.Medium;
            Assert.Equal(Size.Medium, a.Size);
        }
        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater a = new WarriorWater();
            a.Size = size;
            Assert.Equal(price, a.Price);
        }
        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater a = new WarriorWater();
            a.Size = size;
            Assert.Equal(cal, a.Calories);
        }
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater a = new WarriorWater();
            a.Ice = includeIce;
            a.Lemon = includeLemon;
            if (!includeIce) Assert.Contains("Hold ice", a.SpecialInstructions);

            a.Lemon = includeLemon;
            if (includeLemon) Assert.Contains("Add lemon", a.SpecialInstructions);


        }
        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater a = new WarriorWater();
            a.Size = size;
            Assert.Equal(name, a.ToString());
        }
    }
}
