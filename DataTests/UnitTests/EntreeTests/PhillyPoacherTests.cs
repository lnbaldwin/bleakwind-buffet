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
        /// Fact test to check that the class PhillyPoacher impliments the IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            PhillyPoacher php= new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(php);
        }

        /// <summary>
        /// Fact test to check that the PhillyPoacher class inherits from the Entree base class
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            PhillyPoacher php = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(php);
        }

        /// <summary>
        /// Fact test to check that the sirloin is included initially
        /// </summary>
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher php = new PhillyPoacher();
            Assert.True(php.Sirloin);
        }

        /// <summary>
        /// Fact test to check that the onions are included initially
        /// </summary>
        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher php = new PhillyPoacher();
            Assert.True(php.Onion);
        }

        /// <summary>
        /// Fact test to check that the roll is included initially
        /// </summary>
        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher php = new PhillyPoacher();
            Assert.True(php.Roll);
        }

        /// <summary>
        /// Fact test to check that the Sirloin property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher php = new PhillyPoacher();
            php.Sirloin = false;
            Assert.False(php.Sirloin);
            php.Sirloin = true;
            Assert.True(php.Sirloin);
        }

        /// <summary>
        /// Fact test to check that the Onion property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher php = new PhillyPoacher();
            php.Onion = false;
            Assert.False(php.Onion);
            php.Onion = true;
            Assert.True(php.Onion);
        }

        /// <summary>
        /// Fact test to check that the Roll property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher php = new PhillyPoacher();
            php.Roll = false;
            Assert.False(php.Roll);
            php.Roll = true;
            Assert.True(php.Roll);
        }

        /// <summary>
        /// Fact test to check that the Price property returns what we expect
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher php = new PhillyPoacher();
            Assert.Equal(7.23, php.Price);
        }

        /// <summary>
        /// Fact test to check tha th the Calories property returns what we expect
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher php = new PhillyPoacher();
            Assert.Equal((uint)784, php.Calories);
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
            PhillyPoacher php = new PhillyPoacher();
            php.Sirloin = includeSirloin;
            php.Onion = includeOnion;
            php.Roll = includeRoll;
            if(includeSirloin && includeOnion && includeRoll)
            {
                Assert.Empty(php.SpecialInstructions);
            }
            if(!includeSirloin && !includeOnion && !includeRoll)
            {
                Assert.Contains("Hold sirloin", php.SpecialInstructions);
                Assert.Contains("Hold onions", php.SpecialInstructions);
                Assert.Contains("Hold roll", php.SpecialInstructions);
            }
        }

        /// <summary>
        /// Fact test to check that the ToString() returns what we expect it to
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher php = new PhillyPoacher();
            Assert.Equal("Philly Poacher", php.ToString());
        }
    }
}