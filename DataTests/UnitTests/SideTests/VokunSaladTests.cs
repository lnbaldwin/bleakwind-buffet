/*
 * Author: Zachery Brunner
 * Editor: Laura Baldwin
 * Date: Sept 6th 2020
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
    /// Class of tests to use on the VokunSalad class in BleakwindBuffet.Data.Sides
    /// </summary>
    public class VokunSaladTests
    {
        /// <summary>
        /// Fact test to check that the size of the order is Small initially
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad vsd = new VokunSalad();
            Assert.Equal(Size.Small, vsd.Size);
        }

        /// <summary>
        /// Fact test to check that the value of Size can be toggled between Small, Medium, and Large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad vsd = new VokunSalad();
            vsd.Size = Size.Medium;
            Assert.Equal(Size.Medium, vsd.Size);
            vsd.Size = Size.Large;
            Assert.Equal(Size.Large, vsd.Size);
            vsd.Size = Size.Small;
            Assert.Equal(Size.Small, vsd.Size);
        }

        /// <summary>
        /// Fact test to check that the Special Instructions List is empty
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            VokunSalad vsd = new VokunSalad();
            Assert.Empty(vsd.SpecialInstructions);
        }

        /// <summary>
        /// Theory with a size and price to check that the price for the salad is what we expect for each size
        /// </summary>
        /// <param name="size">the size given</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            VokunSalad vsd = new VokunSalad();
            vsd.Size = size;
            Assert.Equal(price, vsd.Price);
        }

        /// <summary>
        /// Theory with a size and calories to check that the calories for the salad is what we expect for each size
        /// </summary>
        /// <param name="size">the size given</param>
        /// <param name="calories">the expected calories</param>
        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad vsd = new VokunSalad();
            vsd.Size = size;
            Assert.Equal(calories, vsd.Calories);
        }

        /// <summary>
        /// Theory test with a size and expected name to test the output of the ToString() method
        /// </summary>
        /// <param name="size">the given size</param>
        /// <param name="name">the expected output</param>
        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            VokunSalad vsd = new VokunSalad();
            vsd.Size = size;
            Assert.Equal(name, vsd.ToString());
        }
    }
}