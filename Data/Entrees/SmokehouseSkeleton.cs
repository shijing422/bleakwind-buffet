using System;
using System.Collections.Generic;
using System.Text;
/*
 * Author: Shijing Zhang
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the Smokehouse Skeleton  entree
 */


namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton 
    {
        /// <summary>
        /// get the price
        /// </summary>
        public double Price
        {
            get { return 5.62; }

        }
        /// <summary>
        ///  get the Cal 
        /// </summary>
        public uint Calories => 602;
        /// <summary>

        /// <summary>
        /// if hold SausageLink
        /// </summary>
        public bool SausageLink { get; set; } = true;
        /// <summary>
        /// if hold egg
        /// </summary>
        public bool Egg { get; set; } = true;
        /// <summary>
        /// if hold HashBrowns
        /// </summary>
        public bool HashBrowns { get; set; } = true;
        /// <summary>
        /// if hold Pancake
        /// </summary>
        public bool Pancake { get; set; } = true;
        /// <summary>
        /// Setting these to false results in the addition of the corresponding instructions in the SpecialInstructions list
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Pancake) instructions.Add("Hold Pancake");
                if (!Egg) instructions.Add("Hold Egg");
                if (!SausageLink) instructions.Add("Hold SausageLink");
                if (!HashBrowns) instructions.Add("Hold HashBrowns");
              
                return instructions;


            }

        }
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }


    }
}

