using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
/*
 * Author: Shijing Zhang
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the Fried Miraak
 */

namespace BleakwindBuffet.Data.Sides

{
    /// <summary>
    /// Class used to represent the Fried Miraak
    /// </summary>
    public class FriedMiraak
    {
        /// <value>
        /// size of the Fried Miraak
        /// </value>
        public Size Size { get; set; } = Size.Small;

        /// <value>
        /// price of the Fried Miraak
        /// </value>
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
        /// <value>
        /// the Cal of the Fried Miraak
        /// </value>
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
        /// <value>
        /// The empty SpecialInstructions 
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
        /// convert Fried Miraak to string
        /// </summary>
        /// <returns>A string represent the name of the Fried Miraak</returns>
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


            r += "Fried Miraak";
            return r;
        }

    }
}
