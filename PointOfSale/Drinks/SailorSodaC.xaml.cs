/*
 * Author: Jacob Beck
 * Class: SailorSodac.xaml.cs
 * Purpose: Represents the xaml class file for sailor soda
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
using BleakwindBuffet.Data.Drinks;
using PointOfSale.ExtensionMethod;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SailorSoda.xaml
    /// </summary>
    public partial class SailorSodaC : UserControl
    {
        /// <summary>
        /// Sailor soda object from Data solution
        /// </summary>
        private SailorSoda ss = new SailorSoda();

        public SailorSodaC()
        {
            InitializeComponent();
            DataContext = ss;
        }

        /// <summary>
        /// A click event that the user presses when they're done customizing their item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SSDone_Click(object sender, RoutedEventArgs e)
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
            if (DataContext is SailorSoda)
            {
                foreach (ComboBoxItem size in e.AddedItems)
                {
                    if (size.Name == "Small") ss.Size = Size.Small;
                    if (size.Name == "Medium") ss.Size = Size.Small;
                    if (size.Name == "Large") ss.Size = Size.Small;
                }
            }
        }
    }
}
