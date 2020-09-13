using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data.Drinks;

/*
 * Author: Laura Baldwin
 * Last Edited: Sept. 12th 2020
 * Class Name: MenuTests.cs
 * Purpose: To test the Menu.cs class
*/

namespace BleakwindBuffet.DataTests.UnitTests
{
    /// <summary>
    /// Tests to check the functionality of the Menu class
    /// </summary>
    public class MenuTests
    {

        [Fact]
        public void EntreesShouldReturnAListOfIOrderItems()
        {
            Assert.IsAssignableFrom<List<IOrderItem>>(Menu.Entrees());
        }

        /// <summary>
        /// Fact test to check that entrees returns a list containing all the entree options
        /// </summary>
        [Fact]
        public void EntreesShouldReturnListContainingAllEntrees()
        {
            IEnumerable<IOrderItem> temp = Menu.Entrees();
            if (temp is List<IOrderItem> entreeList)
            {
                Assert.Contains<IOrderItem>(entreeList, (item) => { return item is BriarheartBurger; });
                Assert.Contains<IOrderItem>(entreeList, (item) => { return item is DoubleDraugr; });
                Assert.Contains<IOrderItem>(entreeList, (item) => { return item is GardenOrcOmelette; });
                Assert.Contains<IOrderItem>(entreeList, (item) => { return item is PhillyPoacher; });
                Assert.Contains<IOrderItem>(entreeList, (item) => { return item is SmokehouseSkeleton; });
                Assert.Contains<IOrderItem>(entreeList, (item) => { return item is ThalmorTriple; });
                Assert.Contains<IOrderItem>(entreeList, (item) => { return item is ThugsTBone; });
            }
        }

        /// <summary>
        /// Test to check that the Sides method returns a List of type IOrderItem
        /// </summary>
        [Fact]
        public void SidesShouldReturnAListOfIOrderItems()
        {
            Assert.IsAssignableFrom<List<IOrderItem>>(Menu.Sides());
        }

        /// <summary>
        /// Fact test to check that the Menu.Sides() method returns a list containing all available sizes for each Side order
        /// </summary>
        [Fact]
        public void SidesShouldReturnListContainingAllAvailableSides()
        {
            IEnumerable<IOrderItem> temp = Menu.Sides();
            if (temp is List<IOrderItem> sidesList)
            {
                

                Assert.Contains<IOrderItem>(sidesList, (item) => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
                Assert.Contains<IOrderItem>(sidesList, (item) => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
                Assert.Contains<IOrderItem>(sidesList, (item) => { return item.ToString().Equals("Large Dragonborn Waffle Fries"); });

                Assert.Contains<IOrderItem>(sidesList, (item) => { return item.ToString().Equals("Small Fried Miraak"); });
                Assert.Contains<IOrderItem>(sidesList, (item) => { return item.ToString().Equals("Medium Fried Miraak"); });
                Assert.Contains<IOrderItem>(sidesList, (item) => { return item.ToString().Equals("Large Fried Miraak"); });

                Assert.Contains<IOrderItem>(sidesList, (item) => { return item.ToString().Equals("Small Mad Otar Grits"); });
                Assert.Contains<IOrderItem>(sidesList, (item) => { return item.ToString().Equals("Medium Mad Otar Grits"); });
                Assert.Contains<IOrderItem>(sidesList, (item) => { return item.ToString().Equals("Large Mad Otar Grits"); });

                Assert.Contains<IOrderItem>(sidesList, (item) => { return item.ToString().Equals("Small Vokun Salad"); });
                Assert.Contains<IOrderItem>(sidesList, (item) => { return item.ToString().Equals("Medium Vokun Salad"); });
                Assert.Contains<IOrderItem>(sidesList, (item) => { return item.ToString().Equals("Large Vokun Salad"); });
            }
        }

        /// <summary>
        /// Test to check that the Drinks method returns a List of type IOrderItem
        /// </summary>
        [Fact]
        public void DrinksShouldReturnAListOfIOrderItem()
        {
            Assert.IsAssignableFrom<List<IOrderItem>>(Menu.Drinks());
        }

        /// <summary>
        /// Fact test to check that the Menu.Drinks() method returns a list containing all available sizes for each Drink order
        /// </summary>
        [Fact]
        public void DrinksShouldReturnListContainingAllAvailableDrinks()
        {
            IEnumerable<IOrderItem> temp = Menu.Drinks();
            if (temp is List<IOrderItem> drinksList)
            {
                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Small Aretino Apple Juice"); });
                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Medium Aretino Apple Juice"); });
                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Large Aretino Apple Juice"); });

                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Small Candlehearth Coffee"); });
                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Medium Candlehearth Coffee"); });
                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Large Candlehearth Coffee"); });

                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Small Decaf Candlehearth Coffee"); });
                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Medium Decaf Candlehearth Coffee"); });
                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Large Decaf Candlehearth Coffee"); });

                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Small Markarth Milk"); });
                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Medium Markarth Milk"); });
                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Large Markarth Milk"); });

                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Small Warrior Water"); });
                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Medium Warrior Water"); });
                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Large Warrior Water"); });

                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Small Cherry Sailor Soda"); });
                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Medium Cherry Sailor Soda"); });
                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Large Cherry Sailor Soda"); });

                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Small Blackberry Sailor Soda"); });
                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Medium Blackberry Sailor Soda"); });
                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Large Blackberry Sailor Soda"); });

                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Small Grapefruit Sailor Soda"); });
                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Medium Grapefruit Sailor Soda"); });
                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Large Grapefruit Sailor Soda"); });

                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Small Lemon Sailor Soda"); });
                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Medium Lemon Sailor Soda"); });
                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Large Lemon Sailor Soda"); });

                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Small Peach Sailor Soda"); });
                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Medium Peach Sailor Soda"); });
                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Large Peach Sailor Soda"); });

                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Small Watermelon Sailor Soda"); });
                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Medium Watermelon Sailor Soda"); });
                Assert.Contains<IOrderItem>(drinksList, (item) => { return item.ToString().Equals("Large Watermelon Sailor Soda"); });
            }
        }

        /// <summary>
        /// Test to check that the FullMenu method returns a List of type IOrderItem
        /// </summary>
        [Fact]
        public void FullMenuShouldReturnAListOfIOrderItem()
        {
            Assert.IsAssignableFrom<List<IOrderItem>>(Menu.FullMenu());
        }

        [Fact]
        public void FullMenuShouldContainAllMenuItems()
        {
            IEnumerable<IOrderItem> temp = Menu.FullMenu();
            if(temp is List<IOrderItem> fullMenu)
            {
                //test for entree items:
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item is BriarheartBurger; });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item is DoubleDraugr; });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item is GardenOrcOmelette; });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item is PhillyPoacher; });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item is SmokehouseSkeleton; });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item is ThalmorTriple; });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item is ThugsTBone; });

                //Test for side items:
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Large Dragonborn Waffle Fries"); });

                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Small Fried Miraak"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Medium Fried Miraak"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Large Fried Miraak"); });

                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Small Mad Otar Grits"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Medium Mad Otar Grits"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Large Mad Otar Grits"); });

                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Small Vokun Salad"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Medium Vokun Salad"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Large Vokun Salad"); });

                //Test for drink items:
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Small Aretino Apple Juice"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Medium Aretino Apple Juice"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Large Aretino Apple Juice"); });

                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Small Candlehearth Coffee"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Medium Candlehearth Coffee"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Large Candlehearth Coffee"); });

                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Small Decaf Candlehearth Coffee"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Medium Decaf Candlehearth Coffee"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Large Decaf Candlehearth Coffee"); });

                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Small Markarth Milk"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Medium Markarth Milk"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Large Markarth Milk"); });

                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Small Warrior Water"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Medium Warrior Water"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Large Warrior Water"); });

                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Small Cherry Sailor Soda"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Medium Cherry Sailor Soda"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Large Cherry Sailor Soda"); });

                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Small Blackberry Sailor Soda"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Medium Blackberry Sailor Soda"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Large Blackberry Sailor Soda"); });

                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Small Grapefruit Sailor Soda"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Medium Grapefruit Sailor Soda"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Large Grapefruit Sailor Soda"); });

                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Small Lemon Sailor Soda"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Medium Lemon Sailor Soda"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Large Lemon Sailor Soda"); });

                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Small Peach Sailor Soda"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Medium Peach Sailor Soda"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Large Peach Sailor Soda"); });

                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Small Watermelon Sailor Soda"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Medium Watermelon Sailor Soda"); });
                Assert.Contains<IOrderItem>(fullMenu, (item) => { return item.ToString().Equals("Large Watermelon Sailor Soda"); });
            }
        }
    }
}
