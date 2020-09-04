using System;
using System.Collections.Generic;
using System.Text;
/*
 * Author: Shijing Zhang
 * Class name: Garden Orc Omelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette  entree
 */


namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// a class represent the  Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette
    {
        /// <value>
        /// the price of the  Garden Orc Omelette
        /// </value>
        public double Price
        {
            get { return 4.57; }

        }
        /// <value>
        ///  the Cal of the  Garden Orc Omelette
        /// </value>
        public uint Calories => 404;


        /// <value>
        /// if hold Broccoli to the Garden Orc Omelette
        /// </value>
        public bool Broccoli { get; set; } = true;
        /// <value>
        /// if hold Mushrooms to the Garden Orc Omelette
        /// </value>
        public bool Mushrooms { get; set; } = true;
        /// <value>
        /// if hold Tomato to the Garden Orc Omelette
        /// </value>
        public bool Tomato { get; set; } = true;
        /// <value>
        /// if hold Cheddar to the Garden Orc Omelette
        /// </value>
        public bool Cheddar { get; set; } = true;
        /// <value>
        /// Setting these to false results in the addition of the corresponding instructions in the SpecialInstructions list
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Cheddar) instructions.Add("Hold cheddar");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");

                return instructions;


            }

        }
        /// <summary>
        /// convert the Garden Orc Omelette to string
        /// </summary>
        /// <returns>A string represent the name of the Garden Orc Omelette</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }


    }
}

