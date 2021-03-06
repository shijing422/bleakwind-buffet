﻿/*
 * Author: Shijing Zhang
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// unit test for the DoubleDraugr.cs class
    /// </summary>
    public class DoubleDraugrTests
    {
        [Fact]
        public void CheckDescription()
        {
            var A = new DoubleDraugr();

            string expected = "Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.";
            Assert.Equal(expected, A.Description);
        }
        [Fact]
        public void ChangingBunNotifiesProperty()
        {
            var A = new DoubleDraugr();

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
            var A = new DoubleDraugr();

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
            var A = new DoubleDraugr();

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
            var A = new DoubleDraugr();

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
            var A = new DoubleDraugr();

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
        public void ChangingMayoNotifiesProperty()
        {
            var A = new DoubleDraugr();

            Assert.PropertyChanged(A, "Mayo", () =>
            {
                A.Mayo = true;
            });

            Assert.PropertyChanged(A, "Mayo", () =>
            {
                A.Mayo = false;
            });

        }
        [Fact]
        public void ChangingTomatoNotifiesProperty()
        {
            var A = new DoubleDraugr();

            Assert.PropertyChanged(A, "Tomato", () =>
            {
                A.Tomato = true;
            });

            Assert.PropertyChanged(A, "Tomato", () =>
            {
                A.Tomato = false;
            });

        }
        [Fact]
        public void ChangingLettuceNotifiesProperty()
        {
            var A = new DoubleDraugr();

            Assert.PropertyChanged(A, "Lettuce", () =>
            {
                A.Lettuce = true;
            });

            Assert.PropertyChanged(A, "Lettuce", () =>
            {
                A.Lettuce = false;
            });

        }
        [Fact]
        public void ChangingSpecialInstructionsNotifiesProperty()
        {
            var A = new DoubleDraugr();

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
                A.Ketchup = true;
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
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Tomato = true;
            });

            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Tomato = false;
            });
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Lettuce = true;
            });

            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Lettuce = false;
            });
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Mayo = true;
            });

            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Mayo= false;
            });

        }

        [Fact]
        public void ShouldBeAEntree()
        {
            DoubleDraugr a = new DoubleDraugr();

            Assert.IsAssignableFrom<Entree>(a);

        }
        [Fact]
        public void ShouldBeAssignToIORderItem()
        {
            DoubleDraugr a = new DoubleDraugr();


            Assert.IsAssignableFrom<IOrderItem>(a);
        }
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr a = new DoubleDraugr();
            Assert.True(a.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr a = new DoubleDraugr();
            Assert.True(a.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr a = new DoubleDraugr();
            Assert.True(a.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr a = new DoubleDraugr();
            Assert.True(a.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr a = new DoubleDraugr();
            Assert.True(a.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr a = new DoubleDraugr();
            Assert.True(a.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr a = new DoubleDraugr();
            Assert.True(a.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr a = new DoubleDraugr();
            Assert.True(a.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr a = new DoubleDraugr();
            a.Bun = true;
            Assert.True(a.Bun);
            a.Bun = false;
            Assert.False(a.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr a = new DoubleDraugr();
            a.Ketchup = true;
            Assert.True(a.Ketchup);
            a.Ketchup = false;
            Assert.False(a.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr a = new DoubleDraugr();
            a.Mustard = true;
            Assert.True(a.Mustard);
            a.Mustard = false;
            Assert.False(a.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr a = new DoubleDraugr();
            a.Pickle = true;
            Assert.True(a.Pickle);
            a.Pickle = false;
            Assert.False(a.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr a = new DoubleDraugr();
            a.Cheese = true;
            Assert.True(a.Cheese);
            a.Cheese = false;
            Assert.False(a.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr a = new DoubleDraugr();
            a.Tomato = true;
            Assert.True(a.Tomato);
            a.Tomato = false;
            Assert.False(a.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr a = new DoubleDraugr();
            a.Lettuce = true;
            Assert.True(a.Lettuce);
            a.Lettuce = false;
            Assert.False(a.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr a = new DoubleDraugr();
            a.Mayo = true;
            Assert.True(a.Mayo);
            a.Mayo = false;
            Assert.False(a.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr a = new DoubleDraugr();
            double p = 7.32;
            Assert.Equal(a.Price, p);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr a = new DoubleDraugr();
            uint p = 843;
            Assert.Equal(a.Calories, p);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr a = new DoubleDraugr();
            a.Bun = includeBun;
            a.Ketchup = includeKetchup;
            a.Mustard = includeMustard;
            a.Pickle = includePickle;
            a.Cheese = includeCheese;
            a.Tomato = includeTomato;
            a.Mayo = includeMayo;
            a.Lettuce = includeLettuce;
            if (!includeBun) Assert.Contains("Hold bun", a.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", a.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", a.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", a.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", a.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", a.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", a.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", a.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr a = new DoubleDraugr();
            string name = "Double Draugr";
            Assert.Equal(name, a.ToString());
        }
    }
}