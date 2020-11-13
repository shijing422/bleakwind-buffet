/*
 * Author: Shijing Zhang
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
   
    /// <summary>
    /// unit test for the AretinoAppleJuice.cs class
    /// </summary>
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void CheckDescription()
        {
            var A = new AretinoAppleJuice();
          
            string expected = "Fresh squeezed apple juice.";
            Assert.Equal(expected, A.Description);
        }
        [Fact]
        public void ChangingSizeNotifiesProperty()
        {
            var A = new AretinoAppleJuice();

            Assert.PropertyChanged(A, "Size", () =>
            {
                A.Size = Size.Small;
            });

            Assert.PropertyChanged(A, "Size", () =>
            {
                A.Size=Size.Medium;
            });
            Assert.PropertyChanged(A, "Size", () =>
            {
                A.Size = Size.Large;
            });
        }
        [Fact]
        public void ChangingIceNotifiesProperty()
        {
            var A = new AretinoAppleJuice();

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
            var A = new AretinoAppleJuice();

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
            AretinoAppleJuice a = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(a);

        }
        [Fact]
        public void ShouldBeAssignToIORderItem()
        {
            AretinoAppleJuice a = new AretinoAppleJuice();


            Assert.IsAssignableFrom<IOrderItem>(a);
        }
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            Assert.False(a.Ice);
            
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            Assert.Equal(Size.Small, a.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            a.Ice = true;
            Assert.True(a.Ice);
            a.Ice = false;
            Assert.False(a.Ice);

        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            a.Size = Size.Large;
            Assert.Equal(Size.Large, a.Size);
            a.Size = Size.Small;
            Assert.Equal(Size.Small, a.Size);
            a.Size = Size.Medium;
            Assert.Equal(Size.Medium, a.Size);

        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            a.Size = size;
            Assert.Equal(price, a.Price);

        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            a.Size = size;
            Assert.Equal(cal, a.Calories);
                 
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            a.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", a.SpecialInstructions);
            else Assert.Empty(a.SpecialInstructions);
                
        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            a.Size = size;
            Assert.Equal(name, a.ToString());
        }
    }
}