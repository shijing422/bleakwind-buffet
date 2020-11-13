using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/*
 * Author: Shijing Zhang
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the Warrior Water	
 */

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    ///  A class represent the Warrior Water
    /// </summary>
    public class WarriorWater : Drink, IOrderItem,INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public override string Description
        {
            get
            {
                string s = "It’s water. Just water.";
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
        /// price of the Warrior Water
        /// </value>
        public override double Price
        {
            get
            {
                return 0;

            }

        }
        /// <value>
        ///  calories of the Warrior Water
        /// </value>
        public override uint Calories
        {
            get
            {
                return 0;
         

            }

        }
        /// <value>
        /// if hold ice of the Warrior Water
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
        /// if add lemon of the Warrior Water
        /// </value>
        bool l = false;
        public bool Lemon
        {
            get { return l; }
            set
            {
                l = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <value>
        /// special instructions of the Warrior Water
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");

                return instructions;


            }

        }
        /// <summary>
        ///  create a string represent the name of the Warrior Water
        /// </summary>
        /// <returns>A string represent the name of the Warrior Water</returns>
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


            r += "Warrior Water";
            return r;
        }

    }
}
