/*
 * Author: Zachery Brunner
 * Editor: Laura Baldwin
 * Date: Sept 6th 2020
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Class of tests to use on the MadOtarGrits class in BleakwindBuffet.Data.Sides
    /// </summary>
    public class MadOtarGritsTests
    {
        /// <summary>
        /// Fact test to check that the MadOtarGrits class impliments the IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(mog);
        }

        /// <summary>
        /// Fact test to check that the MadOtarGrits class inherits from the Side base class
        /// </summary>
        [Fact]
        public void ShouldBeASide()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(mog);
        }

        /// <summary>
        /// Fact test to check that the size of the order is Small initially
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.Equal(Size.Small, mog.Size);
        }

        /// <summary>
        /// Fact test to check that the value of Size can be toggled between Small, Medium, and Large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = Size.Medium;
            Assert.Equal(Size.Medium, mog.Size);
            mog.Size = Size.Large;
            Assert.Equal(Size.Large, mog.Size);
            mog.Size = Size.Small;
            Assert.Equal(Size.Small, mog.Size);
        }

        /// <summary>
        /// Fact test to check that the Special Instructions List is empty
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.Empty(mog.SpecialInstructions);
        }

        /// <summary>
        /// Theory with a size and price to check that the price for the grits is what we expect for each size
        /// </summary>
        /// <param name="size">the size given</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = size;
            Assert.Equal(price, mog.Price);
        }

        /// <summary>
        /// Theory with a size and calories to check that the calories for the grits is what we expect for each size
        /// </summary>
        /// <param name="size">the size given</param>
        /// <param name="calories">the expected calories</param>
        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = size;
            Assert.Equal(calories, mog.Calories);
        }

        /// <summary>
        /// Theory test with a size and expected name to test the output of the ToString() method
        /// </summary>
        /// <param name="size">the given size</param>
        /// <param name="name">the expected output</param>
        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = size;
            Assert.Equal(name, mog.ToString());
        }
    }
}