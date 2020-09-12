/*
 * Author: ShijingZhang
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// unit test for the ThugsTBone.cs class
    /// </summary>
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldBeAEntree()
        {
            ThugsTBone a = new ThugsTBone();

            Assert.IsAssignableFrom<Entree>(a);

        }
        [Fact]
        public void ShouldBeAssignToIORderItem()
        {
            ThugsTBone a = new ThugsTBone();


            Assert.IsAssignableFrom<IOrderItem>(a);
        }
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone a = new ThugsTBone();
            double p = 6.44;
            Assert.Equal(a.Price, p);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone a = new ThugsTBone();
            uint p = 982;
            Assert.Equal(a.Calories, p);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone a = new ThugsTBone();
            Assert.Empty(a.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone a = new ThugsTBone();
            string name = "Thugs T-Bone";
            Assert.Equal(name, a.ToString());
        }
    }
}