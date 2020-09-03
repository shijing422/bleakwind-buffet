using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
/*
 * Author: Shijing Zhang
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the Warrior Water	
 */

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    ///  A class represent the Warrior Water
    /// </summary>
    public class WarriorWater	
    {
        /// <value>
        /// size of Warrior Water
        /// </value>
        public Size Size { get; set; } = Size.Small;


        /// <value>
        /// price of the Warrior Water
        /// </value>
        public double Price
        {
            get
            {
                return 0;

            }

        }
        /// <value>
        ///  calories of the Warrior Water
        /// </value>
        public uint Calories
        {
            get
            {
                return 0;
         

            }

        }
        /// <value>
        /// if hold ice of the Warrior Water
        /// </value>
        public bool Ice { get; set; } = true;
        /// <value>
        /// if add lemon of the Warrior Water
        /// </value>
        public bool Lemon { get; set; } = false;
        /// <value>
        /// special instructions of the Warrior Water
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");

                return instructions;


            }

        }
        /// <summary>
        ///  create a string represent the name of the Warrior Water
        /// </summary>
        /// <returns>A string represent the name of the Warrior Water</returns>
        public override string ToString()
        {
            string r = "";
            switch (Size)
            {
                case Size.Small:
                    r += "Small ";
                    break;
                case Size.Medium:
                    r += "Medium ";
                    break;
                case Size.Large:
                    r += "Large ";
                    break;

            }


            r += "Warrior Water";
            return r;
        }

    }
}
