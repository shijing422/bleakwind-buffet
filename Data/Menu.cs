using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System.Linq;

namespace BleakwindBuffet.Data
{
   public static class Menu
    {

        public static IEnumerable<IOrderItem> Entrees()
        {
            IEnumerable<IOrderItem> entrees = new List<IOrderItem>();



            IOrderItem bb = new BriarheartBurger();
           
            IOrderItem dd = new DoubleDraugr();
         
            IOrderItem goo = new GardenOrcOmelette();
          
            IOrderItem pp = new PhillyPoacher();
            
            IOrderItem ss = new SmokehouseSkeleton();
           
            IOrderItem tt = new ThalmorTriple();
         
            IOrderItem ttb = new ThugsTBone();
            entrees.ToList().Add(bb);
            entrees.ToList().Add(dd);
            entrees.ToList().Add(goo);
            entrees.ToList().Add(pp);
            entrees.ToList().Add(tt);
            entrees.ToList().Add(ss);
            entrees.ToList().Add(ttb);

            return entrees;


            


        }

       /* public static IEnumerable<IOrderItem> Drinks()
        {

        }*/
    }
}
