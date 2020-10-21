using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.OtherTests
{
    public class CashDrawerVmTests
    {
        [Fact]
        public void ShouldHaveINotifyProperty()
        {
            Order o = new Order();
            CashDrawerVM cashDrawer = new CashDrawerVM(o);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cashDrawer);
        }


        [Fact]
        public void GivenAndReturnShouldBeZeroByDefault ()
        {
            Order o = new Order();
            CashDrawerVM cashDrawer = new CashDrawerVM(o);
            Assert.Equal(0, cashDrawer.CurrentPayment);
            Assert.Equal(0, cashDrawer.AmountDue);
            Assert.Equal(0, cashDrawer.GivenHundreds);
            Assert.Equal(0, cashDrawer.GivenFifties);
            Assert.Equal(0, cashDrawer.GivenTwenties);
            Assert.Equal(0, cashDrawer.GivenTens);
            Assert.Equal(0, cashDrawer.GivenFives);
            Assert.Equal(0, cashDrawer.GivenTwos);
            Assert.Equal(0, cashDrawer.GivenDollars);
            Assert.Equal(0, cashDrawer.GivenChangeDollars);
            Assert.Equal(0, cashDrawer.GivenHalfDollars);
            Assert.Equal(0, cashDrawer.GivenQuarters);
            Assert.Equal(0, cashDrawer.GivenDimes);
            Assert.Equal(0, cashDrawer.GivenNickels);
            Assert.Equal(0, cashDrawer.GivenPennies);

            Assert.Equal(0, cashDrawer.ReturnHundreds);
            Assert.Equal(0, cashDrawer.ReturnFifties);
            Assert.Equal(0, cashDrawer.ReturnTwenties);
            Assert.Equal(0, cashDrawer.ReturnTens);
            Assert.Equal(0, cashDrawer.ReturnFives);
            Assert.Equal(0, cashDrawer.ReturnTwos);
            Assert.Equal(0, cashDrawer.ReturnDollars);
            Assert.Equal(0, cashDrawer.ReturnCoinDollars);
            Assert.Equal(0, cashDrawer.ReturnHalfDollars);
            Assert.Equal(0, cashDrawer.ReturnQuarters);
            Assert.Equal(0, cashDrawer.ReturnDimes);
            Assert.Equal(0, cashDrawer.ReturnNickels);
            Assert.Equal(0, cashDrawer.ReturnPennies);
            Assert.Equal(0, cashDrawer.Total);
        }

        [Fact]
        public void TotalShouldBeZeroByDefault()
        {
            Order o = new Order();
            CashDrawerVM cashDrawer = new CashDrawerVM(o);
            Assert.Equal(0, cashDrawer.Total);
        }

       
    }
}
