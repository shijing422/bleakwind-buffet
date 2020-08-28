using System;
using System.Collections.Generic;
using System.Text;
/*
 * Author: Shijing Zhang
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the Garden Orc Omelette  entree
 */


namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {
        /// <summary>
        /// get the price
        /// </summary>
        public double Price
        {
            get { return 4.57; }

        }
        /// <summary>
        ///  get the Cal 
        /// </summary>
        public uint Calories => 404;
        /// <summary>

        /// <summary>
        /// if hold Broccoli
        /// </summary>
        public bool Broccoli { get; set; } = true;
        /// <summary>
        /// if hold  Mushrooms
        /// </summary>
        public bool Mushrooms { get; set; } = true;
        /// <summary>
        /// if hold Tomato
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// if hold Cheddar
        /// </summary>
        public bool Cheddar { get; set; } = true;
        /// <summary>
        /// Setting these to false results in the addition of the corresponding instructions in the SpecialInstructions list
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Cheddar) instructions.Add("Hold Cheddar");
                if (!Tomato) instructions.Add("Hold Tomato");
                if (!Broccoli) instructions.Add("Hold Broccoli");
                if (!Mushrooms) instructions.Add("Hold Mushrooms");

                return instructions;


            }

        }
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }


    }
}

