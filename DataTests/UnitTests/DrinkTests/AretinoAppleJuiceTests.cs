/*
 * Author: Zachery Brunner
 * Editor: Laura Baldwin
 * Date: Sept 5th 2020
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Class of tests to use on the AretineAppleJuice class in BleakwindBuffet.Data.Drinks
    /// </summary>
    public class AretinoAppleJuiceTests
    {
        /// <summary>
        /// Fact test to check that the AretinoAppleJuice class impliments the IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }

        /// <summary>
        /// Fact test to check that the AretinoAppleJuice class inherits from the Drink class
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(aj);
        }

        /// <summary>
        /// Fact test to check that the initial value of Ice is false.
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.False(aj.Ice);
        }

        /// <summary>
        /// Fact test to check that the iitial value of Size is Size.Small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.Equal(Size.Small, aj.Size);
        }

        /// <summary>
        /// Fact test to check that the Ice property can be changed from false to true and back to false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Ice = true;
            Assert.True(aj.Ice);
            aj.Ice = false;
            Assert.False(aj.Ice);
        }

        /// <summary>
        /// Fact test to check that the size can be changed between the three Size enums
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = Size.Medium;
            Assert.Equal(Size.Medium, aj.Size);
            aj.Size = Size.Large;
            Assert.Equal(Size.Large, aj.Size);
            aj.Size = Size.Small;
            Assert.Equal(Size.Small, aj.Size);
        }

        /// <summary>
        /// Theory test with a Size enum pram and a double, with the price representing the 
        /// expected price of the drink with respect to the size given
        /// </summary>
        /// <param name="size">the size of the drink</param>
        /// <param name="price">the expected price for the given size</param>
        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(price, aj.Price);
        }

        /// <summary>
        /// Theory test to check that the Calories property is what is expected for each size of drink
        /// </summary>
        /// <param name="size">the size of the drink to test</param>
        /// <param name="cal">the expected calories reported</param>
        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(cal, aj.Calories);

        }

        /// <summary>
        /// Theory test to check that the specialInstructions has the right string in it
        /// if Ice is true; If Ice is false, specialInstuctions should be empty
        /// </summary>
        /// <param name="includeIce">bool to check with Ice being true and false</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Ice = includeIce;
            if (includeIce)
            {
                Assert.Contains("Add ice", aj.SpecialInstructions);
            }
            else
            {
                Assert.Empty(aj.SpecialInstructions);
            }
        }

        /// <summary>
        /// Theory test to check that the outputted string is what we expect for different sizes of orders
        /// </summary>
        /// <param name="size">Size of the order</param>
        /// <param name="name">expected string</param>
        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(name, aj.ToString());
        }
    }
}