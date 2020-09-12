/*
 * Author: Zachery Brunner
 * Editor: Laura Baldwin
 * Date: Sept 6th 2020
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Class of tests to use on the ThugsTBone class in BleakwindBuffet.Data.Entrees
    /// </summary>
    public class ThugsTBoneTests
    {
        /// <summary>
        /// Fact test to check that the class ThugsTBone impliments the IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(ttb);
        }

        /// <summary>
        /// Fact test to check that the ThugsTBone class inherits from the Entree base class
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(ttb);
        }

        /// <summary>
        /// Fact test to check that the Price property returns what we expect
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.Equal(6.44, ttb.Price);
        }

        /// <summary>
        /// Fact test to check that the Calories property returns what we expect
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.Equal((uint)982, ttb.Calories);
        }

        /// <summary>
        /// Fact test to check the contents of the Special Instructions List is empty
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.Empty(ttb.SpecialInstructions);
        }

        /// <summary>
        /// Fact test to check that the ToString() returns what we expect it to
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", ttb.ToString());
        }
    }
}