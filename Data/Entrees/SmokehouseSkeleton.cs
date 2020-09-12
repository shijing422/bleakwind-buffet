using System;
using System.Collections.Generic;
using System.Text;
/*
 * Author: Shijing Zhang
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton  entree
 */


namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// create a class of the Smokehouse Skeleton
    /// </summary>
    public class SmokehouseSkeleton : Entree, IOrderItem
    {
        /// <value>
        /// the price of the Smokehouse Skeleton
        /// </value>
        public override double Price
        {
            get { return 5.62; }

        }
        /// <value>
        ///  the Cal of the Smokehouse Skeleton
        /// </value>
        public override uint Calories => 602;


        /// <value>
        /// if hold SausageLink to the Smokehouse Skeleton
        /// </value>
        public bool SausageLink { get; set; } = true;
        /// <value>
        /// if hold egg to the Smokehouse Skeleton
        /// </value>
        public bool Egg { get; set; } = true;
        /// <value>
        /// if hold HashBrowns to the Smokehouse Skeleton
        /// </value>
        public bool HashBrowns { get; set; } = true;
        /// <value>
        /// if hold Pancake to the Smokehouse Skeleton
        /// </value>
        public bool Pancake { get; set; } = true;
        /// <value>
        /// Setting these to false results in the addition of the corresponding instructions in the SpecialInstructions list
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Pancake) instructions.Add("Hold pancakes");
                if (!Egg) instructions.Add("Hold eggs");
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!HashBrowns) instructions.Add("Hold hash browns");
              
                return instructions;


            }

        }
        /// <summary>
        /// convert the Smokehouse Skeleton to string
        /// </summary>
        /// <returns>A string represent tha name to the Smokehouse Skeleton</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }


    }
}

