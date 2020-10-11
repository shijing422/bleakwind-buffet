using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
/*
 * Author: Shijing Zhang
 * Class name: Combo.cs
 * Purpose: Class used to represent the combo
 */


namespace BleakwindBuffet.Data
{        
    /// <summary>
    /// class represent combo
    /// </summary>
    public class Combo : INotifyPropertyChanged, IOrderItem
    {



        ///<value>
        ///PropertyChanged event
        ///</value>
        public event PropertyChangedEventHandler PropertyChanged;
        private Entree entree;
        ///<value>
        ///The Entree in the combo
        ///</value>
        public Entree Entree
        {
            get
            {
                return entree;
            }

            set
            {
                entree = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private Drink drink;
        ///<value>
        ///The Drink Item in the combo
        ///</value>
        public Drink Drink
        {
            get
            {
                return drink;
            }

            set
            {
                drink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private Side side;
        ///<value>
        ///the Side item in the combo
        ///</value>
        public Side Side
        {
            get
            {
                return side;
            }

            set
            {
                side = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <value>
        /// The price of combo
        /// </value>
        public double Price => Entree.Price + Side.Price + Drink.Price - 1;
        /// <value>
        ///  The the Calories ofcombo
        /// </value>
        public uint Calories => Entree.Calories + Side.Calories + Drink.Calories;
        /// <value>
        /// the special instructions of combo
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                instructions.Add(Entree.ToString());
                foreach(string s in Entree.SpecialInstructions)
                {
                    instructions.Add(s);
                }
                instructions.Add(Drink.ToString());
                foreach (string s in Drink.SpecialInstructions)
                {
                    instructions.Add(s);
                }
                instructions.Add(Side.ToString());
                foreach (string s in Side.SpecialInstructions)
                {
                    instructions.Add(s);
                }


                return instructions;


            }

        }
    }
}
