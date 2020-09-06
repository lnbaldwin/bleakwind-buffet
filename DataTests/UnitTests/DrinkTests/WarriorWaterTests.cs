/*
 * Author: Laura Baldwin
 * Date: Sept 6th, 2020
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using Xunit;
using System;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Class of tests to use on the WarriorWater class in BleakwindBuffet.Data.Drinks
    /// </summary>
    public class WarriorWaterTests
    {
        /// <summary>
        /// Fact test to check that Ice is true initially
        /// </summary>
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater wat = new WarriorWater();
            Assert.True(wat.Ice);
        }

        /// <summary>
        /// Fact test to check that the Size of the drink is Small initially
        /// </summary>
        [Fact]
        public void SizeShouldBeSmallByDefault()
        {
            WarriorWater wat = new WarriorWater();
            Assert.Equal(Size.Small, wat.Size);
        }

        /// <summary>
        /// Fact test to check that the LEmon property is false initially
        /// </summary>
        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater wat = new WarriorWater();
            Assert.False(wat.Lemon);
        }

        /// <summary>
        /// Fact test to check that Ice can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater wat = new WarriorWater();
            wat.Ice = false;
            Assert.False(wat.Ice);
            wat.Ice = true;
            Assert.True(wat.Ice);
        }

        /// <summary>
        /// Fact test to check that the Lemon property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater wat = new WarriorWater();
            wat.Lemon = true;
            Assert.True(wat.Lemon);
            wat.Lemon = false;
            Assert.False(wat.Lemon);

        }

        /// <summary>
        /// Fact test to check that the Size property can be toggled between Small, Medium, and Large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater wat = new WarriorWater();
            wat.Size = Size.Medium;
            Assert.Equal(Size.Medium, wat.Size);
            wat.Size = Size.Large;
            Assert.Equal(Size.Large, wat.Size);
            wat.Size = Size.Small;
            Assert.Equal(Size.Small, wat.Size);
        }

        /// <summary>
        /// Theory test with a size and price to check that the price matches the expected price for each size
        /// </summary>
        /// <param name="size">the given size</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater wat = new WarriorWater();
            wat.Size = size;
            Assert.Equal(price, wat.Price);
        }

        /// <summary>
        /// Theory test with a size and calorie count to check that the ammount of calories matches the expected calorie count for each size
        /// </summary>
        /// <param name="size">the given size</param>
        /// <param name="cal">the expected calories</param>
        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater wat = new WarriorWater();
            wat.Size = size;
            Assert.Equal(cal, wat.Calories);
        }

        /// <summary>
        /// Theory test with an includeIce and includeLemon to check that the Special Instructions list contains
        /// what we expect it to in all 4 situations
        /// </summary>
        /// <param name="includeIce">if ice should be included</param>
        /// <param name="includeLemon">if a lemon should be included</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater wat = new WarriorWater();
            wat.Ice = includeIce;
            wat.Lemon = includeLemon;
            if (includeIce) Assert.DoesNotContain("Hold ice", wat.SpecialInstructions);
            if (!includeIce) Assert.Contains("Hold ice", wat.SpecialInstructions);
            if (includeLemon) Assert.Contains("Add lemon", wat.SpecialInstructions);
            if (!includeLemon) Assert.DoesNotContain("Add lemon", wat.SpecialInstructions);
            if (includeIce && !includeLemon) Assert.Empty(wat.SpecialInstructions);
        }

        /// <summary>
        /// Theory test with a size and expected string to check that the ToString method returns what 
        /// we expect based on the size of the order.
        /// </summary>
        /// <param name="size">The size of the drink</param>
        /// <param name="name">The expected output of the ToString() method</param>
        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater wat = new WarriorWater();
            wat.Size = size;
            Assert.Equal(name, wat.ToString());
        }

    }
}
