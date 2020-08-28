using System;
using System.Collections.Generic;
using System.Text;
/*
 * Author: Shijing Zhang
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the Philly Poacher entree
 */


namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {
        /// <summary>
        /// get the price
        /// </summary>
        public double Price
        {
            get { return 7.23; }

        }
        /// <summary>
        ///  get the Cal 
        /// </summary>
        public uint Calories => 784;
        /// <summary>

        /// <summary>
        /// if hold Sirloin
        /// </summary>
        public bool Sirloin { get; set; } = true;
        /// <summary>
        /// if hold  roll
        /// </summary>
        public bool Roll { get; set; } = true;
       
        /// <summary>
        /// if hold Onion
        /// </summary>
        public bool Onion { get; set; } = true;
        /// <summary>
        /// Setting these to false results in the addition of the corresponding instructions in the SpecialInstructions list
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold Sirloin");
                if (!Onion) instructions.Add("Hold Onion");
                if (!Roll) instructions.Add("Hold Roll");
               

                return instructions;


            }

        }
        public override string ToString()
        {
            return "Philly Poacher";
        }


    }
}

