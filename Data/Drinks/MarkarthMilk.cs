using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
/*
 * Author: Shijing Zhang
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent the Markarth Milk
 */

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class represent the MarkarthMilk
    /// </summary>
    public class MarkarthMilk
    {
        /// <value>
        /// The size of the MarkarthMilk
        /// </value>
        public Size Size { get; set; } = Size.Small;

        /// <value>
        /// The price of the MarkarthMilk
        /// </value>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 1.05;
                }
                if (Size == Size.Medium)
                {
                    return 1.11;
                }
                else
                {
                    return 1.22;
                }

            }

        }
        /// <value>
        ///  The Calories of the MarkarthMilk
        /// </value>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 56;
                }
                if (Size == Size.Medium)
                {
                    return 72;
                }
                else
                {
                    return 93;
                }

            }

        }
        /// <value>
        /// if hold ice of the MarkarthMilk
        /// </value>
        public bool Ice { get; set; } = false;//default no ics
        /// <value>
        /// special instructions of the MarkarthMilk
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");

                return instructions;


            }

        }
        /// <summary>
        /// A string of the name of the MarkarthMilk
        /// </summary>
        /// <returns>A string represent the name of the MarkarthMilk</returns>
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

        
            r += "Markarth Milk";
            return r;
        }

    }
}

