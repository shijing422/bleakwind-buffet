using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
/*
 * Author: Shijing Zhang
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Mad Otar Grits
 */

namespace BleakwindBuffet.Data.Drinks
{
    public class MadOtarGrits
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
        /// <summary>
        ///  get the Cal
        /// </summary>
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


            r += "Mad Otar Grits";
            return r;
        }

    }
}

