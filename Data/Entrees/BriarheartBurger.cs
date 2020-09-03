using System;
using System.Collections.Generic;
using System.Text;
/*
 * Author: Shijing Zhang
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the BriarheartBurger entree
 */


namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger
    {
        /// <summary>
        /// get the price of BriarheartBurger
        /// </summary>
        public double Price
        {
            get { return 6.32; }

        }
        /// <summary>
        ///  get the Cal of BriarheartBurger
        /// </summary>
        public uint Calories => 743;
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
                return instructions;


            }
            
        }
        public override string ToString()
        {
            return "Briarheart Burger";
        }


    }
}
