using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/*
 * Author: Shijing Zhang
 * Class name: Garden Orc Omelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette  entree
 */


namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// a class represent the  Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <value>
        /// The description of this item
        /// </value>
        public override string Description
        {
            get
            {
                string s = "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";
                return s;
            }
        }
        /// <value>
        /// the price of the  Garden Orc Omelette
        /// </value>
        public override double Price
        {
            get { return 4.57; }

        }
        /// <value>
        ///  the Cal of the  Garden Orc Omelette
        /// </value>
        public override uint Calories => 404;

        private bool broccoli = true;
        /// <value>
        /// if hold Broccoli to the Garden Orc Omelette
        /// </value>
        public bool Broccoli
        {
            get
            {
                return broccoli;
            }
            set
            {
                broccoli = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool mushrooms = true;
        /// <value>
        /// if hold Mushrooms to the Garden Orc Omelette
        /// </value>
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }
            set
            {
                mushrooms = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool tomato = true;
        /// <value>
        /// if hold tomato
        /// </value>
        public bool Tomato
        {
            get
            {
                return tomato;
            }
            set
            {
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool cheddar = true;
        /// <value>
        /// if hold Cheddar to the Garden Orc Omelette
        /// </value>
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }
            set
            {
                cheddar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <value>
        /// Setting these to false results in the addition of the corresponding instructions in the SpecialInstructions list
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Cheddar) instructions.Add("Hold cheddar");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");

                return instructions;


            }

        }
        /// <summary>
        /// convert the Garden Orc Omelette to string
        /// </summary>
        /// <returns>A string represent the name of the Garden Orc Omelette</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }


    }
}

