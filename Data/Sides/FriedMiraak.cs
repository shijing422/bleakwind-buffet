using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
/*
 * Author: Shijing Zhang
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Fried Miraak
 */

namespace BleakwindBuffet.Data.Drinks
{
    public class FriedMiraak
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
                    return 1.78;
                }
                if (Size == Size.Medium)
                {
                    return 2.01;
                }
                else
                {
                    return 2.88;
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
                    return 151;
                }
                if (Size == Size.Medium)
                {
                    return 236;
                }
                else
                {
                    return 306;
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


            r += "Fried Miraak";
            return r;
        }

    }
}
