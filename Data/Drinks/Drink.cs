using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{   /// <summary>
    /// A base class represent the comman property of drink
    /// </summary>
    public abstract class Drink 
    {
        /// <value>
        /// the size of the drink
        /// </value>
        public virtual Size Size { get; set; }
        /// <value>
        /// the price of the drink in us dollars
        /// </value>
        public abstract double Price { get; }
        /// <value>
        /// the cal of the drink
        /// </value>
        public abstract uint Calories { get; }
        /// <value>
        /// the specialinstructions of the drink
        /// </value>
        public abstract List<String> SpecialInstructions { get; }




    }
}
