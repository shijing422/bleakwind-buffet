using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
/*
 * Author: Shijing Zhang
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Warrior Water	
 */

namespace BleakwindBuffet.Data.Drinks
{

    public class WarriorWater	
    {
        /// <summary>
        /// size
        /// </summary>
        public Size Size { get; set; } = Size.Small;


        /// <summary>
        /// price
        /// </summary>
        public double Price
        {
            get
            {
                return 0;

            }

        }
        /// <summary>
        ///  get the Cal
        /// </summary>
        public uint Calories
        {
            get
            {
                return 0;
         

            }

        }
        /// <summary>
        /// if hold ice
        /// </summary>
        public bool Ice { get; set; } = true;
        public bool Lemon { get; set; } = false;
        /// <summary>
        /// special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");

                return instructions;


            }

        }
        /// <summary>
        /// tostring
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string r = "";
            switch (Size)
            {
                case Size.Small:
                    r += "[Small]";
                    break;
                case Size.Medium:
                    r += "[Medium]";
                    break;
                case Size.Large:
                    r += "[Large]";
                    break;

            }


            r += "Warrior Water	";
            return r;
        }

    }
}
