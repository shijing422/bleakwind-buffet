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
    public class DoubleDraugr
    {
        /// <summary>
        /// get the price
        /// </summary>
        public double Price
        {
            get { return 7.32; }

        }
        /// <summary>
        ///  get the Cal 
        /// </summary>
        public uint Calories => 843;
        /// <summary>
        /// if hold ketchup
        /// </summary>
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
        /// <summary>
        /// if hold bun
        /// </summary>
        public bool Bun { get; set; } = true;
        /// <summary>
        /// if hold Mustard
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        /// if hold pickle
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// if hold cheese
        /// </summary>
        public bool Cheese { get; set; } = true;
        /// <summary>
        /// if hold tomato
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// if hold lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;
        /// <summary>
        /// if hold mayo
        /// </summary>
        public bool Mayo { get; set; } = true;
        /// <summary>
        /// Setting these to false results in the addition of the corresponding instructions in the SpecialInstructions list
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold Bun");
                if (!Ketchup) instructions.Add("Hold Ketup");
                if (!Mustard) instructions.Add("Hold Mustard");
                if (!Pickle) instructions.Add("Hold Pickle");
                if (!Cheese) instructions.Add("Hold Cheese");
                if (!Tomato) instructions.Add("Hold Tomato");
                if (!Lettuce) instructions.Add("Hold Lettuce");
                if (!Mayo) instructions.Add("Hold Mayo");
                return instructions;


            }

        }
        public override string ToString()
        {
            return "Double Draugr";
        }


    }
}
