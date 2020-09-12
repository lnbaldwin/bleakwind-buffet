/*
 * Author: Zachery Brunner
 * Editor: Laura Baldwin
 * Date: Spet 6th 2020
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Class of tests to use on the ThalmorTriple class in BleakwindBuffet.Data.Entrees
    /// </summary>
    public class ThalmorTripleTests
    {
        /// <summary>
        /// Fact test to check that the class ThalmorTriple impliments the IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(tmt);
        }

        /// <summary>
        /// Fact test to check that the ThalmorTriple class inherits from the Entree base class
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(tmt);
        }

        /// <summary>
        /// Fact test to check that the bun is included initially
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            Assert.True(tmt.Bun);
        }

        /// <summary>
        /// Fact test to check that ketchup is included initially
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            Assert.True(tmt.Ketchup);
        }

        /// <summary>
        /// Fact test to check that mustard is included initially
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            Assert.True(tmt.Mustard);
        }

        /// <summary>
        /// Fact test to check that pickle is included initially
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            Assert.True(tmt.Pickle);
        }

        /// <summary>
        /// Fact test to check that cheese is included initially
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            Assert.True(tmt.Cheese);
        }

        /// <summary>
        /// Fact test to check that tomato is included initially
        /// </summary>
        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            Assert.True(tmt.Tomato);
        }

        /// <summary>
        /// Fact test to check that lettuce is included initially
        /// </summary>
        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            Assert.True(tmt.Lettuce);
        }

        /// <summary>
        /// Fact test to check that mayo is included initially
        /// </summary>
        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            Assert.True(tmt.Mayo);
        }

        /// <summary>
        /// Fact test to check that bacon is included initially
        /// </summary>
        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            Assert.True(tmt.Bacon);
        }

        /// <summary>
        /// Fact test to check that egg is included initially
        /// </summary>
        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            Assert.True(tmt.Egg);
        }

        /// <summary>
        /// fact test to check that the bun property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            tmt.Bun = false;
            Assert.False(tmt.Bun);
            tmt.Bun = true;
            Assert.True(tmt.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            tmt.Ketchup = false;
            Assert.False(tmt.Ketchup);
            tmt.Ketchup = true;
            Assert.True(tmt.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            tmt.Mustard = false;
            Assert.False(tmt.Mustard);
            tmt.Mustard = true;
            Assert.True(tmt.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            tmt.Pickle = false;
            Assert.False(tmt.Pickle);
            tmt.Pickle = true;
            Assert.True(tmt.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            tmt.Cheese = false;
            Assert.False(tmt.Cheese);
            tmt.Cheese = true;
            Assert.True(tmt.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            tmt.Tomato = false;
            Assert.False(tmt.Tomato);
            tmt.Tomato = true;
            Assert.True(tmt.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            tmt.Lettuce = false;
            Assert.False(tmt.Lettuce);
            tmt.Lettuce = true;
            Assert.True(tmt.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            tmt.Mayo = false;
            Assert.False(tmt.Mayo);
            tmt.Mayo = true;
            Assert.True(tmt.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            tmt.Bacon = false;
            Assert.False(tmt.Bacon);
            tmt.Bacon = true;
            Assert.True(tmt.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            tmt.Egg = false;
            Assert.False(tmt.Egg);
            tmt.Egg = true;
            Assert.True(tmt.Egg);
        }

        /// <summary>
        /// Fact test to check that the Price property returns what we expect
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            Assert.Equal(8.32, tmt.Price);
        }

        /// <summary>
        /// Fact test to check that the Calories property returns what we expect
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            Assert.Equal((uint)943, tmt.Calories);
        }

        /// <summary>
        /// Theory test with bools for the Bun, Ketchup, Mustard, Pickle, Cheese, Tomato, Lettuce, Mayo,
        /// Bacon, and egg to check that the SpecialInstructions contains what we expect 
        /// when the bools are true, and when they are false
        /// </summary>
        /// <param name="includeBun">if the bun is included</param>
        /// <param name="includeKetchup">if ketchup is included</param>
        /// <param name="includeMustard">if mustard is included</param>
        /// <param name="includePickle">if pickles are included</param>
        /// <param name="includeCheese">if cheese is included</param>
        /// <param name="includeTomato">if tomatos are included</param>
        /// <param name="includeLettuce">if lettuce is included</param>
        /// <param name="includeMayo">if mayo is included</param>
        /// <param name="includeBacon">if bacon is included</param>
        /// <param name="includeEgg">if an egg is included</param>
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple tmt = new ThalmorTriple();
            tmt.Bun = includeBun;
            tmt.Ketchup = includeKetchup;
            tmt.Mustard = includeMustard;
            tmt.Pickle = includePickle;
            tmt.Cheese = includeCheese;
            tmt.Tomato = includeTomato;
            tmt.Lettuce = includeLettuce;
            tmt.Mayo = includeMayo;
            tmt.Bacon = includeBacon;
            tmt.Egg = includeEgg;

            if(includeBun && includeKetchup && includeMustard && includePickle && includeCheese && includeTomato && 
                includeLettuce && includeMayo && includeBacon && includeEgg)
            {
                Assert.Empty(tmt.SpecialInstructions);
            }
            if (!includeBun && !includeKetchup && !includeMustard && !includePickle && !includeCheese && !includeTomato &&
                !includeLettuce && !includeMayo && !includeBacon && !includeEgg)
            {
                Assert.Contains("Hold bun", tmt.SpecialInstructions);
                Assert.Contains("Hold ketchup", tmt.SpecialInstructions);
                Assert.Contains("Hold mustard", tmt.SpecialInstructions);
                Assert.Contains("Hold pickle", tmt.SpecialInstructions);
                Assert.Contains("Hold cheese", tmt.SpecialInstructions);
                Assert.Contains("Hold tomato", tmt.SpecialInstructions);
                Assert.Contains("Hold lettuce", tmt.SpecialInstructions);
                Assert.Contains("Hold mayo", tmt.SpecialInstructions);
                Assert.Contains("Hold bacon", tmt.SpecialInstructions);
                Assert.Contains("Hold egg", tmt.SpecialInstructions);
            }
        }

        /// <summary>
        /// Fact test to check that the ToString() returns what we expect it to
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple tmt = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", tmt.ToString());
        }
    }
}