using BleakwindBuffet.Data;
using PointOfSale.ExtensionMethod;
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
    /// Interaction logic for CashPaymentControl.xaml
    /// </summary>
    public partial class CashPaymentControl : UserControl
    {

        Order order;
        public CashPaymentControl(Order o)
        {
            InitializeComponent();
            order = o;
            DataContext = new CashDrawerVM(order);
        }


        public void ReturnToOrder_Click(object sender, RoutedEventArgs e)
        {
            var x = this.FindAncestor<RefactorControl>();
            x.SwapScreen(new MenuSelectionScreen());
        }

        public void FinalizeSale_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
