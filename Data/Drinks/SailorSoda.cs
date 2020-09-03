using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
/*
 * Author: Shijing Zhang
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the SailorSoda drinl
 */

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
    {
        /// <value>
        /// The size of the SailorSoda
        /// </value>
        public Size Size { get; set; } = Size.Small;
        /// <value>
        /// flavor of the SailorSoda
        /// </value>
        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;
        /// <value>
        /// price of the SailorSoda
        /// </value>
        public double Price
        {
            get
            {
                if (Size==Size.Small)
                {
                    return 1.42;
                }
                if (Size == Size.Medium)
                {
                    return 1.74;
                }
                else
                {
                    return 2.07;
                }

            }

        }
        /// <value>
        ///  the calories of the SailorSoda
        /// </value>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 117;
                }
                if (Size == Size.Medium)
                {
                    return 153;
                }
                else
                {
                    return 205;
                }

            }

        }
        /// <value>
        /// if hold ice of the SailorSoda
        /// </value>
        public bool Ice { get; set; } = true;
        /// <value>
        /// special instructions of the SailorSoda
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice == false) instructions.Add("Hold ice");
            
                return instructions;


            }

        }
        /// <summary>
        /// string represent the name of the SailorSoda
        /// </summary>
        /// <returns>A string represent the name of the SailorSoda</returns>
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
            switch (Flavor)
            {
                case SodaFlavor.Cherry:
                    r +="Cherry ";
                    break;
                case SodaFlavor.Blackberry:
                    r += "Blackberry ";
                    break;
                case SodaFlavor.Grapefruit:
                    r += "Grapefruit ";
                    break;
                case SodaFlavor.Lemon:
                    r += "Lemon ";
                    break;
                case SodaFlavor.Peach:
                    r += "Peach ";
                    break;
                case SodaFlavor.Watermelon:
                    r += "Watermelon ";
                    break;


            }
            r += "Sailor Soda";
            return r;
        }

    }
}
