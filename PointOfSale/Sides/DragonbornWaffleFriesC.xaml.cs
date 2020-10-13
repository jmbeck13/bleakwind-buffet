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
    }
}
