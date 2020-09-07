/*
 * Author: Zachery Brunner
 * Editor: Laura Baldwin
 * Date: Sept 6th 2020
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Class of tests to use on the SmokehouseSkeleton class in BleakwindBuffet.Data.Entrees
    /// </summary>
    public class SmokehouseSkeletonTests
    {        
        /// <summary>
        /// Fact test to check that the sausage is included initially
        /// </summary>
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.True(shs.SausageLink);
        }

        /// <summary>
        /// Fact test to check that the egg is included initially
        /// </summary>
        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.True(shs.Egg);
        }

        /// <summary>
        /// Fact test to check that the hashbrowns are included initially
        /// </summary>
        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.True(shs.HashBrowns);
        }

        /// <summary>
        /// Fact test to check that the pancake is included initially
        /// </summary>
        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.True(shs.Pancake);
        }

        /// <summary>
        /// Fact test to check that the Sausage property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            shs.SausageLink = false;
            Assert.False(shs.SausageLink);
            shs.SausageLink = true;
            Assert.True(shs.SausageLink);
        }

        /// <summary>
        /// Fact test to check that the Egg property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            shs.Egg = false;
            Assert.False(shs.Egg);
            shs.Egg = true;
            Assert.True(shs.Egg);
        }

        /// <summary>
        /// Fact test to check that the HashBrowns property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            shs.HashBrowns = false;
            Assert.False(shs.HashBrowns);
            shs.HashBrowns = true;
            Assert.True(shs.HashBrowns);
        }

        /// <summary>
        /// Fact test to check that the Pancake property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            shs.Pancake = false;
            Assert.False(shs.Pancake);
            shs.Pancake = true;
            Assert.True(shs.Pancake);
        }

        /// <summary>
        /// Fact test to check that the Price property returns what we expect
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.Equal(5.62, shs.Price);
        }

        /// <summary>
        /// Fact test to check that the Calories property returns what we expect
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.Equal((uint)602, shs.Calories);
        }

        /// <summary>
        /// Theory test with bools for the sausage, egg, hashbrowns and the pancake to check that the SpecialInstructions contains
        /// what we expect when the bools are true, and when they are false
        /// </summary>
        /// <param name="includeSausage">if the sausage is included</param>
        /// <param name="includeEgg">if the egg is included</param>
        /// <param name="includeHashbrowns">if the hashbrowns are included</param>
        /// <param name="includePancake">if the pancake is included</param>
        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            shs.SausageLink = includeSausage;
            shs.Egg = includeEgg;
            shs.HashBrowns = includeHashbrowns;
            shs.Pancake = includePancake;

            if(includeSausage && includeEgg && includeHashbrowns && includePancake)
            {
                Assert.Empty(shs.SpecialInstructions);
            }

            if(!includeSausage && !includeEgg && !includeHashbrowns && !includePancake)
            {
                Assert.Contains("Hold sausage", shs.SpecialInstructions);
                Assert.Contains("Hold eggs", shs.SpecialInstructions);
                Assert.Contains("Hold hash browns", shs.SpecialInstructions);
                Assert.Contains("Hold pancakes", shs.SpecialInstructions);
            }
        }

        /// <summary>
        /// Fact test to check that the ToString() returns what we expect it to
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", shs.ToString());
        }
    }
}