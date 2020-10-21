using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for CashPaymentButton.xaml
    /// </summary>
    public partial class CashPaymentButton : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public static DependencyProperty CustomerDependecyProperty = DependencyProperty.Register("CustomerQuantity", typeof(int), typeof(CashPaymentButton),
           new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public static DependencyProperty ChangeDependecyProperty = DependencyProperty.Register("ChangeQuantity", typeof(int), typeof(CashPaymentButton),
            new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public CashPaymentButton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Customer value property
        /// </summary>
        public int CustomerQuantity
        {
            get => (int)GetValue(CustomerDependecyProperty);
            set { SetValue(CustomerDependecyProperty, value); }
        }

        /// <summary>
        /// Change value property
        /// </summary>
        public int ChangeQuantity
        {
            get => (int)GetValue(ChangeDependecyProperty);
            set { SetValue(ChangeDependecyProperty, value); }
        }

        /// <summary>
        /// Increments the value 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ButtonValue_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button button)
            {
                switch (button.Name)
                {
                    case "Increment":
                        if (CustomerQuantity >= 0)
                        {
                            CustomerQuantity++;
                        }
                        break;
                    case "Decrement":
                        if(CustomerQuantity > 0)
                        {
                            CustomerQuantity--;
                        }
                        break;
                }
            }
            e.Handled = true;
        }
    }
}
