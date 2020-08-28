using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
/*
 * Author: Shijing Zhang
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Dragonborn Waffle Fries
 */

namespace BleakwindBuffet.Data.Drinks
{
    public class DragonbornWaffleFries
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
                    return 0.42;
                }
                if (Size == Size.Medium)
                {
                    return 0.76;
                }
                else
                {
                    return 0.96;
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
                    return 77;
                }
                if (Size == Size.Medium)
                {
                    return 89;
                }
                else
                {
                    return 100;
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


            r += "Dragonborn Waffle Fries";
            return r;
        }

    }
}
