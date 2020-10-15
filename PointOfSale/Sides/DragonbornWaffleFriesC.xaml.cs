/*
 * Author: Jacob Beck
 * Class: DragonbornWaffleFriesC.xaml.cs
 * Purpose: Represents the xaml class file for dragonborn waffle fries
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
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using PointOfSale.ExtensionMethod;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DragonbornWaffleFries.xaml
    /// </summary>
    public partial class DragonbornWaffleFriesC : UserControl
    {
        public DragonbornWaffleFriesC()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A click event that the user presses when they're done customizing their item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DWFDone_Click(object sender, RoutedEventArgs e)
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
            if (DataContext is DragonbornWaffleFries dwf)
            {
                foreach (ComboBoxItem size in e.AddedItems)
                {
                    if (size.Name == "Small") dwf.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (size.Name == "Medium") dwf.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (size.Name == "Large") dwf.Size = BleakwindBuffet.Data.Enums.Size.Large;
                }
            }
        }
    }
}
