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


        private double amountDue = 0;
        /// <summary>
        /// Amount still needed to pay for the order
        /// </summary>
        public double AmountDue
        {
            get
            {
                if (CurrentPayment > 0)
                {
                    amountDue = Total - CurrentPayment;
                }
                else amountDue = Total;

                return amountDue;
            }
        }

        private double currentChangeDue = 0;
        /// <summary>
        /// The amount that the customer has paid so far 
        /// </summary>
        public double CurrentChangeDue
        {
            get { return currentChangeDue; }
            set { currentChangeDue = value; }
        }

        private double currentPayment = 0;
        /// <summary>
        /// The amount that the user has currently paid
        /// </summary>
        public double CurrentPayment
        {
            get
            {
                currentPayment = GivenDollars * 1.00 + GivenTwos * 2.00 + GivenFives * 5.00 + GivenTens * 10.00 + GivenTwenties * 20.0 + GivenFifties * 50.0 + GivenHundreds * 100.0 
                    + GivenPennies * 0.01 + GivenNickels * 0.05 + GivenDimes * 0.10 + GivenQuarters * 0.25 + GivenHalfDollars * 0.50 + GivenChangeDollars * 1.00;
                return currentPayment;
            }
        }

        /// <summary>
        /// Makes the change that is needed to be given back to the customer
        /// </summary>
        public void MakeChange()
        {
            if ((CurrentPayment > Total))
            {
                currentChangeDue = Math.Round(CurrentPayment - Total, 2);

                int payment = (int)currentChangeDue;
                double paymentChange = Math.Round(currentChangeDue - payment, 2);

                ReturnHundreds = payment / 100;
                payment %= 100;

                ReturnFifties = payment / 50;
                payment %= 50;

                ReturnTwenties = payment / 20;
                payment %= 20;

                ReturnTens = payment / 10;
                payment %= 10;

                ReturnFives = payment / 5;
                payment %= 5;

                ReturnTwos = payment / 2;
                payment %= 2;

                ReturnDollars = payment;

                //ReturnCoinDollars = 0;

                ReturnHalfDollars = (int)(paymentChange / 0.50);
                paymentChange %= 0.50;

                ReturnQuarters = (int)(paymentChange / 0.25);
                paymentChange %= 0.25;

                ReturnDimes = (int)(paymentChange / 0.10);
                paymentChange %= 0.10;

                ReturnNickels = (int)(paymentChange / 0.05);
                paymentChange %= 0.05;

                ReturnPennies = (int)(paymentChange / 0.01);
            }
            else
            {
                CurrentChangeDue = 0;
                ReturnHundreds = 0;
                ReturnFifties = 0;
                ReturnTwenties = 0;
                ReturnTens = 0;
                ReturnFives = 0;
                ReturnTwos = 0;
                ReturnDollars = 0;
                ReturnCoinDollars = 0;
                ReturnHalfDollars = 0;
                ReturnQuarters = 0;
                ReturnDimes = 0;
                ReturnNickels = 0;
                ReturnPennies = 0;
            }

        }

        /// <summary>
        /// The number of ones from the cash register
        /// </summary>
        public int Ones
        {
            get => CashDrawer.Dollars;
            set { CashDrawer.Dollars = value; }
        }

        /// <summary>
        /// The number of twos from the register
        /// </summary>
        public int Twos
        {
            get => CashDrawer.Twos;
            set { CashDrawer.Twos = value; }
        }

        /// <summary>
        /// The number of fivess from the register
        /// </summary>
        public int Fives
        {
            get => CashDrawer.Fives;
            set { CashDrawer.Fives = value; }
        }

        /// <summary>
        /// The number of tens from the register
        /// </summary>
        public int Tens
        {
            get => CashDrawer.Tens;
            set { CashDrawer.Tens = value; }
        }

        /// <summary>
        /// The number of tens from the register
        /// </summary>
        public int Twenties
        {
            get => CashDrawer.Twenties;
            set { CashDrawer.Twenties = value; }
        }

        /// <summary>
        /// The number of fifties from the register
        /// </summary>
        public int Fifties
        {
            get => CashDrawer.Fifties;
            set { CashDrawer.Fifties = value; }
        }

        /// <summary>
        /// The number of hundreds from the register
        /// </summary>
        public int Hundreds
        {
            get => CashDrawer.Hundreds;
            set { CashDrawer.Hundreds = value; }
        }

        /// <summary>
        /// The number of pennies from the register
        /// </summary>
        public int OneCent
        {
            get => CashDrawer.Pennies;
            set { CashDrawer.Pennies = value; }
        }

        /// <summary>
        /// The number of nickels from the register
        /// </summary>
        public int FiveCent
        {
            get => CashDrawer.Nickels;
            set { CashDrawer.Nickels = value;  }
        }

        /// <summary>
        /// The number of dimes from the register
        /// </summary>
        public int TenCent
        {
            get => CashDrawer.Dimes;
            set { CashDrawer.Dimes = value; }
        }

        /// <summary>
        /// The number of quarters from the register
        /// </summary>
        int twentyFiveCent = RoundRegister.CashDrawer.Quarters;
        public int TwentyFiveCents
        {
            get => CashDrawer.Quarters;
            set { CashDrawer.Quarters = value; }
        }

        /// <summary>
        /// The number of fifty cents from the register
        /// </summary>
        public int FiftyCent
        {
            get => CashDrawer.HalfDollars;
            set { CashDrawer.HalfDollars = value; }
        }

        /// <summary>
        /// The number of 1 dollar coins from the register
        /// </summary>
        public int OneCoinCent
        {
            get => CashDrawer.HalfDollars;
            set { CashDrawer.HalfDollars = value; }
        }



        // Given Bills

        private int givenDollars = 0;
        /// <summary>
        /// The amount of dollar bills the customer gives
        /// </summary>
        public int GivenDollars
        {
            get => givenDollars;
            set
            {
                givenDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }

        private int givenTwos = 0;
        /// <summary>
        /// The amount of dollar bills the customer gives
        /// </summary>
        public int GivenTwos
        {
            get => givenTwos;
            set
            {
                givenTwos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenTwos"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }


        private int givenFives = 0;
        /// <summary>
        /// The amount of five dollar bills the customer gives
        /// </summary>
        public int GivenFives
        {
            get => givenFives;
            set
            {
                givenFives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenFives"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }

        private int givenTens = 0;
        /// <summary>
        /// The amount of ten dollar bills the customer gives
        /// </summary>
        public int GivenTens
        {
            get => givenTens;
            set
            {
                givenTens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenTens"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }


        private int givenTwenties = 0;
        /// <summary>
        /// The amount of twenty dollar bills the customer gives
        /// </summary>
        public int GivenTwenties
        {
            get => givenTwenties;
            set
            {
                givenTwenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenTwenties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }


        private int givenFifties = 0;
        /// <summary>
        /// The amount of fifty dollar bills the customer gives
        /// </summary>
        public int GivenFifties
        {
            get => givenFifties;
            set
            {
                givenFifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenFifties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }


        private int givenHundreds = 0;
        /// <summary>
        /// The amount of hundred dollar bills the customer gives
        /// </summary>
        public int GivenHundreds
        {
            get => givenHundreds;
            set
            {
                givenHundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenHundreds"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }

        //Given Change

        private int givenPennies = 0;
        /// <summary>
        /// The amount of pennies the customer gives
        /// </summary>
        public int GivenPennies
        {
            get => givenPennies;
            set
            {
                givenPennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenPennies"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }

        private int givenNickels = 0;
        /// <summary>
        /// The amount of nickles the customer gives
        /// </summary>
        public int GivenNickels
        {
            get => givenNickels;
            set
            {
                givenNickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenNickels"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }

        private int givenDimes = 0;
        /// <summary>
        /// The amount of dimes the customer gives
        /// </summary>
        public int GivenDimes
        {
            get => givenDimes;
            set
            {
                givenDimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenDimes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }

        private int givenQuarters = 0;
        /// <summary>
        /// The amount of quarters the customer gives
        /// </summary>
        public int GivenQuarters
        {
            get => givenQuarters;
            set
            {
                givenQuarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenQuarters"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }

        private int givenHalfDollars = 0;
        /// <summary>
        /// The amount of half dollar coins the customer gives
        /// </summary>
        public int GivenHalfDollars
        {
            get => givenHalfDollars;
            set
            {
                givenHalfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenHalfDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }

        private int givenChangeDollars = 0;
        /// <summary>
        /// The amount of dollar coins the customer gives
        /// </summary>
        public int GivenChangeDollars
        {
            get => givenChangeDollars;
            set
            {
                givenChangeDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenChangeDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                MakeChange();
            }
        }

        // Cash/Change to be given back

        private int returnDollars = 0;
        /// <summary>
        /// The dollar bills that need to be given back
        /// </summary>
        public int ReturnDollars
        {
            get => returnDollars;
            set
            {
                returnDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }


        private int returnTwos = 0;
        /// <summary>
        /// The 2 dollar bills that need to be given back
        /// </summary>
        public int ReturnTwos
        {
            get => returnTwos;
            set
            {
                returnTwos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnTwos"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }


        private int returnFives = 0;
        /// <summary>
        /// The five dollar bills that need to be given back
        /// </summary>
        public int ReturnFives
        {
            get => returnFives;
            set
            {
                returnFives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnFives"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }


        private int returnTens = 0;
        /// <summary>
        /// The ten dollar bills that need to be given back
        /// </summary>
        public int ReturnTens
        {
            get => returnTens;
            set
            {
                returnTens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnTens"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }


        private int returnTwenties = 0;
        /// <summary>
        /// The twenty dollar bills that need to be given back
        /// </summary>
        public int ReturnTwenties
        {
            get => returnTwenties;
            set
            {
                returnTwenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnTwenties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }


        private int returnFifties = 0;
        /// <summary>
        /// The fifty dollar bills that need to be given back
        /// </summary>
        public int ReturnFifties
        {
            get => returnFifties;
            set
            {
                returnFifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnFifties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }


        private int returnHundreds = 0;
        /// <summary>
        /// The hundred dollar bills that need to be given back
        /// </summary>
        public int ReturnHundreds
        {
            get => returnHundreds;
            set
            {
                returnHundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnHundreds"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }

        private int returnPennies = 0;
        /// <summary>
        /// The pennies that need to be given back
        /// </summary>
        public int ReturnPennies
        {
            get => returnPennies;
            set
            {
                returnPennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnPennies"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }


        private int returnNickels = 0;
        /// <summary>
        /// The nickels that need to be given back
        /// </summary>
        public int ReturnNickels
        {
            get => returnNickels;
            set
            {
                returnNickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnNickels"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }

        private int returnDimes = 0;
        /// <summary>
        /// The dimes that need to be given back
        /// </summary>
        public int ReturnDimes
        {
            get => returnDimes;
            set
            {
                returnDimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnDimes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }

        private int returnQuarters = 0;
        /// <summary>
        /// The quarters that need to be given back
        /// </summary>
        public int ReturnQuarters
        {
            get => returnQuarters;
            set
            {
                returnQuarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnQuarters"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }

        private int returnHalfDollars = 0;
        /// <summary>
        /// The half dollar coins that need to be given back
        /// </summary>
        public int ReturnHalfDollars
        {
            get => returnHalfDollars;
            set
            {
                returnHalfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnHalfDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }

        private int returnCoinDollars = 0;
        /// <summary>
        /// The 1 dollar coins that need to be given back
        /// </summary>
        public int ReturnCoinDollars
        {
            get => ReturnCoinDollars;
            set
            {
                returnCoinDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnCoinDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }

       


        /// <summary>
        /// Finalizes the sale and payments
        /// </summary>
        public void FinializeSale()
        {
            OneCent = OneCent - ReturnPennies + GivenPennies;
            FiveCent = FiveCent - ReturnNickels + GivenNickels;
            TenCent = TenCent - ReturnDimes + GivenDimes;
            TwentyFiveCents = TwentyFiveCents - ReturnQuarters + GivenQuarters;
            FiftyCent = FiftyCent - ReturnHalfDollars + GivenHalfDollars;
            OneCoinCent = OneCoinCent - ReturnCoinDollars + GivenChangeDollars;
            Ones = Ones - ReturnDollars + GivenDollars;
            Twos = Twos - ReturnTwos + GivenTwos;
            Fives = Fives - ReturnFives + GivenFives;
            Tens = Tens - ReturnTens + GivenTens;
            Twenties = Twenties - ReturnTwenties + GivenTwenties;
            Fifties = Fifties - ReturnFifties + GivenFifties;
            Hundreds = Hundreds - ReturnHundreds + GivenHundreds;
        }
    }
}
