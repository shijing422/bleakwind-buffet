using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/*
 * Author: Shijing Zhang
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent the DoubleDraugr entree
 */


namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class represent Double Draugr
    /// </summary>
    public class DoubleDraugr : Entree, IOrderItem, INotifyPropertyChanged

    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <value>
        /// the price of Double Draugr
        /// </value>
        public override double Price
        {
            get { return 7.32; }

        }
        /// <value>
        /// the Cal of the Double Draugr
        /// </value>
        public override uint Calories => 843;
        /// <value>
        /// if hold ketchup
        /// </value>
        private bool ketchup = true;
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool bun = true;
        /// <value>
        /// if hold bun
        /// </value>
        public bool Bun
        {
            get
            {
                return bun;
            }
            set
            {
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool mustard = true;
        /// <value>
        /// if hold Mustard
        /// </value>
        public bool Mustard
        {
            get
            {
                return mustard;
            }
            set
            {
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool pickle = true;
        /// <value>
        /// if hold pickle
        /// </value>
        public bool Pickle
        {
            get
            {
                return pickle;
            }
            set
            {
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool cheese = true;
        /// <value>
        /// if hold cheese
        /// </value>
        public bool Cheese
        {
            get
            {
                return cheese;
            }
            set
            {
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool tomato = true;
        /// <value>
        /// if hold tomato
        /// </value>
        public bool Tomato
        {
            get
            {
                return tomato;
            }
            set
            {
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool lettuce = true;
        /// <value>
        /// if hold lettuce to the Double Draugr
        /// </value>
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }
            set
            {
                lettuce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool mayo = true;
        /// <value>
        /// if hold mayo to the Double Draugr
        /// </value>
        public bool Mayo
        {
            get
            {
                return mayo ;
            }
            set
            {
                mayo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
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
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                return instructions;


            }

        }
        /// <summary>
        /// convert DoubleDraugr to string
        /// </summary>
        /// <returns>A string represent Double Draugr</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }


    }
}
