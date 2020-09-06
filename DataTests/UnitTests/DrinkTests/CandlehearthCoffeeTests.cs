/*
 * Author: Zachery Brunner
 * Editor: Laura Baldwin
 * Date: Sept 5th, 2020
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Class of tests to use on the CandlehearthCoffee class in BleakwindBuffet.Data.Drinks
    /// </summary>
    public class CandlehearthCoffeeTests
    {
        /// <summary>
        /// Fact test to check that Ice is false initially
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            Assert.False(cof.Ice);
        }

        /// <summary>
        /// Fact test to check that Decaf is false initially
        /// </summary>
        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            Assert.False(cof.Decaf);
        }

        /// <summary>
        /// Fact test to check that RoomForCream is false initially
        /// </summary>
        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            Assert.False(cof.RoomForCream);
        }

        /// <summary>
        /// Fact test to check that the size of the order is initially Small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            Assert.Equal(Size.Small, cof.Size);
        }

        /// <summary>
        /// Fact test to check that the value of Ice can be changed
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Ice = true;
            Assert.True(cof.Ice);
            cof.Ice = false;
            Assert.False(cof.Ice);
        }

        /// <summary>
        /// Fact test to check that the vlaue of Decaf can be changed
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Decaf = true;
            Assert.True(cof.Decaf);
            cof.Decaf = false;
            Assert.False(cof.Decaf);
        }

        /// <summary>
        /// Fact test to check that the value of RoomForCream can be changed
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.RoomForCream = true;
            Assert.True(cof.RoomForCream);
            cof.RoomForCream = false;
            Assert.False(cof.RoomForCream);
        }

        /// <summary>
        /// Fact test to check that the value of Size can be changed
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Size = Size.Medium;
            Assert.Equal(Size.Medium, cof.Size);
            cof.Size = Size.Large;
            Assert.Equal(Size.Large, cof.Size);
            cof.Size = Size.Small;
            Assert.Equal(Size.Small, cof.Size);
        }

        /// <summary>
        /// Theory test with a size and expected price to check that the returned price
        /// matches the expected price for the specified size
        /// </summary>
        /// <param name="size">Size to test with</param>
        /// <param name="price">expected price to compare against</param>
        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Size = size;
            Assert.Equal(price, cof.Price);
        }

        /// <summary>
        /// Theory test with a size and expected calories to check that the returned calories
        /// matches the expected calories for the specified size
        /// </summary>
        /// <param name="size">size to test with</param>
        /// <param name="cal">expected calories to compare against</param>
        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Size = size;
            Assert.Equal(cal, cof.Calories);
        }

        /// <summary>
        /// Theory test with include ice and include cream bools to check that the object's
        /// specialInstructions list contains what it needs to when they are true, and
        /// that the List is empty whan they are both false.
        /// </summary>
        /// <param name="includeIce">If ice is included</param>
        /// <param name="includeCream">If space for cream is included</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Ice = includeIce;
            cof.RoomForCream = includeCream;
            if (includeIce) Assert.Contains("Add ice", cof.SpecialInstructions);
            if (!includeIce) Assert.DoesNotContain("Add ice", cof.SpecialInstructions);
            if (includeCream) Assert.Contains("Add cream", cof.SpecialInstructions);
            if (!includeCream) Assert.DoesNotContain("Add cream", cof.SpecialInstructions);
            if (!includeIce && !includeCream) Assert.Empty(cof.SpecialInstructions);
        }

        /// <summary>
        /// THeory test with a bool for decaf, a Size for size, and an expected string output
        /// to check that the ToString() function outputs the expected string when called
        /// </summary>
        /// <param name="decaf">If the coffee is decaf</param>
        /// <param name="size">the size of the drink</param>
        /// <param name="name">the expected returned string</param>
        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Size = size;
            cof.Decaf = decaf;

            
            Assert.Equal(name, cof.ToString());
        }
    }
}
