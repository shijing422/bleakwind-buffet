/*
 * Author: ShijngZhang
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// unit test for the PhillyPoacher.cs class
    /// </summary>
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher a = new PhillyPoacher();
            Assert.True(a.Sirloin);

        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {

            PhillyPoacher a = new PhillyPoacher();
            Assert.True(a.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher a = new PhillyPoacher();
            Assert.True(a.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher a = new PhillyPoacher();
            a.Sirloin = true;
            Assert.True(a.Sirloin);
            a.Sirloin = false;
            Assert.False(a.Sirloin);

        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher a = new PhillyPoacher();
            a.Onion = true;
            Assert.True(a.Onion);
            a.Onion = false;
            Assert.False(a.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher a = new PhillyPoacher();
            a.Roll = true;
            Assert.True(a.Roll);
            a.Roll = false;
            Assert.False(a.Roll);

        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher a = new PhillyPoacher();
            double p = 7.23;
            Assert.Equal(a.Price, p);

        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher a = new PhillyPoacher();
            uint p = 784;
            Assert.Equal(a.Calories, p);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher a = new PhillyPoacher();
            a.Roll = includeRoll;
            a.Sirloin = includeSirloin;
            a.Onion = includeOnion;
            if (!includeOnion) Assert.Contains("Hold onions", a.SpecialInstructions);
            if (!includeSirloin) Assert.Contains("Hold sirloin", a.SpecialInstructions);
            if (!includeRoll) Assert.Contains("Hold roll", a.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher a = new PhillyPoacher();
            string name = "Philly Poacher";
            Assert.Equal(name, a.ToString());
        }
    }
}