using System;
using System.Collections.Generic;
using System.Text;
/*
 * Author: Shijing Zhang
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the Philly Poacher entree
 */


namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsT_Bone 
    {
        /// <summary>
        /// get the price
        /// </summary>
        public double Price
        {
            get { return 6.44; }

        }
        /// <summary>
        ///  get the Cal 
        /// </summary>
        public uint Calories => 982;

   
        /// <summary>
        /// Setting these to false results in the addition of the corresponding instructions in the SpecialInstructions list
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                // return an empty list 

                return instructions;


            }

        }
        public override string ToString()
        {
            return "Thugs T-Bone ";
        }


    }
}


