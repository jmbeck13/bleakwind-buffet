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
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        public OrderComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// REmoves the items from the orderComponent list
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
    }
}
