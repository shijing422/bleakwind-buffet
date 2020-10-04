using System;
using System.Collections.Generic;
using System.Text;


namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// a base class represent the property of entree
    /// </summary>
    public abstract class Entree
    {

        /// <value>
        /// the price of the entree in us dollars
        /// </value>
        public abstract double Price { get; }
        /// <value>
        /// the cal of the entree
        /// </value>
        public abstract uint Calories { get; }
        /// <value>
        /// the specialinstructions of the entree
        /// </value>
        public abstract List<String> SpecialInstructions { get; }



    }
}
