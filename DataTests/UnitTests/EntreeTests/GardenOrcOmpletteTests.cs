/*
 * Author: Shijing Zhang
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// unit test for the GardenOrcOmelette.cs class
    /// </summary>
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void CheckDescription()
        {
            var A = new GardenOrcOmelette();

            string expected = "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";
            Assert.Equal(expected, A.Description);
        }
        [Fact]
        public void ChangingTomatoNotifiesProperty()
        {
            var A = new GardenOrcOmelette();

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
        public void ChangingCheddarNotifiesProperty()
        {
            var A = new GardenOrcOmelette();

            Assert.PropertyChanged(A, "Cheddar", () =>
            {
                A.Cheddar = true;
            });

            Assert.PropertyChanged(A, "Cheddar", () =>
            {
                A.Cheddar = false;
            });

        }

        [Fact]
        public void ChangingBroccoliNotifiesProperty()
        {
            var A = new GardenOrcOmelette();

            Assert.PropertyChanged(A, "Broccoli", () =>
            {
                A.Broccoli = true;
            });

            Assert.PropertyChanged(A, "Broccoli", () =>
            {
                A.Broccoli = false;
            });

        }

        [Fact]
        public void ChangingMushroomsNotifiesProperty()
        {
            var A = new GardenOrcOmelette();

            Assert.PropertyChanged(A, "Mushrooms", () =>
            {

                A.Mushrooms = true;
            });

            Assert.PropertyChanged(A, "Mushrooms", () =>
            {
                A.Mushrooms = false;
            });

        }


        [Fact]
        public void ChangingSpecialInstructionsNotifiesProperty()
        {
            var A = new GardenOrcOmelette();

            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Mushrooms= true;
            });

            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Mushrooms = false;
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
                A.Cheddar = true;
            });

            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Cheddar= false;
            });
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Broccoli = true;
            });

            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Broccoli = false;
            });
   
        }


        [Fact]
        public void ShouldBeAEntree()
        {
            GardenOrcOmelette a = new GardenOrcOmelette();
                

            Assert.IsAssignableFrom<Entree>(a);

        }
        [Fact]
        public void ShouldBeAssignToIORderItem()
        {
            GardenOrcOmelette a = new GardenOrcOmelette();


            Assert.IsAssignableFrom<IOrderItem>(a);
        }
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette a = new GardenOrcOmelette();
            Assert.True(a.Broccoli);
        }
            

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette a = new GardenOrcOmelette();
            Assert.True(a.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette a = new GardenOrcOmelette();
            Assert.True(a.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette a = new GardenOrcOmelette();
            Assert.True(a.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette a = new GardenOrcOmelette();
            a.Broccoli = true;
            Assert.True(a.Broccoli);
            a.Broccoli = false;
            Assert.False(a.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette a = new GardenOrcOmelette();
            a.Mushrooms = true;
            Assert.True(a.Mushrooms);
            a.Mushrooms = false;
            Assert.False(a.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette a = new GardenOrcOmelette();
            a.Tomato = true;
            Assert.True(a.Tomato);
            a.Tomato = false;
            Assert.False(a.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette a = new GardenOrcOmelette();
            a.Cheddar = true;
            Assert.True(a.Cheddar);
            a.Cheddar = false;
            Assert.False(a.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette a = new GardenOrcOmelette();
            double p = 4.57;
            Assert.Equal(a.Price, p);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette a = new GardenOrcOmelette();
            uint p = 404;
            Assert.Equal(a.Calories, p);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette a = new GardenOrcOmelette();
            a.Broccoli = includeBroccoli;
            a.Mushrooms = includeMushrooms;
            a.Cheddar = includeCheddar;
            a.Tomato = includeTomato;
            if (!includeBroccoli) Assert.Contains("Hold broccoli", a.SpecialInstructions);
            if (!includeCheddar) Assert.Contains("Hold cheddar", a.SpecialInstructions);
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", a.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", a.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette a = new GardenOrcOmelette();
            string name = "Garden Orc Omelette";
            Assert.Equal(name, a.ToString());
        }
    }
}