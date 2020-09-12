/*
 * Author: Zachery Brunner
 * Editor: Laura Baldwin
 * Date: Sept. 6th 2020
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Class of tests to use on the SailorSoda class in BleakwindBuffet.Data.Drinks
    /// </summary>
    public class SailorSodaTests
    {
        /// <summary>
        /// Fact test to check that the SailorSoda class impliments the IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            SailorSoda soda = new SailorSoda();
            Assert.IsAssignableFrom<IOrderItem>(soda);
        }

        /// <summary>
        /// Fact test to check that the SailorSoda class inherits from the Drink class
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            SailorSoda soda = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(soda);
        }

        /// <summary>
        /// Fact test to check that ice is set to true initially
        /// </summary>
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda soda = new SailorSoda();
            Assert.True(soda.Ice);
        }

        /// <summary>
        /// Fact test to check that the size is set to Small initially
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda soda = new SailorSoda();
            Assert.Equal(Size.Small, soda.Size);
        }
        
        /// <summary>
        /// Fact test to check that the flavor is Cherry initially
        /// </summary>
        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda soda = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, soda.Flavor);
        }

        /// <summary>
        /// Fact test to check that the Ice property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda soda = new SailorSoda();
            soda.Ice = false;
            Assert.False(soda.Ice);
            soda.Ice = true;
            Assert.True(soda.Ice);
        }

        /// <summary>
        /// Fact test to check that the size of the drink cn be toggled between medium, large, and small
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorSoda soda = new SailorSoda();
            soda.Size = Size.Medium;
            Assert.Equal(Size.Medium, soda.Size);
            soda.Size = Size.Large;
            Assert.Equal(Size.Large, soda.Size);
            soda.Size = Size.Small;
            Assert.Equal(Size.Small, soda.Size);
        }

        /// <summary>
        /// Fact test to check that the Flavor of the drink can be toggled between
        /// Blackberry, Cherry, Grapefruit, Lemon, Peach, and Watermelon.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSoda soda = new SailorSoda();
            soda.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, soda.Flavor);
            soda.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, soda.Flavor);
            soda.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, soda.Flavor);
            soda.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, soda.Flavor);
            soda.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, soda.Flavor);
            soda.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, soda.Flavor);
        }

        /// <summary>
        /// Theory test with a size and expected price to check that the price of the soda matches the expected price for the size given
        /// </summary>
        /// <param name="size">The size given</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSoda soda = new SailorSoda();
            soda.Size = size;
            Assert.Equal(price, soda.Price);
        }

        /// <summary>
        /// THeory test with a size and cal count to check that the calories match the expected calories for the size of drink given
        /// </summary>
        /// <param name="size">The size given</param>
        /// <param name="cal">The expected Calorie count</param>
        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda soda = new SailorSoda();
            soda.Size = size;
            Assert.Equal(cal, soda.Calories);
        }

        /// <summary>
        /// Theory test with an includesIce bool to check that the specialInstructions list contains "Hold ice" if false
        /// and is empty when true.
        /// </summary>
        /// <param name="includeIce">if ice is to be included in this order</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorSoda soda = new SailorSoda();
            soda.Ice = includeIce;
            if (includeIce) Assert.Empty(soda.SpecialInstructions);
            else Assert.Contains("Hold ice", soda.SpecialInstructions);
        }
        
        /// <summary>
        /// THeory test with a flavor, size, and name to check that the ToString() method will outpue what we expect it to.
        /// </summary>
        /// <param name="flavor">Flavor of the drink</param>
        /// <param name="size">size of the drink</param>
        /// <param name="name">expected string output of ToString()</param>
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            SailorSoda soda = new SailorSoda();
            
            soda.Size = size;
            soda.Flavor = flavor;

            Assert.Equal(name, soda.ToString());
        }
    }
}
