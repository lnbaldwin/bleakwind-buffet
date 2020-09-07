/*
 * Author: Zachery Brunner
 * Editor: Laura Baldwin
 * Date: Sept 6th 2020
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Class of tests to use on the DoubleDraugr class in BleakwindBuffet.Data.Entrees
    /// </summary>
    public class DoubleDraugrTests
    {   
        /// <summary>
        /// fact test to check that the bun is included initially
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr ddr = new DoubleDraugr();
            Assert.True(ddr.Bun);
        }

        /// <summary>
        /// fact test to check that the ketchup is included initially
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr ddr = new DoubleDraugr();
            Assert.True(ddr.Ketchup);
        }

        /// <summary>
        /// fact test to check that the mustard is included initially
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr ddr = new DoubleDraugr();
            Assert.True(ddr.Mustard);
        }

        /// <summary>
        /// fact test to check that the pickle is included initially
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr ddr = new DoubleDraugr();
            Assert.True(ddr.Pickle);
        }

        /// <summary>
        /// fact test to check that the cheese is included initially
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr ddr = new DoubleDraugr();
            Assert.True(ddr.Cheese);
        }

        /// <summary>
        /// fact test to check that the tomato is included initially
        /// </summary>
        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr ddr = new DoubleDraugr();
            Assert.True(ddr.Tomato);
        }

        /// <summary>
        /// fact test to check that the lettuce is included initially
        /// </summary>
        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr ddr = new DoubleDraugr();
            Assert.True(ddr.Lettuce);
        }

        /// <summary>
        /// fact test to check that the Mayo is included initially
        /// </summary>
        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr ddr = new DoubleDraugr();
            Assert.True(ddr.Mayo);
        }

        /// <summary>
        /// fact test to check that the bun property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr ddr = new DoubleDraugr();
            ddr.Bun = false;
            Assert.False(ddr.Bun);
            ddr.Bun = true;
            Assert.True(ddr.Bun);
        }

        /// <summary>
        /// fact test to check that the ketchup property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr ddr = new DoubleDraugr();
            ddr.Ketchup = false;
            Assert.False(ddr.Ketchup);
            ddr.Ketchup = true;
            Assert.True(ddr.Ketchup);
        }

        /// <summary>
        /// fact test to check that the mustard property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr ddr = new DoubleDraugr();
            ddr.Mustard = false;
            Assert.False(ddr.Mustard);
            ddr.Mustard = true;
            Assert.True(ddr.Mustard);
        }

        /// <summary>
        /// fact test to check that the pickle property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr ddr = new DoubleDraugr();
            ddr.Pickle = false;
            Assert.False(ddr.Pickle);
            ddr.Pickle = true;
            Assert.True(ddr.Pickle);
        }

        /// <summary>
        /// fact test to check that the cheese property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr ddr = new DoubleDraugr();
            ddr.Cheese = false;
            Assert.False(ddr.Cheese);
            ddr.Cheese = true;
            Assert.True(ddr.Cheese);
        }

        /// <summary>
        /// fact test to check that the tomato property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr ddr = new DoubleDraugr();
            ddr.Tomato = false;
            Assert.False(ddr.Tomato);
            ddr.Tomato = true;
            Assert.True(ddr.Tomato);
        }

        /// <summary>
        /// fact test to check that the lettuce property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr ddr = new DoubleDraugr();
            ddr.Lettuce = false;
            Assert.False(ddr.Lettuce);
            ddr.Lettuce = true;
            Assert.True(ddr.Lettuce);
        }

        /// <summary>
        /// fact test to check that the mayo property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr ddr = new DoubleDraugr();
            ddr.Mayo = false;
            Assert.False(ddr.Mayo);
            ddr.Mayo = true;
            Assert.True(ddr.Mayo);
        }

        /// <summary>
        /// Fact test to check that the Price property returns what we expect
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr ddr = new DoubleDraugr();
            Assert.Equal(7.32, ddr.Price);
        }

        /// <summary>
        /// Fact test to check that the Calories property returns what we expect
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr ddr = new DoubleDraugr();
            Assert.Equal((uint)843, ddr.Calories);
        }

        /// <summary>
        /// Theory test with bools for the Bun, Ketchup, Mustard, Pickle, Cheese, Tomato, Lettuce, and Mayo to check that the SpecialInstructions contains
        /// what we expect when the bools are true, and when they are false
        /// </summary>
        /// <param name="includeBun">if the bun is included</param>
        /// <param name="includeKetchup">if ketchup is included</param>
        /// <param name="includeMustard">if mustard is included</param>
        /// <param name="includePickle">if pickles are included</param>
        /// <param name="includeCheese">if cheese is included</param>
        /// <param name="includeTomato">if tomatos are included</param>
        /// <param name="includeLettuce">if lettuce is included</param>
        /// <param name="includeMayo">if mayo is included</param>
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr ddr = new DoubleDraugr();
            ddr.Bun = includeBun;
            ddr.Ketchup = includeKetchup;
            ddr.Mustard = includeMustard;
            ddr.Pickle = includePickle;
            ddr.Cheese = includeCheese;
            ddr.Tomato = includeTomato;
            ddr.Lettuce = includeLettuce;
            ddr.Mayo = includeMayo;

            if(includeBun && includeKetchup && includeMustard && includePickle && includeCheese && includeTomato && includeLettuce && includeMayo)
            {
                Assert.Empty(ddr.SpecialInstructions);
            }
            if(!includeBun && !includeKetchup && !includeMustard && !includePickle && !includeCheese && !includeTomato && !includeLettuce && !includeMayo)
            {
                Assert.Contains("Hold bun", ddr.SpecialInstructions);
                Assert.Contains("Hold ketchup", ddr.SpecialInstructions);
                Assert.Contains("Hold mustard", ddr.SpecialInstructions);
                Assert.Contains("Hold pickle", ddr.SpecialInstructions);
                Assert.Contains("Hold cheese", ddr.SpecialInstructions);
                Assert.Contains("Hold tomato", ddr.SpecialInstructions);
                Assert.Contains("Hold lettuce", ddr.SpecialInstructions);
                Assert.Contains("Hold mayo", ddr.SpecialInstructions);
            }
        }

        /// <summary>
        /// Fact test to check that the ToString() returns what we expect it to
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr ddr = new DoubleDraugr();
            Assert.Equal("Double Draugr", ddr.ToString());
        }
    }
}