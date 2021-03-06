﻿/*
 * Author: Shijing Zhang
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
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
    public class VokunSaladTests
    {
        [Fact]
        public void CheckDescription()
        {
            var A = new VokunSalad();

            string expected = "A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.";
            Assert.Equal(expected, A.Description);
        }
        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var A = new VokunSalad();

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
            VokunSalad a = new VokunSalad();

            Assert.IsAssignableFrom<Side>(a);

        }
        [Fact]
        public void ShouldBeAssignToIORderItem()
        {
            VokunSalad a = new VokunSalad();


            Assert.IsAssignableFrom<IOrderItem>(a);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad a = new VokunSalad();
            Assert.Equal(Size.Small, a.Size);

        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad a = new VokunSalad();
            a.Size = Size.Large;
            Assert.Equal(Size.Large, a.Size);
            a.Size = Size.Small;
            Assert.Equal(Size.Small, a.Size);
            a.Size = Size.Medium;
            Assert.Equal(Size.Medium, a.Size);

        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            VokunSalad a = new VokunSalad();
            Assert.Empty(a.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            VokunSalad a = new VokunSalad();
            a.Size = size;
            Assert.Equal(price, a.Price);

        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad a = new VokunSalad();
            a.Size = size;
            Assert.Equal(calories, a.Calories);

        }

        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            VokunSalad a = new VokunSalad();
            a.Size = size;

            Assert.Equal(name, a.ToString());
        }
    }
}