﻿/*
 * Author: Shijng Zhang
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entrees;


namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// unit test for the BriarheartBurger.cs class
    /// </summary>
    public class BriarheartBurgerTests
    {
        [Fact]
        public void CheckDescription()
        {
            var A = new BriarheartBurger();

            string expected = "Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.";
            Assert.Equal(expected, A.Description);
        }
        [Fact]
        public void ChangingBunNotifiesProperty()
        {
            var A = new BriarheartBurger();

            Assert.PropertyChanged(A, "Bun", () =>
            {
                A.Bun = true;
            });

            Assert.PropertyChanged(A, "Bun", () =>
            {
                A.Bun = false;
            });

        }
        [Fact]
        public void ChangingCheeseNotifiesProperty()
        {
            var A = new BriarheartBurger();

            Assert.PropertyChanged(A, "Cheese", () =>
            {
                A.Cheese = true;
            });

            Assert.PropertyChanged(A, "Cheese", () =>
            {
                A.Cheese = false;
            });

        }
        [Fact]
        public void ChangingKetchupNotifiesProperty()
        {
            var A = new BriarheartBurger();

            Assert.PropertyChanged(A, "Ketchup", () =>
            {
                A.Ketchup = true;
            });

            Assert.PropertyChanged(A, "Ketchup", () =>
            {
                A.Ketchup = false;
            });

        }
        [Fact]
        public void ChangingMustardNotifiesProperty()
        {
            var A = new BriarheartBurger();

            Assert.PropertyChanged(A, "Mustard", () =>
            {
                A.Mustard = true;
            });

            Assert.PropertyChanged(A, "Mustard", () =>
            {
                A.Mustard = false;
            });

        }
        [Fact]
        public void ChangingPickleNotifiesProperty()
        {
            var A = new BriarheartBurger();

            Assert.PropertyChanged(A, "Pickle", () =>
            {
                A.Pickle = true;
            });

            Assert.PropertyChanged(A, "Pickle", () =>
            {
                A.Pickle = false;
            });

        }
        [Fact]
        public void ChangingSpecialInstructionsNotifiesProperty()
        {
            var A = new BriarheartBurger();

            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Bun = true;
            });

            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Bun = false;
            });
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Ketchup= true;
            });

            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Ketchup = false;
            });
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Mustard = true;
            });

            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Mustard = false;
            });
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Pickle = true;
            });

            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Pickle = false;
            });
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Cheese = true;
            });

            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Cheese = false;
            });

        }
        [Fact]
        public void ShouldBeAEntree()
        {
            BriarheartBurger a = new BriarheartBurger();
            
            Assert.IsAssignableFrom<Entree>(a);
            
        }
        [Fact]
        public void ShouldBeAssignToIORderItem()
        {
            BriarheartBurger a = new BriarheartBurger();

            
            Assert.IsAssignableFrom<IOrderItem>(a);
        }

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