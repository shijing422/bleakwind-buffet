/*
 * Author: Shijing Zhang
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// unit test for the MadOtarGrits.cs class
    /// </summary>
    public class MadOtarGritsTests
    {
        [Fact]
        public void CheckDescription()
        {
            var A = new MadOtarGrits();

            string expected = "Cheesey Grits.";
            Assert.Equal(expected, A.Description);
        }
        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var A = new MadOtarGrits();

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

            MadOtarGrits a = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(a);

        }
        [Fact]
        public void ShouldBeAssignToIORderItem()
        {
            MadOtarGrits a = new MadOtarGrits();


            Assert.IsAssignableFrom<IOrderItem>(a);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits a = new MadOtarGrits();
            Assert.Equal(Size.Small, a.Size);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits a = new MadOtarGrits();
            a.Size = Size.Large;
            Assert.Equal(Size.Large, a.Size);
            a.Size = Size.Small;
            Assert.Equal(Size.Small, a.Size);
            a.Size = Size.Medium;
            Assert.Equal(Size.Medium, a.Size);

        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits a = new MadOtarGrits();
            Assert.Empty(a.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits a = new MadOtarGrits();
            a.Size = size;
            Assert.Equal(price, a.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits a = new MadOtarGrits();
            a.Size = size;
            Assert.Equal(calories, a.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits a = new MadOtarGrits();
            a.Size = size;

            Assert.Equal(name, a.ToString());
        }
    }
}