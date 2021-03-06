﻿/*
 * Author: Jacob Beck
 * Class name: MenuSelectionScreen.xaml.cs
 * Purpose: Class used to represent the customers menu order.
 */
using BleakwindBuffet.Data;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuSelectionScreen.xaml
    /// </summary>
    public partial class MenuSelectionScreen : UserControl
    {
        public MenuSelectionScreen()
        {
            InitializeComponent();
        }


        public void SwapScreen(FrameworkElement framework)
        {
            containerMenuSelectionBorder.Child = framework;
        }
    }
}
