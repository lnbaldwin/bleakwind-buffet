/*
 * Author: Zachery Brunner
 * Editor: Laura Baldwin
 * Date: Sept 6th, 2020
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Class of tests to use on the BriarheartBurger class in BleakwindBuffet.Data.Entrees
    /// </summary>
    public class BriarheartBurgerTests
    {
        /// <summary>
        /// Fact test to check that the class BriarheartBurger impliments the IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            BriarheartBurger brg = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(brg);
        }

        /// <summary>
        /// Fact test to check that the BriarheartBurger class inherits from the Entree base class
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            BriarheartBurger brg = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(brg);
        }

        /// <summary>
        /// Fact test to check that the bun is included initially
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger brg = new BriarheartBurger();
            Assert.True(brg.Bun);
        }

        /// <summary>
        /// Fact test to check that ketchup is included initially
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger brg = new BriarheartBurger();
            Assert.True(brg.Ketchup);
        }

        /// <summary>
        /// Fact test to check that mustard is included initially
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger brg = new BriarheartBurger();
            Assert.True(brg.Mustard);
        }

        /// <summary>
        /// Fact test to check that pickle is included initially
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger brg = new BriarheartBurger();
            Assert.True(brg.Pickle);
        }

        /// <summary>
        /// Fact test to check that cheese is included initially
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger brg = new BriarheartBurger();
            Assert.True(brg.Cheese);
        }

        /// <summary>
        /// Fact test to check that the Bun property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger brg = new BriarheartBurger();
            brg.Bun = false;
            Assert.False(brg.Bun);
            brg.Bun = true;
            Assert.True(brg.Bun);
        }

        /// <summary>
        /// Fact test to check that the Ketchup property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger brg = new BriarheartBurger();
            brg.Ketchup = false;
            Assert.False(brg.Ketchup);
            brg.Ketchup = true;
            Assert.True(brg.Ketchup);
        }

        /// <summary>
        /// Fact test to check that the Mustard property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger brg = new BriarheartBurger();
            brg.Mustard = false;
            Assert.False(brg.Mustard);
            brg.Mustard = true;
            Assert.True(brg.Mustard);
        }

        //Fact test to check that the Pickle property can be toggled between true and false
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger brg = new BriarheartBurger();
            brg.Pickle = false;
            Assert.False(brg.Pickle);
            brg.Pickle = true;
            Assert.True(brg.Pickle);
        }

        /// <summary>
        /// Fact test to check that the Cheese property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger brg = new BriarheartBurger();
            brg.Cheese = false;
            Assert.False(brg.Cheese);
            brg.Cheese = true;
            Assert.True(brg.Cheese);
        }

        /// <summary>
        /// Fact test to check that the Price property returns what we expect
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger brg = new BriarheartBurger();
            Assert.Equal(6.32, brg.Price);
        }

        /// <summary>
        /// Fact test to check tha th the Calories property returns what we expect
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger brg = new BriarheartBurger();
            Assert.Equal((uint)743, brg.Calories);
        }

        /// <summary>
        /// Theory test with bools for the Bun, Ketchup, Mustard, Pickle, and Cheese to check that the SpecialInstructions contains
        /// what we expect when the bools are true, and when they are false
        /// </summary>
        /// <param name="includeBun">If the bun is to be included</param>
        /// <param name="includeKetchup">If ketchup is to be included</param>
        /// <param name="includeMustard">If mustard is to be included</param>
        /// <param name="includePickle">If pickle is to be included</param>
        /// <param name="includeCheese">If cheese is to be included</param>
        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger brg = new BriarheartBurger();
            brg.Bun = includeBun;
            brg.Ketchup = includeKetchup;
            brg.Mustard = includeMustard;
            brg.Pickle = includePickle;
            brg.Cheese = includeCheese;
            if(includeBun && includeKetchup && includeMustard && includePickle && includeCheese)
            {
                Assert.Empty(brg.SpecialInstructions);
            }
            
            if(!includeBun && !includeKetchup && !includeMustard && !includePickle && !includeCheese)
            {
                Assert.Contains("Hold bun", brg.SpecialInstructions);
                Assert.Contains("Hold ketchup", brg.SpecialInstructions);
                Assert.Contains("Hold mustard", brg.SpecialInstructions);
                Assert.Contains("Hold pickle", brg.SpecialInstructions);
                Assert.Contains("Hold cheese", brg.SpecialInstructions);
            }
        }

        /// <summary>
        /// Fact test to check that the ToString() returns what we expect it to
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger brg = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", brg.ToString());
        }
    }
}