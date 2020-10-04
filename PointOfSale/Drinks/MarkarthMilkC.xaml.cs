/*
 * Author: Jacob Beck
 * Class: MarkarthMilkC.xaml.cs
 * Purpose: Represents the xaml class file for markarth milk
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
    /// Interaction logic for MarkarthMilk.xaml
    /// </summary>
    public partial class MarkarthMilkC : UserControl
    {
        public MarkarthMilkC()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Markarth Milk object from Data solution
        /// </summary>
        private MarkarthMilk mm = new MarkarthMilk();

        /// <summary>
        /// A click event that the user presses when they're done customizing their item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MMDone_Click(object sender, RoutedEventArgs e)
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
            if (DataContext is MarkarthMilk)
            {
                foreach (ComboBoxItem size in e.AddedItems)
                {
                    if (size.Name == "Small") mm.Size = Size.Small;
                    if (size.Name == "Medium") mm.Size = Size.Small;
                    if (size.Name == "Large") mm.Size = Size.Small;
                }
            }
        }
    }
}
