using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public abstract class Side
    {
        /// <value>
        /// the size of the side
        /// </value>
        public virtual Size Size { get; set; }
        /// <value>
        /// the price of the side in us dollars
        /// </value>
        public abstract double Price { get; }
        /// <value>
        /// the cal of the side
        /// </value>
        public abstract uint Calories { get; }
        /// <value>
        /// the specialinstructions of the side
        /// </value>
        public abstract List<String> SpecialInstructions { get; }
    }
}
