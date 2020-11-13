using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/*
 * Author: Shijing Zhang
 * Class name: CandlehearthCoffee.cs
} * Purpose: Class used to represent the Candlehearth Coffee
 */

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class represent CandlehearthCoffee drink
    /// </summary>
    public class CandlehearthCoffee : Drink, IOrderItem,INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public override string Description
        {
            get
            {
                string s = "Fair trade, fresh ground dark roast coffee.";
                return s;
            }
        }
        Size s = Size.Small;
        /// <value>
        /// the size of the drink
        /// </value>
        public override Size Size
        {
            get { return s; }
            set
            {
                s = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }


        /// <value>
        /// The price of the CandlehearthCoffee by size
        /// </value>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 0.75;
                }
                if (Size == Size.Medium)
                {
                    return 1.25;
                }
                else
                {
                    return 1.75;
                }

            }

        }
        /// <value>
        ///  The Calories of the CandlehearthCoffee by sizes
        /// </value>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 7;
                }
                if (Size == Size.Medium)
                {
                    return 10;
                }
                else
                {
                    return 20;
                }

            }

        }
        bool i = false;
        /// <value>
        /// if add ice to the CandlehearthCoffee
        /// </value>
        public bool Ice
        {
            get { return i; }
            set
            {
                i = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        bool c = false;
        /// <summary>
        /// if add cream to the CandlehearthCoffee
        /// </summary>
        public bool RoomForCream
        {
            get { return c; }
            set
            {
                c = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        bool d = false;

        /// <summary>
        /// if decaf 
        /// </summary>
        public bool Decaf
        {
            get { return d; }
            set
            {
                d = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
              
            }
        }
        /// <value>
        /// special instructions of the CandlehearthCoffee
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;


            }

        }
        /// <summary>
        /// The string of the name of the CandlehearthCoffee
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string r = "";
            switch (Size)
            {
                case Size.Small:
                    r += "Small ";
                    break;
                case Size.Medium:
                    r += "Medium ";
                    break;
                case Size.Large:
                    r += "Large ";
                    break;

            }

            if (Decaf)
            {
                r += "Decaf Candlehearth Coffee";

            }
            else
            {
                r += "Candlehearth Coffee";
            }
            
            return r;
        }

    }
}