﻿/*
 * Author: Jacob Beck
 * Class: DoubleDraugrC.xaml.cs
 * Purpose: Represents the xaml class file for double draugr
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
using BleakwindBuffet.Data.Entrees;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DoubleDraugr.xaml
    /// </summary>
    public partial class DoubleDraugrC : UserControl
    {
        public DoubleDraugrC()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A click event that the user presses when they're done customizing their item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DDFDone_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            orderControl.SwapScreen(new MenuSelectionScreen());
        }
        
    }
}
