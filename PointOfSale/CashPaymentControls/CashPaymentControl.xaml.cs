using BleakwindBuffet.Data;
using PointOfSale.ExtensionMethod;
using RoundRegister;
using System;
using System.Collections.Generic;
using System.Linq;
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
        Order orderFix;
        CashDrawerVM cashDrawer;
        public CashPaymentControl(Order o)
        {
            InitializeComponent();
            order = o;
            orderFix = o;
            cashDrawer = new CashDrawerVM(order);
            DataContext = cashDrawer;
        }

        /// <summary>
        /// Button click to go back to the order screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ReturnToOrder_Click(object sender, RoutedEventArgs e)
        {
            var x = this.FindAncestor<RefactorControl>();
            x.SwapScreen(new MenuSelectionScreen());
        }

        /// <summary>
        /// Button click to finalizes the sale 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FinalizeSale_Click(object sender, RoutedEventArgs e)
        {
            cashDrawer.OpenDrawer();
            cashDrawer.FinializeSale();
            PrintReciept();
            var newOrder = this.FindAncestor<RefactorControl>();
            newOrder.UpdateDataContext();
            newOrder.SwapScreen(new MenuSelectionScreen());
        }

        /// <summary>
        /// Method to print the reciept out
        /// </summary>
        public void PrintReciept()
        {
            DataContext = orderFix;

            RecieptPrinter.PrintLine("Order Number: " + orderFix.Number.ToString());
            foreach (IOrderItem item in orderFix.Items)
            {
                RecieptPrinter.PrintLine(item.ToString() + "....$" + item.Price);
                foreach (string s in item.SpecialInstructions)
                {
                    RecieptPrinter.PrintLine(s);
                }
            }
            RecieptPrinter.PrintLine("Subtotal:....$" + orderFix.Subtotal.ToString());
            RecieptPrinter.PrintLine("Tax:....$" + orderFix.Tax.ToString());
            RecieptPrinter.PrintLine("Total:....$" + orderFix.Total.ToString());
            RecieptPrinter.PrintLine("Payment method used: Cash");
            RecieptPrinter.PrintLine("Change Owed:....$" + cashDrawer.CurrentChangeDue); // Variable to keep track of change 
            RecieptPrinter.CutTape();
        }
    }
}
