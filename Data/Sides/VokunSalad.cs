using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/*
 * Author: Shijing Zhang
 * Class name:  VokunSalad.cs
 * Purpose: Class used to represent the Vokun Salad
 */

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class represent vokunsalad
    /// </summary>
    public class VokunSalad : Side, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        Size s = Size.Small;
        /// <value>
        /// the size of the side
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
        /// price of the  Vokun Salad
        /// </value>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 0.93;
                }
                if (Size == Size.Medium)
                {
                    return 1.28;
                }
                else
                {
                    return 1.82;
                }

            }

        }
        /// <value>
        ///  get the Cal of the  Vokun Salad
        /// </value>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 41;
                }
                if (Size == Size.Medium)
                {
                    return 52;
                }
                else
                {
                    return 73;
                }

            }

        }
        /// <value>
        ///  SpecialInstructions of the Vokun Salad
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                // return an empty list 

                return instructions;


            }

        }


        /// <summary>
        /// convert vokunsalad to string
        /// </summary>
        /// <returns>A string represent the name of the vokunsalad</returns>
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


            r += "Vokun Salad";
            return r;
        }

    }
}

