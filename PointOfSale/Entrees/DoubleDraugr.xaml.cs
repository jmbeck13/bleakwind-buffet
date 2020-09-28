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
    /// Interaction logic for DoubleDraugr.xaml
    /// </summary>
    public partial class DoubleDraugr : UserControl
    {
        public DoubleDraugr()
        {
            InitializeComponent();
        }

        private void DDFDone_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MenuSelectionScreen>();

            orderControl.SwapScreen(new MenuSelectionScreen());
        }
    }
}
