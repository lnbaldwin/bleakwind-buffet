/*
 * Author: Zachery Brunner
 * Editor: Laura Baldwin
 * Date: Sept 5th 2020
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Class of tests to use on the MarkarthMilk class in BleakwindBuffet.Data.Drinks
    /// </summary>
    public class MarkarthMilkTests
    {
        /// <summary>
        /// Fact test to check that ice is false initially
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk milk = new MarkarthMilk();
            Assert.False(milk.Ice);
        }

        /// <summary>
        /// Fact test to check that the size is Small initially
        /// </summary>
        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk milk = new MarkarthMilk();
            Assert.Equal(Size.Small, milk.Size);
        }

        /// <summary>
        /// Fact test to check that Ice can be toggled from true to false
        /// </summary>
        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Ice = true;
            Assert.True(milk.Ice);
            milk.Ice = false;
            Assert.False(milk.Ice);
        }

        /// <summary>
        /// Fact test to check that Size can be toggled between Medium, Large, and Small
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Size = Size.Medium;
            Assert.Equal(Size.Medium, milk.Size);
            milk.Size = Size.Large;
            Assert.Equal(Size.Large, milk.Size);
            milk.Size = Size.Small;
            Assert.Equal(Size.Small, milk.Size);
        }

        /// <summary>
        /// Theory Test with a size and expected price to ceck that each size of drink has the expected price value
        /// for that size.
        /// </summary>
        /// <param name="size">The size of the milk</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Size = size;
            Assert.Equal(price, milk.Price);
        }

        /// <summary>
        /// Theory test with a size and calcount to check that each size of drink has the expected calories value for that size.
        /// </summary>
        /// <param name="size">size of the drink</param>
        /// <param name="cal">expected ammount of calories</param>
        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Size = size;
            Assert.Equal(cal, milk.Calories);
        }

        /// <summary>
        /// Theory test with an include ice bool to check that the Special Instructions List contains "Add ice" when true and is 
        /// empty when false.
        /// </summary>
        /// <param name="includeIce">If ice is included in the order</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", milk.SpecialInstructions);
            else Assert.Empty(milk.SpecialInstructions);
        }

        /// <summary>
        /// Theory test with the size and expected string to check that the ToString() method returns what we expect it to when called
        /// </summary>
        /// <param name="size">The size of the drink</param>
        /// <param name="name">the expected string to compare the actual returned string with</param>
        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Size = size;
            Assert.Equal(name, milk.ToString());
        }
    }
}