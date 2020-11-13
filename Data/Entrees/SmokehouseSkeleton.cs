using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/*
 * Author: Shijing Zhang
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton  entree
 */


namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// create a class of the Smokehouse Skeleton
    /// </summary>
    public class SmokehouseSkeleton : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <value>
        /// the price of the Smokehouse Skeleton
        /// </value>
        public override double Price
        {
            get { return 5.62; }

        }
        /// <value>
        /// The description of this item
        /// </value>
        public override string Description
        {
            get
            {
                string s = "Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.";
                return s;
            }
        }
        /// <value>
        ///  the Cal of the Smokehouse Skeleton
        /// </value>
        public override uint Calories => 602;

        private bool egg = true;
        private bool sausagelink = true;
        private bool hashbrowns = true;
        private bool pancake = true;

        /// <value>
        /// if hold SausageLink to the Smokehouse Skeleton
        /// </value>
        public bool SausageLink
        {
            get
            {
                return sausagelink;
            }
            set
            {
                sausagelink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <value>
        /// if hold egg to the Smokehouse Skeleton
        /// </value>
        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <value>
        /// if hold HashBrowns to the Smokehouse Skeleton
        /// </value>
        public bool HashBrowns
        {
            get
            {
                return hashbrowns;
            }
            set
            {
                hashbrowns = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <value>
        /// if hold Pancake to the Smokehouse Skeleton
        /// </value>
        public bool Pancake
        {
            get
            {
                return pancake;
            }
            set
            {
                pancake = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
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
                if (!Pancake) instructions.Add("Hold pancakes");
                if (!Egg) instructions.Add("Hold eggs");
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!HashBrowns) instructions.Add("Hold hash browns");
              
                return instructions;


            }

        }
        /// <summary>
        /// convert the Smokehouse Skeleton to string
        /// </summary>
        /// <returns>A string represent tha name to the Smokehouse Skeleton</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }


    }
}

