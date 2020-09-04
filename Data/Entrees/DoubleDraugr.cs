using System;
using System.Collections.Generic;
using System.Text;
/*
 * Author: Shijing Zhang
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the DoubleDraugr entree
 */


namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class represent Double Draugr
    /// </summary>
    public class DoubleDraugr
    {
        /// <value>
        /// the price of Double Draugr
        /// </value>
        public double Price
        {
            get { return 7.32; }

        }
        /// <value>
        /// the Cal of the Double Draugr
        /// </value>
        public uint Calories => 843;
        /// <value>
        /// if hold ketchup to the Double Draugr
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
            }
        }
        /// <value>
        /// if hold bun to the Double Draugr
        /// </value>
        public bool Bun { get; set; } = true;
        /// <value>
        /// if hold Mustard to the Double Draugr
        /// </value>
        public bool Mustard { get; set; } = true;
        /// <value>
        /// if hold pickle to the Double Draugr
        /// </value>
        public bool Pickle { get; set; } = true;
        /// <value>
        /// if hold cheese to the Double Draugr
        /// </value>
        public bool Cheese { get; set; } = true;
        /// <value>
        /// if hold tomato to the Double Draugr
        /// </value>
        public bool Tomato { get; set; } = true;
        /// <value>
        /// if hold lettuce to the Double Draugr
        /// </value>
        public bool Lettuce { get; set; } = true;
        /// <value>
        /// if hold mayo to the Double Draugr
        /// </value>
        public bool Mayo { get; set; } = true;
        /// <value>
        /// Setting these to false results in the addition of the corresponding instructions in the SpecialInstructions list
        /// </value>
        public List<string> SpecialInstructions
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
