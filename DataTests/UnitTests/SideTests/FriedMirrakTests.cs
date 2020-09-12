/*
 * Author: Zachery Brunner
 * Editor: Laura Baldwin
 * Date: Sept 6th 2020
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Class of tests to use on the FriedMiraak class in BleakwindBuffet.Data.Sides
    /// </summary>
    public class FriedMiraakTests
    {
        /// <summary>
        /// Fact test to check that the FriedMiraak class impliments the IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            FriedMiraak frm = new FriedMiraak();
            Assert.IsAssignableFrom<IOrderItem>(frm);
        }

        /// <summary>
        /// Fact test to check that the FriedMiraak class inherits from the Side base class
        /// </summary>
        [Fact]
        public void ShouldBeASide()
        {
            FriedMiraak frm = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(frm);
        }

        /// <summary>
        /// Fact test to check that the size of the order is Small initially
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak frm = new FriedMiraak();
            Assert.Equal(Size.Small, frm.Size);
        }

        /// <summary>
        /// Fact test to check that the value of Size can be toggled between Small, Medium, and Large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak frm = new FriedMiraak();
            frm.Size = Size.Medium;
            Assert.Equal(Size.Medium, frm.Size);
            frm.Size = Size.Large;
            Assert.Equal(Size.Large, frm.Size);
            frm.Size = Size.Small;
            Assert.Equal(Size.Small, frm.Size);
        }

        /// <summary>
        /// Fact test to check that the Special Instructions List is empty
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak frm = new FriedMiraak();
            Assert.Empty(frm.SpecialInstructions);
        }

        /// <summary>
        /// Theory with a size and price to check that the price for the Fried Mirrak is what we expect for each size
        /// </summary>
        /// <param name="size">the size given</param>
        /// <param name="price">the expected price</param>
        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak frm = new FriedMiraak();
            frm.Size = size;
            Assert.Equal(price, frm.Price);
        }

        /// <summary>
        /// Theory with a size and calories to check that the calories for the Fried Mirrak is what we expect for each size
        /// </summary>
        /// <param name="size">the size given</param>
        /// <param name="calories">the expected calories</param>
        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak frm = new FriedMiraak();
            frm.Size = size;
            Assert.Equal(calories, frm.Calories);
        }

        /// <summary>
        /// Theory test with size and output to test the output of ToString() is what we expect it to be
        /// </summary>
        /// <param name="size">the given size</param>
        /// <param name="name">the expected output</param>
        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak frm = new FriedMiraak();
            frm.Size = size;
            Assert.Equal(name, frm.ToString());
        }
    }
}