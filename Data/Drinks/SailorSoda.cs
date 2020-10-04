using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/*
 * Author: Shijing Zhang
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the SailorSoda drinl
 */

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda : Drink, IOrderItem, INotifyPropertyChanged
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
        SodaFlavor f = SodaFlavor.Cherry;
        /// <value>
        /// flavor of the SailorSoda
        /// </value>
        public SodaFlavor Flavor
        {
            get { return f; }
            set
            {
                f = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
            }
        }
        /// <value>
        /// price of the SailorSoda
        /// </value>
        public override double Price
        {
            get
            {
                if (Size==Size.Small)
                {
                    return 1.42;
                }
                if (Size == Size.Medium)
                {
                    return 1.74;
                }
                else
                {
                    return 2.07;
                }

            }

        }
        /// <value>
        ///  the calories of the SailorSoda
        /// </value>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 117;
                }
                if (Size == Size.Medium)
                {
                    return 153;
                }
                else
                {
                    return 205;
                }

            }

        }
        /// <value>
        /// if hold ice of the SailorSoda
        /// </value>
        bool i = true;  
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
        /// special instructions of the SailorSoda
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice == false) instructions.Add("Hold ice");
            
                return instructions;


            }

        }
        /// <summary>
        /// string represent the name of the SailorSoda
        /// </summary>
        /// <returns>A string represent the name of the SailorSoda</returns>
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
            switch (Flavor)
            {
                case SodaFlavor.Cherry:
                    r +="Cherry ";
                    break;
                case SodaFlavor.Blackberry:
                    r += "Blackberry ";
                    break;
                case SodaFlavor.Grapefruit:
                    r += "Grapefruit ";
                    break;
                case SodaFlavor.Lemon:
                    r += "Lemon ";
                    break;
                case SodaFlavor.Peach:
                    r += "Peach ";
                    break;
                case SodaFlavor.Watermelon:
                    r += "Watermelon ";
                    break;


            }
            r += "Sailor Soda";
            return r;
        }

    }
}
