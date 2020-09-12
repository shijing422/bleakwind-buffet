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
    /// <summary>
    /// A class represent the BriarheartBurger
    /// </summary>
    public class BriarheartBurger : Entree, IOrderItem
    {
        /// <value>
        /// the price of BriarheartBurger
        /// </value>
        public override double Price
        {
            get { return 6.32; }

        }
        /// <value>
        /// the Cal of BriarheartBurger
        /// </value>
        public override uint Calories => 743;
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
                return instructions;


            }
            
        }
        /// <summary>
        /// create the string of the name of the BriarheartBurger
        /// </summary>
        /// <returns>A string represent the name of the BriarheartBurger</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }


    }
}
