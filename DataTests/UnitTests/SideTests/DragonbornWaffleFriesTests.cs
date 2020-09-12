/*
 * Author: Zachery Brunner
 * Editor: Laura Bladwin
 * Date: Sept 6th, 2020
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Class of tests to use on the DragonbornWaffleFries class in BleakwindBuffet.Data.Sides
    /// </summary>
    public class DragonbornWaffleFriesTests
    {
        /// <summary>
        /// Fact test to check that the DragonBornWaffleFries class impliments the IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            DragonbornWaffleFries dbf = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(dbf);
        }

        /// <summary>
        /// Fact test to check that the DragonBornWaffleFries class inherits from the Side base class
        /// </summary>
        [Fact]
        public void ShouldBeASide()
        {
            DragonbornWaffleFries dbf = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(dbf);
        }

        /// <summary>
        /// Fact test to check that the size of the order is Small initially
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries dbf = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, dbf.Size);
        }

        /// <summary>
        /// Fact test to check that the value of Size can be toggled between Small, Medium, and Large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries dbf = new DragonbornWaffleFries();
            dbf.Size = Size.Medium;
            Assert.Equal(Size.Medium, dbf.Size);
            dbf.Size = Size.Large;
            Assert.Equal(Size.Large, dbf.Size);
            dbf.Size = Size.Small;
            Assert.Equal(Size.Small, dbf.Size);
        }

        /// <summary>
        /// Fact test to check that the Special Instructions List is empty
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries dbf = new DragonbornWaffleFries();
            Assert.Empty(dbf.SpecialInstructions);
        }

        /// <summary>
        /// Theory with a size and price to check that the price for the fries is what we expect for each size
        /// </summary>
        /// <param name="size">the size given</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries dbf = new DragonbornWaffleFries();
            dbf.Size = size;
            Assert.Equal(price, dbf.Price);
        }

        /// <summary>
        /// Theory with a size and calories to check that the calories for the fries is what we expect for each size
        /// </summary>
        /// <param name="size">the size given</param>
        /// <param name="calories">the expected calories</param>
        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries dbf = new DragonbornWaffleFries();
            dbf.Size = size;
            Assert.Equal(calories, dbf.Calories);
        }

        /// <summary>
        /// Theory test with a size and expected name to test the output of the ToString() method
        /// </summary>
        /// <param name="size">the given size</param>
        /// <param name="name">the expected output</param>
        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries dbf = new DragonbornWaffleFries();
            dbf.Size = size;
            Assert.Equal(name, dbf.ToString());
        }
    }
}