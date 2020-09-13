using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Drinks;
using System.Linq;

/*
 * Author: Laura Baldwin
 * Last Edited: Sept. 12th 2020
 * Class Name: Menu.cs
 * Purpose: To store methods which return lists populated with specific menu items
*/

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Static class to store methods that return Lists of IOrderItems
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Gives a list containing one instance of each available entree at Bleakwind Buffet
        /// </summary>
        /// <returns>List of IOrderItems containing an instance of each available entree</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new GardenOrcOmelette());
            entrees.Add(new PhillyPoacher());
            entrees.Add(new SmokehouseSkeleton());
            entrees.Add(new ThalmorTriple());
            entrees.Add(new ThugsTBone());
            return entrees;
        }

        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();

            //add the DragonBornWaffleFries:
            sides.Add(new DragonbornWaffleFries());
            DragonbornWaffleFries dbfMed = new DragonbornWaffleFries{ Size = Size.Medium };
            sides.Add(dbfMed);
            DragonbornWaffleFries dbfLrg = new DragonbornWaffleFries { Size = Size.Large };
            sides.Add(dbfLrg);

            //add the FriedMiraak:
            sides.Add(new FriedMiraak());
            FriedMiraak frmMed = new FriedMiraak { Size = Size.Medium };
            sides.Add(frmMed);
            FriedMiraak frmLrg = new FriedMiraak { Size = Size.Large };
            sides.Add(frmLrg);

            //add the MadOtarGrits:
            sides.Add(new MadOtarGrits());
            MadOtarGrits mogMed = new MadOtarGrits { Size = Size.Medium };
            sides.Add(mogMed);
            MadOtarGrits mogLrg = new MadOtarGrits { Size = Size.Large };
            sides.Add(mogLrg);

            //add the VokunSalad:
            sides.Add(new VokunSalad());
            VokunSalad vosMed = new VokunSalad { Size = Size.Medium };
            sides.Add(vosMed);
            VokunSalad vosLrg = new VokunSalad { Size = Size.Large };
            sides.Add(vosLrg);

            return sides;
        }
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();

            //add AretinoAppleJuice:
            drinks.Add(new AretinoAppleJuice());
            AretinoAppleJuice ajMed = new AretinoAppleJuice { Size = Size.Medium };
            drinks.Add(ajMed);
            AretinoAppleJuice ajLrg = new AretinoAppleJuice { Size = Size.Large };
            drinks.Add(ajLrg);


            //add CandlhearthCoffee:
            drinks.Add(new CandlehearthCoffee());
            CandlehearthCoffee cofMed = new CandlehearthCoffee { Size = Size.Medium };
            drinks.Add(cofMed);
            CandlehearthCoffee cofLrg = new CandlehearthCoffee { Size = Size.Large };
            drinks.Add(cofLrg);

            //add CaldlehearthCoffee but DECAF:
            CandlehearthCoffee cofDecafSml = new CandlehearthCoffee { Decaf = true };
            drinks.Add(cofDecafSml);
            CandlehearthCoffee cofDecafMed = new CandlehearthCoffee { Size = Size.Medium, Decaf = true };
            drinks.Add(cofDecafMed);
            CandlehearthCoffee cofDecafLrg = new CandlehearthCoffee { Size = Size.Large, Decaf = true };
            drinks.Add(cofDecafLrg);

            //add MarkarthMilk:
            drinks.Add(new MarkarthMilk());
            MarkarthMilk milkMed = new MarkarthMilk { Size = Size.Medium };
            drinks.Add(milkMed);
            MarkarthMilk milkLrg = new MarkarthMilk { Size = Size.Large };
            drinks.Add(milkLrg);

            //add WarriorWater:
            drinks.Add(new WarriorWater());
            WarriorWater watMed = new WarriorWater { Size = Size.Medium };
            drinks.Add(watMed);
            WarriorWater watLrg = new WarriorWater { Size = Size.Large };
            drinks.Add(watLrg);

            //add cherry SailorSoda:
            drinks.Add(new SailorSoda());
            SailorSoda cherrySodaMed = new SailorSoda { Size = Size.Medium };
            drinks.Add(cherrySodaMed);
            SailorSoda cherrySodaLrg = new SailorSoda { Size = Size.Large };
            drinks.Add(cherrySodaLrg);

            //add blackberry SailorSoda:
            SailorSoda blackberrySodaSml = new SailorSoda { Flavor = SodaFlavor.Blackberry };
            drinks.Add(blackberrySodaSml);
            SailorSoda blackberrySodaMed = new SailorSoda { Size = Size.Medium, Flavor = SodaFlavor.Blackberry };
            drinks.Add(blackberrySodaMed);
            SailorSoda blackberrySodaLrg = new SailorSoda { Size = Size.Large, Flavor = SodaFlavor.Blackberry };
            drinks.Add(blackberrySodaLrg);

            //add grapefruit SailorSoda:
            SailorSoda grapefruitSodaSml = new SailorSoda { Flavor = SodaFlavor.Grapefruit };
            drinks.Add(grapefruitSodaSml);
            SailorSoda grapefruitSodaMed = new SailorSoda { Size = Size.Medium, Flavor = SodaFlavor.Grapefruit };
            drinks.Add(grapefruitSodaMed);
            SailorSoda grapefruitSodaLrg = new SailorSoda { Size = Size.Large, Flavor = SodaFlavor.Grapefruit };
            drinks.Add(grapefruitSodaLrg);

            //add lemon SailorSoda:
            SailorSoda lemonSodaSml = new SailorSoda { Flavor = SodaFlavor.Lemon };
            drinks.Add(lemonSodaSml);
            SailorSoda lemonSodaMed = new SailorSoda { Size = Size.Medium, Flavor = SodaFlavor.Lemon };
            drinks.Add(lemonSodaMed);
            SailorSoda lemonSodaLrg = new SailorSoda { Size = Size.Large, Flavor = SodaFlavor.Lemon };
            drinks.Add(lemonSodaLrg);

            //add peach SailorSoda:
            SailorSoda peachSodaSml = new SailorSoda { Flavor = SodaFlavor.Peach };
            drinks.Add(peachSodaSml);
            SailorSoda peachSodaMed = new SailorSoda { Size = Size.Medium, Flavor = SodaFlavor.Peach };
            drinks.Add(peachSodaMed);
            SailorSoda peachSodaLrg = new SailorSoda { Size = Size.Large, Flavor = SodaFlavor.Peach };
            drinks.Add(peachSodaLrg);

            //add  SailorSoda:
            SailorSoda watermelonSodaSml = new SailorSoda { Flavor = SodaFlavor.Watermelon };
            drinks.Add(watermelonSodaSml);
            SailorSoda watermelonSodaMed = new SailorSoda { Size = Size.Medium, Flavor = SodaFlavor.Watermelon };
            drinks.Add(watermelonSodaMed);
            SailorSoda watermelonSodaLrg = new SailorSoda { Size = Size.Large, Flavor = SodaFlavor.Watermelon };
            drinks.Add(watermelonSodaLrg);

            return drinks;
        }

        /// <summary>
        /// Gives a list containing one instance of each available item on the menu at Bleakwind Buffet
        /// </summary>
        /// <returns>List of IOrderItems containing an instance of each available item on the menu</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> menu = new List<IOrderItem>();
            menu.AddRange(Drinks());
            menu.AddRange(Entrees());
            menu.AddRange(Sides());
            return menu;
        }
    }
}
