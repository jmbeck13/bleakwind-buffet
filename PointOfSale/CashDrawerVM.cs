using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using RoundRegister;

namespace BleakwindBuffet.Data
{
    public class CashDrawerVM: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        Order order;

        public CashDrawerVM(Order o)
        {
            order = o;
        }

        public double Subtotal
        {
            get => Math.Round(order.Subtotal,2);
        }

        public double Total
        {
            get => Math.Round(order.Total,2);
        }

        public double Tax
        {
            get => Math.Round(order.Tax,2);
        }

        int ones = RoundRegister.CashDrawer.Dollars;
        /// <summary>
        /// The number of ones from the customer
        /// </summary>
        public int Ones
        {
            get => ones;
            set { ones = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ones")); }
        }

        /// <summary>
        /// The number of twos from the customer
        /// </summary>
        int twos = RoundRegister.CashDrawer.Twos;
        public int Twos
        {
            get => twos;
            set { twos = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Twos")); }
        }

        /// <summary>
        /// The number of fivess from the customer
        /// </summary>
        int fives = RoundRegister.CashDrawer.Fives;
        public int Fives
        {
            get => fives;
            set { fives = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fives")); }
        }

        /// <summary>
        /// The number of tens from the customer
        /// </summary>
        int tens = RoundRegister.CashDrawer.Tens;
        public int Tens
        {
            get => tens;
            set { fives = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tens")); }
        }

        /// <summary>
        /// The number of fifties from the customer
        /// </summary>
        int fifties = RoundRegister.CashDrawer.Fifties;
        public int Fifties
        {
            get => fifties;
            set { fifties = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fifties")); }
        }

        /// <summary>
        /// The number of hundreds from the customer
        /// </summary>
        int hundreds = RoundRegister.CashDrawer.Hundreds;
        public int Hundreds
        {
            get => hundreds;
            set { hundreds = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hundreds")); }
        }

        /// <summary>
        /// The number of pennies from the customer
        /// </summary>
        int oneCent = RoundRegister.CashDrawer.Pennies;
        public int OneCent
        {
            get => oneCent;
            set { oneCent = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OneCent")); }
        }

        /// <summary>
        /// The number of nickels from the customer
        /// </summary>
        int fiveCent = RoundRegister.CashDrawer.Nickels;
        public int FiveCent
        {
            get => fiveCent;
            set { fiveCent = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiveCent")); }
        }

        /// <summary>
        /// The number of dimes from the customer
        /// </summary>
        int tenCent = RoundRegister.CashDrawer.Dimes;
        public int TenCent
        {
            get => tenCent;
            set { tenCent = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TenCent")); }
        }

        /// <summary>
        /// The number of quarters from the customer
        /// </summary>
        int twentyFiveCent = RoundRegister.CashDrawer.Quarters;
        public int TwentyFiveCents
        {
            get => twentyFiveCent;
            set { twentyFiveCent = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentyFiveCents")); }
        }

        /// <summary>
        /// The number of fifty cents from the customer
        /// </summary>
        int fiftyCent = RoundRegister.CashDrawer.HalfDollars;
        public int FiftyCent
        {
            get => fiftyCent;
            set { fiftyCent = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftyCent")); }
        }
    }
}
