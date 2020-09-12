using System;
using System.Collections.Generic;
using System.Text;
/*
 * Author: Shijing Zhang
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent the Thalmor Triple entree
 */


namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class represent the Thalmor Triple
    /// </summary>
    public class ThalmorTriple: Entree, IOrderItem
    {
        /// <value>
        /// the price of Thalmor Triple
        /// </value>
        public override double Price
        {
            get { return 8.32; }

        }
        /// <value>
        ///  the Cal of the Thalmor Triple
        /// </value>
        public override uint Calories => 943;
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
            }
        }
        /// <value>
        /// if hold bun
        /// </value>
        public bool Bun { get; set; } = true;
        /// <value>
        /// if hold Mustard
        /// </value>
        public bool Mustard { get; set; } = true;
        /// <value>
        /// if hold pickle
        /// </value>
        public bool Pickle { get; set; } = true;
        /// <value>
        /// if hold cheese
        /// </value>
        public bool Cheese { get; set; } = true;
        /// <value>
        /// if hold tomato
        /// </value>
        public bool Tomato { get; set; } = true;
        /// <value>
        /// if hold lettuce
        /// </value>
        public bool Lettuce { get; set; } = true;
        /// <value>
        /// if hold mayo
        /// </value>
        public bool Mayo { get; set; } = true;
        /// <value>
        /// if hold bacon
        /// </value>
        public bool Bacon { get; set; } = true;
        /// <value>
        /// if hold egg
        /// </value>
        public bool Egg { get; set; } = true;
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
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                return instructions;


            }

        }
        /// <summary>
        /// convert  thalmortriple to string
        /// </summary>
        /// <returns>A string represent the name of thalmortriple</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }


    }
}

