using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
/*
 * Author: Shijing Zhang
 * Class name: SailorSoda.cs
} * Purpose: Class used to represent the Candlehearth Coffee
 */

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
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
                if (Size == Size.Small)
                {
                    return 0.75;
                }
                if (Size == Size.Medium)
                {
                    return 1.25;
                }
                else
                {
                    return 1.75;
                }

            }

        }
        /// <summary>
        ///  get the Cal
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 7;
                }
                if (Size == Size.Medium)
                {
                    return 10;
                }
                else
                {
                    return 20;
                }

            }

        }
        /// <summary>
        /// if add ice
        /// </summary>
        public bool Ice { get; set; } = false;
        /// <summary>
        /// if add cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;
        public bool Decaf { get; set; } = false;
        /// <summary>
        /// special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
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

            if (Decaf)
            {
                r += "Decaf Candlehearth Coffee";

            }
            else
            {
                r += "Candlehearth Coffee";
            }
            
            return r;
        }

    }
}