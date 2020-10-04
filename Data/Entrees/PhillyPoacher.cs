using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/*
 * Author: Shijing Zhang
 * Class name: Philly Poacher.cs
 * Purpose: Class used to represent the Philly Poacher entree
 */


namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Create a class of Philly Poacher
    /// </summary>
    public class PhillyPoacher: Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <value>
        /// the price of Philly Poacher
        /// </value>
        public override double Price
        {
            get { return 7.23; }

        }
        /// <value>
        ///  the Cal of Philly Poacher
        /// </value>
        public override uint Calories => 784;

        private bool sirloin = true;
        /// <value>
        /// if hold Sirloin to Philly Poacher
        /// </value>
        public bool Sirloin
        {
            get
            {
                return sirloin;
            }
            set
            {
                sirloin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool roll = true;
        /// <value>
        /// if hold roll to Philly Poacher
        /// </value>
        public bool Roll
        {
            get
            {
                return roll;
            }
            set
            {
                roll = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool onion = true;
        /// <value>
        /// if hold Onion to Philly Poacher
        /// </value>
        public bool Onion
        {
            get
            {
                return onion;
            }
            set
            {
                onion = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <value>
        /// Setting these to false results in the addition of the corresponding instructions in the SpecialInstructions list
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
               

                return instructions;


            }

        }
        /// <summary>
        /// convert the Philly Poacher to string
        /// </summary>
        /// <returns>A string represent the name of the PhillyPoacher</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }


    }
}

