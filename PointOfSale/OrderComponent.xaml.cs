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
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        public OrderComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Removes the items from the orderComponent list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void RemoveItem_Click(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order && sender is Button button && button.DataContext is IOrderItem item)
            {
                order.Remove(item);
            }
        }

        /// <summary>
        /// Cancels the current order and creates and new one.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {
            var payment = this.FindAncestor<RefactorControl>();
            payment.UpdateDataContext();
        }

        /// <summary>
        /// Completes teh order and brings up the payment screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteOrder_Click(object sender, RoutedEventArgs e)
        {
            var payment = this.FindAncestor<RefactorControl>();
            payment.SwapScreen(new PaymentOptionsScreen());         
        }
    }
}
