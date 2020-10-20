/*
 * Author: Jacob Beck
 * Class name: Order.cs
 * Purpose: Class used to represent the customers menu order.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A class representing an order 
    /// </summary>
    public class Order : ICollection, INotifyCollectionChanged, INotifyPropertyChanged
    {
        public ICollection<IOrderItem> order;
        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        /// <summary>
        /// Method to change the property of an item.
        /// </summary>
        /// <param name="name">The name of property we're changing</param>
        protected void InvokePropertyChangedEvent(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        /// <summary>
        /// Turns order into an array
        /// </summary>
        public IEnumerable<IOrderItem> Items => order.ToArray();


        /// <summary>
        /// Constructor for the Order class
        /// </summary>
        public Order()
        {
            order = new List<IOrderItem>();
            Number = nextOrderNumber;
            nextOrderNumber++;
        }

        /// <summary>
        /// The private backing variable for the number of the order
        /// </summary>
        private static int nextOrderNumber = -1;

        /// <summary>
        /// The number of the order
        /// </summary>
        public int Number
        {
            get => nextOrderNumber;
            set { nextOrderNumber = value; }
        }


        /// <summary>
        /// A method to add items to the order
        /// </summary>
        /// <param name="item">The item that's being added to the order</param>
        /// <returns>Returns the order with a newly added item</returns>
        public void Add(IOrderItem item)
        { 
            order.Add(item);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            InvokePropertyChangedEvent("Items");
            InvokePropertyChangedEvent("Subtotal");
            InvokePropertyChangedEvent("Tax");
            InvokePropertyChangedEvent("Total");
            InvokePropertyChangedEvent("Calories");
        }

        /// <summary>
        /// A method to remove items from the order
        /// </summary>
        /// <param name="item">The item that's being removed from the order</param>
        /// <returns>Returns the order without the removed item</returns>
        public void Remove(IOrderItem item)
        {
            if (order.Contains(item))
            {
                order.Remove(item);
                InvokePropertyChangedEvent("Items");
                InvokePropertyChangedEvent("Subtotal");
                InvokePropertyChangedEvent("Tax");
                InvokePropertyChangedEvent("Total");
                InvokePropertyChangedEvent("Calories");
            }
        }

        /// <summary>
        /// Throws a notImplementedException for .CopyTo function
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index"></param>
        void ICollection.CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Throws a notImplementedException for .GetEnumerator function
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index"></param>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return order.GetEnumerator();
        }


        private double salesTaxRate = 0.12;
        /// <summary>
        /// The sales tax rate on the order
        /// </summary>
        public double SalesTaxRate
        {
            get => salesTaxRate;
            set { salesTaxRate = value; }
        }

        /// <summary>
        /// The subtotal of the order
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subtotal = 0.0;
                foreach (IOrderItem item in order)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }

        /// <summary>
        /// The tax on the order
        /// </summary>
        public double Tax
        {
            get => Subtotal * salesTaxRate;
        }

        /// <summary>
        /// The total of the order
        /// </summary>
        public double Total
        {
            get => Subtotal + Tax;
        }


        /// <summary>
        /// The total calories on the order
        /// </summary>
        public uint Calories
        {
            get
            {
                uint cal = 0;
                foreach (IOrderItem item in order)
                {
                    cal += item.Calories;
                }
                return cal;
            }
        }

        /// <summary>
        /// Throws a notImplementedException for .Count function
        /// </summary>
        int ICollection.Count => throw new NotImplementedException();

        /// <summary>
        /// Throws a notImplementedException for .IsSynchronized function
        /// </summary>
        bool ICollection.IsSynchronized => throw new NotImplementedException();

        /// <summary>
        /// Throws a notImplementedException for .SyncRoot function
        /// </summary>
        object ICollection.SyncRoot => throw new NotImplementedException();
    }
}
