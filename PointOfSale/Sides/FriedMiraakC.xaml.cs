/*
 * Author: Jacob Beck
 * Class: FriedMiraakC.xaml.cs
 * Purpose: Represents the xaml class file for fried miraak
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data.Sides;
using PointOfSale.ExtensionMethod;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FriedMiraak.xaml
    /// </summary>
    public partial class FriedMiraakC : UserControl
    {
        public FriedMiraakC()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A click event that the user presses when they're done customizing their item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FMDone_Click(object sender, RoutedEventArgs e)
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
            if (DataContext is FriedMiraak fm)
            {
                foreach (ComboBoxItem size in e.AddedItems)
                {
                    if (size.Name == "Small") fm.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (size.Name == "Medium") fm.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (size.Name == "Large") fm.Size = BleakwindBuffet.Data.Enums.Size.Large;
                }
            }
        }
    }
}
