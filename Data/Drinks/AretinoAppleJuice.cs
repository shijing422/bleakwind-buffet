using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/*
 * Author: Shijing Zhang
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the AretinoAppleJuice
 */

namespace BleakwindBuffet.Data.Drinks
{  /// <summary>
   /// A class create  to represent AretinoAppleJuice
   /// </summary>
    public class AretinoAppleJuice : Drink, IOrderItem, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

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
        /// The price of AretinoAppleJuice by size
        /// </value>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 0.62;
                }
                if (Size == Size.Medium)
                {
                    return 0.87;
                }
                else
                {
                    return 1.01;
                }

            }

        }
        /// <value>
        ///  The the Calories of AretinoAppleJuice by size
        /// </value>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 44;
                }
                if (Size == Size.Medium)
                {
                    return 88;
                }
                else
                {
                    return 132;
                }

            }

        }
        bool i = false;
        /// <value>
        /// if add ice to the AretinoAppleJuice default false
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
        /// special instructions of the AretinoAppleJuice
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
        /// Convert the AretinoAppleJuice to string 
        /// </summary>
        /// <returns>The string represent the name of the AretinoAppleJuice</returns>
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


            r += "Aretino Apple Juice";
            return r;
        }

    }
}
