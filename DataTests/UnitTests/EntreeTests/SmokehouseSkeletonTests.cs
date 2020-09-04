/*
 * Author: Shijing Zhang
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {        
        [Fact]
        public void ShouldInlcudeSausageByDefault()          
        {
            SmokehouseSkeleton a = new SmokehouseSkeleton();
            Assert.True(a.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton a = new SmokehouseSkeleton();
            Assert.True(a.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton a = new SmokehouseSkeleton();
            Assert.True(a.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton a = new SmokehouseSkeleton();
            Assert.True(a.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton a = new SmokehouseSkeleton();
            a.SausageLink = true;
            Assert.True(a.SausageLink);
            a.SausageLink = false;
            Assert.False(a.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton a = new SmokehouseSkeleton();
            a.Egg = true;
            Assert.True(a.Egg);
            a.Egg = false;
            Assert.False(a.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton a = new SmokehouseSkeleton();
            a.HashBrowns = true;
            Assert.True(a.HashBrowns);
            a.HashBrowns = false;
            Assert.False(a.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton a = new SmokehouseSkeleton();
            a.Pancake = true;
            Assert.True(a.Pancake);
            a.Pancake = false;
            Assert.False(a.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton a = new SmokehouseSkeleton();
            double p = 5.62;
            Assert.Equal(a.Price, p);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton a = new SmokehouseSkeleton();
            uint p = 602;
            Assert.Equal(a.Calories, p);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton a = new SmokehouseSkeleton();
            a.SausageLink = includeSausage;
            a.Egg = includeEgg;
            a.HashBrowns = includeHashbrowns;
            a.Pancake = includePancake;
            if (!includePancake) Assert.Contains("Hold pancakes", a.SpecialInstructions);
            if (!includeHashbrowns) Assert.Contains("Hold hash browns", a.SpecialInstructions);
            if (!includeSausage) Assert.Contains("Hold sausage", a.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold eggs", a.SpecialInstructions);

        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton a = new SmokehouseSkeleton();
            string name = "Smokehouse Skeleton";
            Assert.Equal(name, a.ToString());
        }
    }
}