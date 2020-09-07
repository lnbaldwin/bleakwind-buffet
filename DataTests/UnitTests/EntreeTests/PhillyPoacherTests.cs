/*
 * Author: Zachery Brunner
 * Editor: Laura Baldwin
 * Date: sept 6th 2020
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Class of tests to use on the PhillyPoacher class in BleakwindBuffet.Data.Entrees
    /// </summary>
    public class PhillyPoacherTests
    {
        /// <summary>
        /// Fact test to check that the sirloin is included initially
        /// </summary>
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher phl = new PhillyPoacher();
            Assert.True(phl.Sirloin);
        }

        /// <summary>
        /// Fact test to check that the onions are included initially
        /// </summary>
        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher phl = new PhillyPoacher();
            Assert.True(phl.Onion);
        }

        /// <summary>
        /// Fact test to check that the roll is included initially
        /// </summary>
        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher phl = new PhillyPoacher();
            Assert.True(phl.Roll);
        }

        /// <summary>
        /// Fact test to check that the Sirloin property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher phl = new PhillyPoacher();
            phl.Sirloin = false;
            Assert.False(phl.Sirloin);
            phl.Sirloin = true;
            Assert.True(phl.Sirloin);
        }

        /// <summary>
        /// Fact test to check that the Onion property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher phl = new PhillyPoacher();
            phl.Onion = false;
            Assert.False(phl.Onion);
            phl.Onion = true;
            Assert.True(phl.Onion);
        }

        /// <summary>
        /// Fact test to check that the Roll property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher phl = new PhillyPoacher();
            phl.Roll = false;
            Assert.False(phl.Roll);
            phl.Roll = true;
            Assert.True(phl.Roll);
        }

        /// <summary>
        /// Fact test to check that the Price property returns what we expect
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher phl = new PhillyPoacher();
            Assert.Equal(7.23, phl.Price);
        }

        /// <summary>
        /// Fact test to check tha th the Calories property returns what we expect
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher phl = new PhillyPoacher();
            Assert.Equal((uint)784, phl.Calories);
        }

        /// <summary>
        /// Theory test with bools for the inclusion of sirloin, onion, and the roll to check that the SpecialInstructions contains
        /// what we expect when the bools are true, and when they are false
        /// </summary>
        /// <param name="includeSirloin">if the sirloin is included</param>
        /// <param name="includeOnion">if onions are included</param>
        /// <param name="includeRoll">if the roll is include</param>
        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher phl = new PhillyPoacher();
            phl.Sirloin = includeSirloin;
            phl.Onion = includeOnion;
            phl.Roll = includeRoll;
            if(includeSirloin && includeOnion && includeRoll)
            {
                Assert.Empty(phl.SpecialInstructions);
            }
            if(!includeSirloin && !includeOnion && !includeRoll)
            {
                Assert.Contains("Hold sirloin", phl.SpecialInstructions);
                Assert.Contains("Hold onions", phl.SpecialInstructions);
                Assert.Contains("Hold roll", phl.SpecialInstructions);
            }
        }

        /// <summary>
        /// Fact test to check that the ToString() returns what we expect it to
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher phl = new PhillyPoacher();
            Assert.Equal("Philly Poacher", phl.ToString());
        }
    }
}