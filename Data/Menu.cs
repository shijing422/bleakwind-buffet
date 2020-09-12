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

       public static IEnumerable<IOrderItem> Drinks()
        {
            IEnumerable<IOrderItem> drinks = new List<IOrderItem>();
            AretinoAppleJuice saa = new AretinoAppleJuice();
            AretinoAppleJuice maa = new AretinoAppleJuice();
            AretinoAppleJuice laa = new AretinoAppleJuice();
            saa.Size = Size.Small;
            maa.Size = Size.Medium;
            laa.Size = Size.Large;
            IOrderItem SAA = (IOrderItem)saa;
            IOrderItem MAA = (IOrderItem)maa;
            IOrderItem LAA = (IOrderItem)laa;
            drinks.ToList().Add(SAA);
            drinks.ToList().Add(MAA);
            drinks.ToList().Add(LAA);
            return drinks;




        }
        public static IEnumerable<IOrderItem> Sides()
        {
            IEnumerable<IOrderItem> sides = new List<IOrderItem>();

            DragonbornWaffleFries sdw = new DragonbornWaffleFries();
            sdw.Size = Size.Small;
            DragonbornWaffleFries mdw = new DragonbornWaffleFries();
            DragonbornWaffleFries ldw = new DragonbornWaffleFries();
            mdw.Size = Size.Medium;
            ldw.Size = Size.Large;
            IOrderItem SDW = (IOrderItem)sdw;
            IOrderItem MDW = (IOrderItem)mdw;
            IOrderItem LDW = (IOrderItem)ldw;
            sides.ToList().Add(SDW);
            sides.ToList().Add(MDW);
            sides.ToList().Add(LDW);

            FriedMiraak sfm = new FriedMiraak();
            FriedMiraak mfm = new FriedMiraak();
            FriedMiraak lfm = new FriedMiraak();
            sfm.Size = Size.Small;
            mfm.Size = Size.Medium;
            lfm.Size = Size.Large;
            IOrderItem SFM = (IOrderItem)sfm;
            IOrderItem MFM = (IOrderItem)mfm;
            IOrderItem LFM = (IOrderItem)lfm;

            sides.ToList().Add(SFM);
            sides.ToList().Add(MFM);
            sides.ToList().Add(LFM);

            MadOtarGrits smo = new MadOtarGrits();
            MadOtarGrits mmo = new MadOtarGrits();
            MadOtarGrits lmo = new MadOtarGrits();
            smo.Size = Size.Small;
            mmo.Size = Size.Medium;
            lmo.Size = Size.Large;
            IOrderItem SMO = (IOrderItem)smo;
            IOrderItem MMO = (IOrderItem)mmo;
            IOrderItem LMO = (IOrderItem)lmo;
            sides.ToList().Add(SMO);
            sides.ToList().Add(MMO);
            sides.ToList().Add(LMO);

            VokunSalad svs = new VokunSalad();
            VokunSalad mvs = new VokunSalad();
            VokunSalad lvs = new VokunSalad();
















            return sides;


        }
    }
}
