using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System.Collections.Specialized;
using System.Collections;
using System.Linq;
/*
* Author: Shijing Zhang
* Class name: Order.cs
* Purpose: Class used to represent the order
*/

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// clasee represent Order
    /// </summary>
    public class Order : ICollection<IOrderItem>, INotifyPropertyChanged, INotifyCollectionChanged
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public void Clear()
        {
            lists.Clear();
        

        }
        public int Count
        {
            get { return lists.Count; }
        }

        public bool Contains(IOrderItem a)
        {

            throw new NotImplementedException();

        }

        public void CopyTo(IOrderItem[] array, int index)
        {
            throw new NotImplementedException();
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }


        public IEnumerator<IOrderItem> GetEnumerator()
        {
            foreach (IOrderItem i in lists)
            {
                if (i == null)
                {
                    break;
                }
                else
                {
                    yield return i;
                }
            }

        }







        /// <summary>
        /// PropertyChanged event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// CollectionChanged event
        /// </summary>
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        private List<IOrderItem> lists;
        /// <value>
        /// The Sale Tax Rate for the order
        /// </value>
        public double SalesTaxRate { get; set; } = 0.12;
        /// <value>
        /// The Subtotal for the order
        /// </value>
        public double Subtotal
        {
            get
            {
                double subtotal = 0.0;
                foreach (IOrderItem i in lists)
                {
                    subtotal += i.Price;
                }
                return subtotal;
            }
          
        }
        /// <value>
        /// The Tax for the order
        /// </value>
        public double Tax
        {
            get
            {
             
                return Subtotal*SalesTaxRate;
            }

        }
        /// <value>
        /// The Total for the order
        /// </value>
        public double Total
        {
            get
            {

                return Subtotal + Tax;
            }

        }

        /// <value>
        /// The total Calories for the order
        /// </value>
        public uint Calories
        {
            get
            {
                uint c = 0;

                foreach (IOrderItem i in lists)
                {
                    c += i.Calories;
                }
                return c;
            }

        }
        /// <value>
        /// The unique number for the order
        /// </value>
        public int Number { get; }

        private static int nextOrderNumber = 1;


        public Order()
        {
            lists = new List<IOrderItem>();
            Number = nextOrderNumber;
            nextOrderNumber++;

        }


        /// <summary>
        /// Add IOrderItem to the Order
        /// </summary>
        /// <param name="item">IOrderItem add to the order</param>
        public void Add(IOrderItem item)
        {
            lists.Add(item);

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add));
        }
        /// <summary>
        /// Remove IOrderItem to the Order
        /// </summary>
        /// <param name="item">IOrderItem remove to the order</param>
        public bool Remove(IOrderItem item)
        {
            bool result = false;
            for(int i = 0; i<lists.Count; i++)
            {
                IOrderItem curritem = lists[i];
                if(String.Equals(curritem.ToString(), item.ToString()) && (item.SpecialInstructions).SequenceEqual(curritem.SpecialInstructions))
                {
                    result = true;
                    lists.RemoveAt(i);
                    break;
                }
            }


            if(result == true)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtoal"));
                CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove));
            }
            return result;

        }
      


    }
}
