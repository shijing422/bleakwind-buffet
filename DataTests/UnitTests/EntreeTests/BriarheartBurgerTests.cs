/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entrees;


namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger a = new BriarheartBurger();
            Assert.True(a.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger a = new BriarheartBurger();
            Assert.True(a.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger a = new BriarheartBurger();
            Assert.True(a.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {

            BriarheartBurger a = new BriarheartBurger();
            Assert.True(a.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger a = new BriarheartBurger();
            Assert.True(a.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger a = new BriarheartBurger();
            a.Bun = true;
            Assert.True(a.Bun);
            a.Bun = false;
            Assert.False(a.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger a = new BriarheartBurger();
            a.Ketchup = true;
            Assert.True(a.Ketchup);
            a.Ketchup = false;
            Assert.False(a.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger a = new BriarheartBurger();
            a.Mustard = true;
            Assert.True(a.Mustard);
            a.Mustard = false;
            Assert.False(a.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger a = new BriarheartBurger();
            a.Pickle = true;
            Assert.True(a.Pickle);
            a.Pickle = false;
            Assert.False(a.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger a = new BriarheartBurger();
            a.Cheese = true;
            Assert.True(a.Cheese);
            a.Cheese = false;
            Assert.False(a.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger a = new BriarheartBurger();
            double p = 6.32;
            Assert.Equal(a.Price, p);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger a = new BriarheartBurger();
            uint p = 743;
            Assert.Equal(a.Calories, p);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger a = new BriarheartBurger();
            a.Bun = includeBun;
            a.Ketchup = includeKetchup;
            a.Mustard = includeMustard;
            a.Pickle = includePickle;
            a.Cheese = includeCheese;
            if (!includeBun) Assert.Contains("Hold bun", a.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", a.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", a.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", a.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", a.SpecialInstructions);
            

        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger a = new BriarheartBurger();
            string name = "Briarheart Burger";
            Assert.Equal(name, a.ToString());
        }
    }
}