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
    /// Interaction logic for PhillyPoacher.xaml
    /// </summary>
    public partial class PhillyPoacher : UserControl
    {
        public PhillyPoacher()
        {
            InitializeComponent();
        }

        private void PPDone_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            orderControl.SwapScreen(new MenuSelectionScreen());
        }
    }
}
