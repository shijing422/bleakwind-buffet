/*
 * Author: Shijing Zhang
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    ///  unit test for the ThalmorTriple.cs class
    /// </summary>
    public class ThalmorTripleTests
    {
        [Fact]
        public void CheckDescription()
        {
            var A = new ThalmorTriple();

            string expected = "Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.";
            Assert.Equal(expected, A.Description);
        }
        [Fact]
        public void ChangingBunNotifiesProperty()
        {
            var A = new ThalmorTriple();

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
            var A = new ThalmorTriple();

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
            var A = new ThalmorTriple();

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
            var A = new ThalmorTriple();

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
            var A = new ThalmorTriple();

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
            var A = new ThalmorTriple();

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
            var A = new ThalmorTriple();

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
            var A = new ThalmorTriple();

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
        public void ChangingBaconNotifiesProperty()
        {
            var A = new ThalmorTriple();

            Assert.PropertyChanged(A, "Bacon", () =>
            {
                A.Bacon = true;
            });

            Assert.PropertyChanged(A, "Bacon", () =>
            {
                A.Bacon = false;
            });

        }
        [Fact]
        public void ChangingEggNotifiesProperty()
        {
            var A = new ThalmorTriple();

            Assert.PropertyChanged(A, "Egg", () =>
            {
                A.Egg = true;
            });

            Assert.PropertyChanged(A, "Egg", () =>
            {
                A.Egg = false;
            });

        }
        [Fact]
        public void ChangingSpecialInstructionsNotifiesProperty()
        {
            var A = new ThalmorTriple();
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Egg = true;
            });

            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Egg = false;
            });
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Bacon = true;
            });

            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Bacon = false;
            });
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
                A.Mayo = false;
            });

        }

        [Fact]
        public void ShouldBeAEntree()
        {
            ThalmorTriple a = new ThalmorTriple();

            Assert.IsAssignableFrom<Entree>(a);

        }
        [Fact]
        public void ShouldBeAssignToIORderItem()
        {
            ThalmorTriple a = new ThalmorTriple();


            Assert.IsAssignableFrom<IOrderItem>(a);
        }
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple a = new ThalmorTriple();
            Assert.True(a.Bun);

        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple a = new ThalmorTriple();
            Assert.True(a.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple a = new ThalmorTriple();
            Assert.True(a.Mustard);

        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple a = new ThalmorTriple();
            Assert.True(a.Pickle);

        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple a = new ThalmorTriple();
            Assert.True(a.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple a = new ThalmorTriple();
            Assert.True(a.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple a = new ThalmorTriple();
            Assert.True(a.Lettuce);

        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple a = new ThalmorTriple();
            Assert.True(a.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple a = new ThalmorTriple();
            Assert.True(a.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple a = new ThalmorTriple();
            Assert.True(a.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple a = new ThalmorTriple();
            a.Bun = true;
            Assert.True(a.Bun);
            a.Bun = false;
            Assert.False(a.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple a = new ThalmorTriple();
            a.Ketchup = true;
            Assert.True(a.Ketchup);
            a.Ketchup = false;
            Assert.False(a.Ketchup);

        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple a = new ThalmorTriple();
            a.Mustard = true;
            Assert.True(a.Mustard);
            a.Mustard = false;
            Assert.False(a.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple a = new ThalmorTriple();
            a.Pickle = true;
            Assert.True(a.Pickle);
            a.Pickle = false;
            Assert.False(a.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple a = new ThalmorTriple();
            a.Cheese = true;
            Assert.True(a.Cheese);
            a.Cheese = false;
            Assert.False(a.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple a = new ThalmorTriple();
            a.Tomato = true;
            Assert.True(a.Tomato);
            a.Tomato = false;
            Assert.False(a.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple a = new ThalmorTriple();
            a.Lettuce = true;
            Assert.True(a.Lettuce);
            a.Lettuce = false;
            Assert.False(a.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple a = new ThalmorTriple();
            a.Mayo = true;
            Assert.True(a.Mayo);
            a.Mayo = false;
            Assert.False(a.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple a = new ThalmorTriple();
            a.Bacon = true;
            Assert.True(a.Bacon);
            a.Bacon = false;
            Assert.False(a.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple a = new ThalmorTriple();
            a.Egg = true;
            Assert.True(a.Egg);
            a.Egg = false;
            Assert.False(a.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple a = new ThalmorTriple();
            double p = 8.32;
            Assert.Equal(a.Price, p);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple a = new ThalmorTriple();
            uint p = 943;
            Assert.Equal(a.Calories, p);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple a = new ThalmorTriple();
            a.Bun = includeBun;
            a.Ketchup = includeKetchup;
            a.Mustard = includeMustard;
            a.Pickle = includePickle;
            a.Cheese = includeCheese;
            a.Tomato = includeTomato;
            a.Mayo = includeMayo;
            a.Lettuce = includeLettuce;
            a.Bacon = includeBacon;
            a.Egg = includeEgg;
            
            if (!includeBun) Assert.Contains("Hold bun", a.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", a.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", a.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", a.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", a.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", a.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", a.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", a.SpecialInstructions);
            if (!includeBacon) Assert.Contains("Hold bacon", a.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", a.SpecialInstructions);

        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple a = new ThalmorTriple();
            string name = "Thalmor Triple";
            Assert.Equal(name, a.ToString());

        }
    }
}