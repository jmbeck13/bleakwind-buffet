/*
 * Author: Jacob Beck
 * Class: CandlehearthCoffeeC.xaml.cs
 * Purpose: Represents the xaml class file for candlehearth coffee
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using BleakwindBuffet.Data.Drinks;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PointOfSale.ExtensionMethod;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CandlehearthCoffee.xaml
    /// </summary>
    public partial class CandlehearthCoffeeC : UserControl
    {

        /// <summary>
        /// Candlehearth coffee object from Data solution
        /// </summary>
        private CandlehearthCoffee cc = new CandlehearthCoffee();
        

        public CandlehearthCoffeeC()
        {
            InitializeComponent();
            DataContext = cc;
        }

        /// <summary>
        /// A click event that the user presses when they're done customizing their item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CCDone_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            orderControl.SwapScreen(new MenuSelectionScreen());
        }

        /// <summary>
        /// Changes the size based on what the user chooses.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SizeChange(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is CandlehearthCoffee)
            {
                foreach (ComboBoxItem size in e.AddedItems)
                {
                    if (size.Name == "Small") cc.Size = Size.Small;
                    if (size.Name == "Medium") cc.Size = Size.Small;
                    if (size.Name == "Large") cc.Size = Size.Small;
                }
            }
        }
    }
}
