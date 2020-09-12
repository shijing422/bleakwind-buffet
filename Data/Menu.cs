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

         
            Entree BB = (Entree)new BriarheartBurger();
            IOrderItem bb = (IOrderItem)BB;
            Entree DD = (Entree)new DoubleDraugr();
            IOrderItem dd = (IOrderItem)DD;
            Entree GOO = (Entree)new GardenOrcOmelette();
            IOrderItem goo = (IOrderItem)GOO;
            Entree PP = (Entree)new PhillyPoacher();
            IOrderItem pp = (IOrderItem)PP;
            Entree SS = (Entree)new SmokehouseSkeleton();
            IOrderItem ss = (IOrderItem)SS;
            Entree TT = (Entree)new ThalmorTriple();
            IOrderItem tt = (IOrderItem)TT;
            Entree TTB = (Entree)new ThugsTBone();
            IOrderItem ttb = (IOrderItem)TTB;
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
