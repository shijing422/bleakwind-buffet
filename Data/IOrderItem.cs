using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    public interface IOrderItem
    {
        /// <value>
        /// The price of this item
        /// </value>
        double Price { get; }
        /// <value>
        /// The calories of this item
        /// </value>
        uint Calories { get; }
        /// <value>
        /// The description of this item
        /// </value>
        string Description { get; }
        /// <value>
        /// The special instructions of this item
        /// </value>
        List<string> SpecialInstructions { get; }
    }
}
