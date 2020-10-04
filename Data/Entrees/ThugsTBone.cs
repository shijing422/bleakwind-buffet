using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/*
 * Author: Shijing Zhang
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the Philly Poacher entree
 */


namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class represent the ThugsTBone
    /// </summary>
    public class ThugsTBone : Entree,IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <value>
        /// the price of the ThugsTBone
        /// </value>
        public override double Price
        {
            get { return 6.44; }

        }
        /// <value>
        ///  the Cal of the ThugsTBone
        /// </value>
        public override uint Calories => 982;

   
        /// <value>
        /// Setting these to false results in the addition of the corresponding instructions in the SpecialInstructions list
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                // return an empty list 

                return instructions;


            }

        }
        /// <summary>
        /// convert  the ThugsTBone to string
        /// </summary>
        /// <returns>A string name of the ThugsTBone</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }


    }
}


