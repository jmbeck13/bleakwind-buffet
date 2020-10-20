/*
 * Author: Jacob Beck
 * Class: AretinoAppleJuiceC.xaml.cs
 * Purpose: Represents the xaml class file for aretino apple juice
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using PointOfSale.ExtensionMethod;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ArentinoAppleJuice.xaml
    /// </summary>
    public partial class AretinoAppleJuiceC : UserControl
    {
        /// <summary>
        /// Aretino Apple Juice object from Data solution
        /// </summary>
        private AretinoAppleJuice aj = new AretinoAppleJuice();

        public AretinoAppleJuiceC()
        {
            InitializeComponent();
            DataContext = aj;
        }


        /// <summary>
        /// A click event that the user presses when they're done customizing their item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AAJDone_Click(object sender, RoutedEventArgs e)
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
            if(DataContext is AretinoAppleJuice aj)
            {
                foreach(ComboBoxItem size in e.AddedItems)
                {
                    if (size.Name == "Small") aj.Size = Size.Small;
                    if (size.Name == "Medium") aj.Size = Size.Medium; 
                    if (size.Name == "Large") aj.Size = Size.Large; 
                }
            }
            
        }
    }
}
