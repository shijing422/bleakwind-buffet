using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
/*
 * Author: Shijing Zhang
 * Class name: CandlehearthCoffee.cs
} * Purpose: Class used to represent the Candlehearth Coffee
 */

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class represent CandlehearthCoffee
    /// </summary>
    public class CandlehearthCoffee
    {
        /// <value>
        /// The 3 sizes of the CandlehearthCoffee
        /// </value>
        public Size Size { get; set; } = Size.Small;

        /// <value>
        /// The price of the CandlehearthCoffee by size
        /// </value>
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
        /// <value>
        ///  The Calories of the CandlehearthCoffee by sizes
        /// </value>
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
        /// <value>
        /// if add ice to the CandlehearthCoffee
        /// </value>
        public bool Ice { get; set; } = false;
        /// <summary>
        /// if add cream to the CandlehearthCoffee
        /// </summary>
        public bool RoomForCream { get; set; } = false;
        public bool Decaf { get; set; } = false;
        /// <value>
        /// special instructions of the CandlehearthCoffee
        /// </value>
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
        /// The string of the name of the CandlehearthCoffee
        /// </summary>
        /// <returns></returns>
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