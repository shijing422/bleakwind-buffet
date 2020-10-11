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
* Class name: Combo.cs
* Purpose: Class used to represent the order
*/

namespace BleakwindBuffet.Data
{
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








        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        private List<IOrderItem> lists;
        public double SalesTaxRate { get; set; } = 0.12;
        
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

        public double Tax
        {
            get
            {
             
                return Subtotal*SalesTaxRate;
            }

        }

        public double Total
        {
            get
            {

                return Subtotal + Tax;
            }

        }


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

        public int Number { get; }

        private static int nextOrderNumber = 1;


        public Order()
        {
            lists = new List<IOrderItem>();
            Number = nextOrderNumber;
            nextOrderNumber++;

        }

        

        public void Add(IOrderItem item)
        {
            lists.Add(item);

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtoal"));
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add));
        }

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
