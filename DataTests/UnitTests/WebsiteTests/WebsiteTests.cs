using System;
using Xunit;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;
using BleakwindBuffet.Data.Drinks;
using System.Linq;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class WebsiteTests
    {
        [Fact]
        public void AllEntreesAreInEntreesMethod()
        {
            IEnumerable<IOrderItem> e = Menu.Entrees();
            List<IOrderItem> entrees = (List<IOrderItem>)e;

            Assert.Collection(entrees, item => Assert.Contains("Briarheart Burger", item.ToString()),
                                 item => Assert.Contains("Double Draugr", item.ToString()),
                                 item => Assert.Contains("Garden Orc Omelette", item.ToString()),
                                 item => Assert.Contains("Philly Poacher", item.ToString()),
                                 item => Assert.Contains("Smokehouse Skeleton", item.ToString()),
                                 item => Assert.Contains("Thalmor Triple", item.ToString()),
                                 item => Assert.Contains("Thugs T-Bone", item.ToString()));

            Assert.Equal(7, entrees.Count);
        }

        [Fact]
        public void AllSidesAreInSidesMethod()
        {
            IEnumerable<IOrderItem> s = Menu.Sides();
            List<IOrderItem> sides = (List<IOrderItem>)s;

            Assert.Collection(sides, item => Assert.Contains("Small Dragonborn Waffle Fries", item.ToString()),
                                 item => Assert.Contains("Small Fried Miraak", item.ToString()),
                                 item => Assert.Contains("Small Mad Otar Grits", item.ToString()),
                                 item => Assert.Contains("Small Vokun Salad", item.ToString()),
                                 item => Assert.Contains("Medium Dragonborn Waffle Fries", item.ToString()),
                                 item => Assert.Contains("Medium Fried Miraak", item.ToString()),
                                 item => Assert.Contains("Medium Mad Otar Grits", item.ToString()),
                                 item => Assert.Contains("Medium Vokun Salad", item.ToString()),
                                 item => Assert.Contains("Large Dragonborn Waffle Fries", item.ToString()),
                                 item => Assert.Contains("Large Fried Miraak", item.ToString()),
                                 item => Assert.Contains("Large Mad Otar Grits", item.ToString()),
                                 item => Assert.Contains("Large Vokun Salad", item.ToString()));
            Assert.Equal(12, sides.Count);
        }

        [Fact]
        public void AllDrinksAreInDrinksMethod()
        {
            IEnumerable<IOrderItem> d = Menu.Drinks();
            List<IOrderItem> drinks = (List<IOrderItem>)d;

            Assert.Collection(drinks, item => Assert.Contains("Small Aretino Apple Juice", item.ToString()),
                                 item => Assert.Contains("Small Decaf Candlehearth Coffee", item.ToString()),
                                 item => Assert.Contains("Small Candlehearth Coffee", item.ToString()),
                                 item => Assert.Contains("Small Markarth Milk", item.ToString()),
                                 item => Assert.Contains("Small Warrior Water", item.ToString()),
                                 item => Assert.Contains("Small Blackberry Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Small Cherry Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Small Grapefruit Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Small Lemon Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Small Peach Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Small Watermelon Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Medium Aretino Apple Juice", item.ToString()),
                                 item => Assert.Contains("Medium Decaf Candlehearth Coffee", item.ToString()),
                                 item => Assert.Contains("Medium Candlehearth Coffee", item.ToString()),
                                 item => Assert.Contains("Medium Markarth Milk", item.ToString()),
                                 item => Assert.Contains("Medium Warrior Water", item.ToString()),
                                 item => Assert.Contains("Medium Blackberry Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Medium Cherry Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Medium Grapefruit Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Medium Lemon Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Medium Peach Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Medium Watermelon Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Large Aretino Apple Juice", item.ToString()),
                                 item => Assert.Contains("Large Decaf Candlehearth Coffee", item.ToString()),
                                 item => Assert.Contains("Large Candlehearth Coffee", item.ToString()),
                                 item => Assert.Contains("Large Markarth Milk", item.ToString()),
                                 item => Assert.Contains("Large Warrior Water", item.ToString()),
                                 item => Assert.Contains("Large Blackberry Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Large Cherry Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Large Grapefruit Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Large Lemon Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Large Peach Sailor Soda", item.ToString()),
                                 item => Assert.Contains("Large Watermelon Sailor Soda", item.ToString()));
            Assert.Equal(33, drinks.Count);
        }

        [Fact]
        public void SearchFeatureReturnsCorrectResults()
        {
            IEnumerable<IOrderItem> m = Menu.Search(Menu.ReturnFullMenu, "water");
            List<IOrderItem> menu = (List<IOrderItem>)m;
            Assert.Collection(menu, item => Assert.Contains("Small Warrior Water", item.ToString()),
                                    item => Assert.Contains("Small Watermelon Sailor Soda", item.ToString()),
                                    item => Assert.Contains("Medium Warrior Water", item.ToString()),
                                    item => Assert.Contains("Medium Watermelon Sailor Soda", item.ToString()),
                                    item => Assert.Contains("Large Warrior Water", item.ToString()),
                                    item => Assert.Contains("Large Watermelon Sailor Soda", item.ToString()));
            Assert.Equal(6, menu.Count);

        }

        [Fact]
        public void ItemTypeFeatureReturnsCorrectResults()
        {
            IEnumerable<IOrderItem> menu = Menu.ReturnFullMenu;
            string[] category = { "Entree" };
            menu = Menu.FilterByOrderItem(menu, category);
            Assert.Collection(menu, item => Assert.Contains("Briarheart Burger", item.ToString()),
                                    item => Assert.Contains("Double Draugr", item.ToString()),
                                    item => Assert.Contains("Garden Orc Omelette", item.ToString()),
                                    item => Assert.Contains("Philly Poacher", item.ToString()),
                                    item => Assert.Contains("Smokehouse Skeleton", item.ToString()),
                                    item => Assert.Contains("Thalmor Triple", item.ToString()),
                                    item => Assert.Contains("Thugs T-Bone", item.ToString()));
            Assert.Equal(7, menu.Count());
        }


        [Fact]
        public void CaloriesFeatureReturnsCorrectResults()
        {
            IEnumerable<IOrderItem> menu = Menu.ReturnFullMenu;
            menu = Menu.FilterByCalories(menu, 500, 700);
            Assert.Collection(menu, item => Assert.Contains("Smokehouse Skeleton", item.ToString()));
            Assert.Single(menu);
        }


        [Fact]
        public void PriceFeatureReturnsCorrectResults()
        {
            IEnumerable<IOrderItem> menu = Menu.ReturnFullMenu;
            menu = Menu.FilterByPrice(menu, 0, .5);
            Assert.Collection(menu, item => Assert.Contains("Small Dragonborn Waffle Fries", item.ToString()),
                                    item => Assert.Contains("Small Warrior Water", item.ToString()),
                                    item => Assert.Contains("Medium Warrior Water", item.ToString()),
                                    item => Assert.Contains("Large Warrior Water", item.ToString()));
            Assert.Equal(4, menu.Count());
        }

        [Fact]
        public void DescriptionsAreCorrectForDrinks()
        {
            SailorSoda ss = new SailorSoda();
            MarkarthMilk mm = new MarkarthMilk();
            WarriorWater ww = new WarriorWater();
            CandlehearthCoffee cc = new CandlehearthCoffee();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.Equal("Fresh squeezed apple juice.", aj.Description);
            Assert.Equal("An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.", ss.Description);
            Assert.Equal("Hormone-free organic 2% milk.", mm.Description);
            Assert.Equal("It’s water. Just water.", ww.Description);
            Assert.Equal("Fair trade, fresh ground dark roast coffee.", cc.Description);
        }

        [Fact]
        public void DescriptionsAreCorrectForEntrees()
        {
            BriarheartBurger bb = new BriarheartBurger();
            DoubleDraugr dd = new DoubleDraugr();
            ThalmorTriple tt = new ThalmorTriple();
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            GardenOrcOmelette go = new GardenOrcOmelette();
            PhillyPoacher pp = new PhillyPoacher();
            ThugsTBone tb = new ThugsTBone();
            Assert.Equal("Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.", bb.Description);
            Assert.Equal("Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.", dd.Description);
            Assert.Equal("Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.", tt.Description);
            Assert.Equal("Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.", ss.Description);
            Assert.Equal("Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.", go.Description);
            Assert.Equal("Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.", pp.Description);
            Assert.Equal("Juicy T-Bone, not much else to say.", tb.Description);
        }

        [Fact]
        public void DescriptionsAreCorrectForSides()
        {
            VokunSalad vs = new VokunSalad();
            FriedMiraak fm = new FriedMiraak();
            MadOtarGrits mo = new MadOtarGrits();
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            Assert.Equal("A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.", vs.Description);
            Assert.Equal("Perfectly prepared hash brown pancakes.", fm.Description);
            Assert.Equal("Cheesey Grits.", mo.Description);
            Assert.Equal("Crispy fried potato waffle fries.", dw.Description);
        }
    }
}