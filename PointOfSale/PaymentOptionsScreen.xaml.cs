/*
 * Author: Jacob Beck
 * Class name: PaymentOptionScreen.xaml.cs
 * Purpose: Class used to represent the customers menu order.
 */
using BleakwindBuffet.Data;
using PointOfSale.ExtensionMethod;
using RoundRegister;
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
    /// Interaction logic for PaymentOptionsScreen.xaml
    /// </summary>
    public partial class PaymentOptionsScreen : UserControl
    {
        /// <summary>
        /// String to return payment type
        /// </summary>
        public string paymentType = "Card";


        public PaymentOptionsScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click event that handles if the user chooses to pay with card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CardPayment_Click(object sender, RoutedEventArgs e)
        {
            var order = (Order)DataContext;
            var options = CardReader.RunCard(order.Total);

            if (options == CardTransactionResult.Approved)
            {
                PrintReciept();

                var payment = this.FindAncestor<RefactorControl>();
                payment.UpdateDataContext();
                payment.SwapScreen(new MenuSelectionScreen());
            }
            if (options == CardTransactionResult.Declined)
            {
                MessageBox.Show("Sorry, your card has been declined");
            }
            if (options == CardTransactionResult.IncorrectPin)
            {
                MessageBox.Show("Incorrect Pin, please try again");
            }
            if (options == CardTransactionResult.InsufficientFunds)
            {
                MessageBox.Show("Insufficent Funds, please try another card");
            }
            if (options == CardTransactionResult.ReadError)
            {
                MessageBox.Show("Read Error, please try again");
            }
        }

        /// <summary>
        /// Method to print the reciept out
        /// </summary>
        public void PrintReciept()
        {
            var order = (Order)DataContext;

            RecieptPrinter.PrintLine("Order Number: " + order.Number.ToString());
            foreach (IOrderItem item in order.Items)
            {
                RecieptPrinter.PrintLine(item.ToString() + "....$" + item.Price);
                foreach(string s in item.SpecialInstructions)
                {
                    RecieptPrinter.PrintLine(s);
                }
            }
            RecieptPrinter.PrintLine("Subtotal:....$" + order.Subtotal.ToString());
            RecieptPrinter.PrintLine("Tax:....$" + order.Tax.ToString());
            RecieptPrinter.PrintLine("Total:....$" + order.Total.ToString());
            RecieptPrinter.PrintLine("Payment method used: " + paymentType);
            RecieptPrinter.PrintLine("Change Owed:....$0.00"); 
            RecieptPrinter.CutTape();
        }

        /// <summary>
        /// Click event for when the customer pays with cash
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CashPayment_Click(object sender, RoutedEventArgs e)
        {
            var payment = this.FindAncestor<RefactorControl>();
            Order o = (Order)DataContext;
            payment.SwapScreen(new CashPaymentControl(o));
        }

        /// <summary>
        /// Returns the user back to the menu incase they want to make any changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Return_Click(object sender, RoutedEventArgs e)
        {
            var x = this.FindAncestor<RefactorControl>();
            x.SwapScreen(new MenuSelectionScreen());
        }
    }
}
