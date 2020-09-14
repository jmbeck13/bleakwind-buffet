using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data;
using NuGet.Frameworks;

namespace DataTests.OtherTests
{
    public class MenuTests
    {
        [Fact]
        public void ShouldContainDrinks()
        {
            List<IOrderItem> drinks = (List<IOrderItem>)Menu.Drinks();

            Assert.Collection(drinks,
                  item => Assert.Contains("Small Aretino Apple Juice", item.ToString()),
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
        }

            [Fact]
        public void ShouldContainSides()
        {
            List<IOrderItem> sides = (List<IOrderItem>)Menu.Sides();

            Assert.Collection(sides,
                  item => Assert.Contains("Small Dragonborn Waffle Fries", item.ToString()),
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
        }

        [Fact]
        public void ShouldContainEntrees()
        {
            List<IOrderItem> entrees = (List<IOrderItem>)Menu.Entrees();

            Assert.Collection(entrees, 
                  item => Assert.Contains("Briarheart Burger", item.ToString()),
                  item => Assert.Contains("Double Draugr", item.ToString()),
                  item => Assert.Contains("Garden Orc Omelette", item.ToString()),
                  item => Assert.Contains("Philly Poacher", item.ToString()),
                  item => Assert.Contains("Smokehouse Skeleton", item.ToString()),
                  item => Assert.Contains("Thalmor Triple", item.ToString()),
                  item => Assert.Contains("Thugs T-Bone", item.ToString()));
        }

        [Fact] 
        public void ShouldBeFullMenu()
        {
            List<IOrderItem> menu = (List<IOrderItem>)Menu.FullMenu();

            Assert.Collection(menu,
                  item => Assert.Contains("Briarheart Burger", item.ToString()),
                  item => Assert.Contains("Double Draugr", item.ToString()),
                  item => Assert.Contains("Garden Orc Omelette", item.ToString()),
                  item => Assert.Contains("Philly Poacher", item.ToString()),
                  item => Assert.Contains("Smokehouse Skeleton", item.ToString()),
                  item => Assert.Contains("Thalmor Triple", item.ToString()),
                  item => Assert.Contains("Thugs T-Bone", item.ToString()),

                  item => Assert.Contains("Small Dragonborn Waffle Fries", item.ToString()),
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
                  item => Assert.Contains("Large Vokun Salad", item.ToString()),

                  item => Assert.Contains("Small Aretino Apple Juice", item.ToString()),
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
        }

        [Fact]
        public void CheckingNumberOfDrinks()
        {
            List<IOrderItem> drinks = (List<IOrderItem>)Menu.Drinks();

            Assert.Equal(33, drinks.Count);
        }

        [Fact]
        public void CheckingNumberOfEntrees()
        {
            List<IOrderItem> entrees = (List<IOrderItem>)Menu.Entrees();

            Assert.Equal(7, entrees.Count);
        }

        [Fact]
        public void CheckingNumberOfSides()
        {
            List<IOrderItem> sides = (List<IOrderItem>)Menu.Sides();

            Assert.Equal(12, sides.Count);
        }
    }
}
