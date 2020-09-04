using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
/*
 * Author: Shijing Zhang
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent the Mad Otar Grits
 */

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class represent Mad Otar Grits
    /// </summary>
    public class MadOtarGrits
    {
        /// <value>
        /// size of the Mad Otar Grits
        /// </value>
        public Size Size { get; set; } = Size.Small;

        /// <value>
        /// price of the Mad Otar Grits
        /// </value>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 1.22;
                }
                if (Size == Size.Medium)
                {
                    return 1.58;
                }
                else
                {
                    return 1.93;
                }

            }

        }
        /// <value>
        ///  get the Cal of the Mad Otar Grits
        /// </value>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 105;
                }
                if (Size == Size.Medium)
                {
                    return 142;
                }
                else
                {
                    return 179;
                }

            }

        }
        /// <value>
        /// SpecialInstructions of the Mad Otar Grits
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                // return an empty list 

                return instructions;


            }

        }



        /// <value>
        /// convert Mad Otar Grits to string
        /// </value>
        /// <returns> A string represent the name of Mad Otar Grits</returns>
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


            r += "Mad Otar Grits";
            return r;
        }

    }
}

