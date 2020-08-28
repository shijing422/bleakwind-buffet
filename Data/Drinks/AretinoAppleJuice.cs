using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
/*
 * Author: Shijing Zhang
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the AretinoAppleJuice
 */

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice
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
                    return 0.62;
                }
                if (Size == Size.Medium)
                {
                    return 0.87;
                }
                else
                {
                    return 1.01;
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
                    return 44;
                }
                if (Size == Size.Medium)
                {
                    return 88;
                }
                else
                {
                    return 132;
                }

            }

        }
        /// <summary>
        /// if hold ice
        /// </summary>
        public bool Ice { get; set; } = false;
        /// <summary>
        /// special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add Ice");

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


            r += "AretinoAppleJuice";
            return r;
        }

    }
}
