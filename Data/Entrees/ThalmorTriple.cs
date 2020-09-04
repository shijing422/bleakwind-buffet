using System;
using System.Collections.Generic;
using System.Text;
/*
 * Author: Shijing Zhang
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the Thalmor Triple entree
 */


namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple
    {
        /// <summary>
        /// get the price of Thalmor Triple
        /// </summary>
        public double Price
        {
            get { return 8.32; }

        }
        /// <summary>
        ///  get the Cal
        /// </summary>
        public uint Calories => 943;
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
        /// if hold bacon
        /// </summary>
        public bool Bacon { get; set; } = true;
        /// <summary>
        /// if hold egg
        /// </summary>
        public bool Egg { get; set; } = true;
        /// <summary>
        /// Setting these to false results in the addition of the corresponding instructions in the SpecialInstructions list
        /// </summary>
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
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                return instructions;


            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }


    }
}

