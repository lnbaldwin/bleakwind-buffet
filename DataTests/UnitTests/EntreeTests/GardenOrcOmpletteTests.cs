/*
 * Author: Zachery Brunner
 * Editor:Laura Baldwin
 * Date: Sept 6th, 2020
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Class of tests to use on the GardenOrcOmlette class in BleakwindBuffet.Data.Entrees
    /// </summary>
    public class GardenOrcOmeletteTests
    {
        /// <summary>
        /// Fact test to check that the broccoli is included initially
        /// </summary>
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            Assert.True(om.Broccoli);
        }

        /// <summary>
        /// Fact test to check that the mushrooms are included initially
        /// </summary>
        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            Assert.True(om.Mushrooms);
        }

        /// <summary>
        /// Fact test to check that the tomatos are included initially
        /// </summary>
        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            Assert.True(om.Tomato);
        }

        /// <summary>
        /// Fact test to check that the cheddar is included initially
        /// </summary>
        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            Assert.True(om.Cheddar);
        }

        /// <summary>
        /// Fact test to check that the broccoli property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            om.Broccoli = false;
            Assert.False(om.Broccoli);
            om.Broccoli = true;
            Assert.True(om.Broccoli);
        }

        /// <summary>
        /// Fact test to check that the mushrooms property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            om.Mushrooms = false;
            Assert.False(om.Mushrooms);
            om.Mushrooms = true;
            Assert.True(om.Mushrooms);
        }

        /// <summary>
        /// Fact test to check that the tomato property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            om.Tomato = false;
            Assert.False(om.Tomato);
            om.Tomato = true;
            Assert.True(om.Tomato);
        }

        /// <summary>
        /// Fact test to check that the cheddar property can be toggled between true and false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            om.Cheddar = false;
            Assert.False(om.Cheddar);
            om.Cheddar = true;
            Assert.True(om.Cheddar);
        }

        /// <summary>
        /// Fact test to check that the Price property returns what we expect
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            Assert.Equal(4.57, om.Price);
        }

        /// <summary>
        /// Fact test to check that the Calories property returns what we expect
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            Assert.Equal((uint)404, om.Calories);
        }

        /// <summary>
        /// Theory to test with bools for the broccoli, mushrooms, tomatos, and cheddar to check that 
        /// the SpecialInstructions list contains what we expect when the bools are true, and when they're false
        /// </summary>
        /// <param name="includeBroccoli">If broccoli is included</param>
        /// <param name="includeMushrooms">if mushrooms are included</param>
        /// <param name="includeTomato">if tomatos are included</param>
        /// <param name="includeCheddar">if cheddar is included</param>
        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            om.Broccoli = includeBroccoli;
            om.Mushrooms = includeMushrooms;
            om.Tomato = includeTomato;
            om.Cheddar = includeCheddar;

            if(includeBroccoli && includeMushrooms && includeTomato && includeCheddar)
            {
                Assert.Empty(om.SpecialInstructions);
            }

            if(!includeBroccoli && !includeMushrooms && !includeTomato && !includeCheddar)
            {
                Assert.Contains("Hold broccoli", om.SpecialInstructions);
                Assert.Contains("Hold mushrooms", om.SpecialInstructions);
                Assert.Contains("Hold tomato", om.SpecialInstructions);
                Assert.Contains("Hold cheddar", om.SpecialInstructions);
            }
        }

        /// <summary>
        /// Fact test to check that the ToString() returns what we expect it to
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette om = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", om.ToString());
        }
    }
}