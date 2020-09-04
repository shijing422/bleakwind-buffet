using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
/*
 * Author: Shijing Zhang
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent the Dragonborn Waffle Fries
 */

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class represent the Dragonborn Waffle Fries
    /// </summary>
    public class DragonbornWaffleFries
    {
        /// <value>
        /// sizes of the Dragonborn Waffle Fries
        /// </value>
        public Size Size { get; set; } = Size.Small;

        /// <value>
        /// prices of the Dragonborn Waffle Fries by sizes
        /// </value>
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
        /// <value>
        ///  the Cal of the Dragonborn Waffle Fries by sizes
        /// </value>
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
        /// <value>
        /// empty special instructions
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




        /// <summary>
        /// convert the DragonbornWaffleFries to string
        /// </summary>
        /// <returns> A string represent the name of the DragonbornWaffleFries</returns>
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


            r += "Dragonborn Waffle Fries";
            return r;
        }

    }
}
