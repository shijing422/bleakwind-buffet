using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/*
 * Author: Shijing Zhang
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent the Markarth Milk
 */

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class represent the MarkarthMilk
    /// </summary>
    public class MarkarthMilk : Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public override string Description
        {
            get
            {
                string s = "Hormone-free organic 2% milk.";
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
        /// The price of the MarkarthMilk
        /// </value>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 1.05;
                }
                if (Size == Size.Medium)
                {
                    return 1.11;
                }
                else
                {
                    return 1.22;
                }

            }

        }
        /// <value>
        ///  The Calories of the MarkarthMilk
        /// </value>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 56;
                }
                if (Size == Size.Medium)
                {
                    return 72;
                }
                else
                {
                    return 93;
                }

            }

        }

        bool i = false;
        /// <value>
        /// if add ice of the MarkarthMilk
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
        /// <value>
        /// special instructions of the MarkarthMilk
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");

                return instructions;


            }

        }
        /// <summary>
        /// A string of the name of the MarkarthMilk
        /// </summary>
        /// <returns>A string represent the name of the MarkarthMilk</returns>
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

        
            r += "Markarth Milk";
            return r;
        }

    }
}

