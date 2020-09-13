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
    /// <summary>
    ///  A class represent the menu 
    /// </summary>
   public static class Menu
    {
        /// <summary>
        /// A method to return all entrees
        /// </summary>
        /// <returns>an IEnumerable<IOrderItem> containing an instance of all available entrees offered by Bleakwind Buffet</returns>

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
        /// <summary>
        /// A method return all drinks
        /// </summary>
        /// <returns>an IEnumerable<IOrderItem> containing all available drinks offered by BleakwindBuffet. As each drink has 3 different sizes, this collection should contain a small, medium, and large instance of each. Similarly, it should contain three of each flavor of SailorSoda: one large, one medium, and one small.</returns>
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

            WarriorWater sww = new WarriorWater();
            WarriorWater mww = new WarriorWater();
            WarriorWater lww = new WarriorWater();
            sww.Size = Size.Small;
            mww.Size = Size.Medium;
            lww.Size = Size.Large;
            IOrderItem SWW = (IOrderItem)sww;
            IOrderItem MWW = (IOrderItem)mww;
            IOrderItem LWW = (IOrderItem)lww;
            drinks.ToList().Add(SWW);
            drinks.ToList().Add(MWW);
            drinks.ToList().Add(LWW);

            MarkarthMilk smm = new MarkarthMilk();
            MarkarthMilk mmm = new MarkarthMilk();
            MarkarthMilk lmm = new MarkarthMilk();
            smm.Size = Size.Small;
            mmm.Size = Size.Medium;
            lmm.Size = Size.Large;
            IOrderItem SMM = (IOrderItem)smm;
            IOrderItem MMM = (IOrderItem)mmm;
            IOrderItem LMM = (IOrderItem)lmm;
            drinks.ToList().Add(SMM);
            drinks.ToList().Add(MMM);
            drinks.ToList().Add(LMM);

            CandlehearthCoffee scc = new CandlehearthCoffee();
            CandlehearthCoffee mcc = new CandlehearthCoffee();
            CandlehearthCoffee lcc = new CandlehearthCoffee();
            scc.Size = Size.Small;
            mcc.Size = Size.Medium;
            lcc.Size = Size.Large;
            IOrderItem SCC = (IOrderItem)scc;
            IOrderItem MCC = (IOrderItem)mcc;
            IOrderItem LCC = (IOrderItem)lcc;
            drinks.ToList().Add(SCC);
            drinks.ToList().Add(MCC);
            drinks.ToList().Add(LCC);

            CandlehearthCoffee sdc = new CandlehearthCoffee();
            CandlehearthCoffee mdc = new CandlehearthCoffee();
            CandlehearthCoffee ldc = new CandlehearthCoffee();
            sdc.Decaf = true;
            mdc.Decaf = true;
            ldc.Decaf = true;
            sdc.Size = Size.Small;
            mdc.Size = Size.Medium;
            ldc.Size = Size.Large;
            IOrderItem SDC = (IOrderItem)sdc;
            IOrderItem MDC = (IOrderItem)mdc;
            IOrderItem LDC = (IOrderItem)ldc;
            drinks.ToList().Add(SDC);
            drinks.ToList().Add(MDC);
            drinks.ToList().Add(LDC);


            SailorSoda scherry = new SailorSoda();
            SailorSoda mcherry = new SailorSoda();
            SailorSoda lcherry = new SailorSoda();
            scherry.Size = Size.Small;
            mcherry.Size = Size.Medium;
            lcherry.Size = Size.Large;
            IOrderItem SCherry = (IOrderItem)scherry;
            IOrderItem MCherry = (IOrderItem)mcherry;
            IOrderItem LCherry = (IOrderItem)lcherry;
            drinks.ToList().Add(SCherry);
            drinks.ToList().Add(MCherry);
            drinks.ToList().Add(LCherry);


            SailorSoda sblac = new SailorSoda();
            SailorSoda mblac = new SailorSoda();
            SailorSoda lblac = new SailorSoda();
            sblac.Size = Size.Small;
            mblac.Size = Size.Medium;
            lblac.Size = Size.Large;
            sblac.Flavor = SodaFlavor.Blackberry;
            mblac.Flavor = SodaFlavor.Blackberry;
            lblac.Flavor = SodaFlavor.Blackberry;
            IOrderItem SBlac = (IOrderItem)sblac;
            IOrderItem MBlac = (IOrderItem)mblac;
            IOrderItem LBlac = (IOrderItem)lblac;
            drinks.ToList().Add(SBlac);
            drinks.ToList().Add(MBlac);
            drinks.ToList().Add(LBlac);



            SailorSoda sgra = new SailorSoda();
            SailorSoda mgra = new SailorSoda();
            SailorSoda lgra = new SailorSoda();
            sgra.Flavor = SodaFlavor.Grapefruit;
            mgra.Flavor = SodaFlavor.Grapefruit;
            lgra.Flavor = SodaFlavor.Grapefruit;
            sgra.Size = Size.Small;
            mgra.Size = Size.Medium;
            lgra.Size = Size.Large;
            IOrderItem SGra = (IOrderItem)sgra;
            IOrderItem MGra = (IOrderItem)mgra;
            IOrderItem LGra = (IOrderItem)lgra;
            drinks.ToList().Add(SGra);
            drinks.ToList().Add(MGra);
            drinks.ToList().Add(LGra);

            SailorSoda slem = new SailorSoda();
            SailorSoda mlem = new SailorSoda();
            SailorSoda llem = new SailorSoda();
            slem.Flavor = SodaFlavor.Lemon;
            mlem.Flavor = SodaFlavor.Lemon;
            llem.Flavor = SodaFlavor.Lemon;
            slem.Size = Size.Small;
            mlem.Size = Size.Medium;
            llem.Size = Size.Large;
            IOrderItem SLem = (IOrderItem)slem;
            IOrderItem MLem = (IOrderItem)mlem;
            IOrderItem LLem = (IOrderItem)llem;
            drinks.ToList().Add(SLem);
            drinks.ToList().Add(MLem);
            drinks.ToList().Add(LLem);

            SailorSoda spea = new SailorSoda();
            SailorSoda mpea = new SailorSoda();
            SailorSoda lpea = new SailorSoda();
            spea.Size = Size.Small;
            mpea.Size = Size.Medium;
            lpea.Size = Size.Large;
            spea.Flavor = SodaFlavor.Peach;
            mpea.Flavor = SodaFlavor.Peach;
            lpea.Flavor = SodaFlavor.Peach;
            IOrderItem SPea = (IOrderItem)spea;
            IOrderItem MPea = (IOrderItem)mpea;
            IOrderItem LPea = (IOrderItem)lpea;
            drinks.ToList().Add(SPea);
            drinks.ToList().Add(MPea);
            drinks.ToList().Add(LPea);



            SailorSoda swat = new SailorSoda();
            SailorSoda mwat = new SailorSoda();
            SailorSoda lwat = new SailorSoda();
            swat.Flavor = SodaFlavor.Watermelon;
            mwat.Flavor = SodaFlavor.Watermelon;
            lwat.Flavor = SodaFlavor.Watermelon;
            swat.Size = Size.Small;
            mwat.Size = Size.Medium;
            lwat.Size = Size.Large;
            IOrderItem SWat = (IOrderItem)swat;
            IOrderItem MWat = (IOrderItem)mwat;
            IOrderItem LWat = (IOrderItem)lwat;
            drinks.ToList().Add(SWat);
            drinks.ToList().Add(MWat);
            drinks.ToList().Add(LWat);



            return drinks;




        }
        /// <summary>
        /// A method return all sides
        /// </summary>
        /// <returns>an IEnumerable<IOrderItem> containing an instance of all available sides offered by Bleakwind Buffet. As each side has 3 different sizes, this collection should contain a small, medium, and large instance of each.</returns>
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
            svs.Size = Size.Small;
            mvs.Size = Size.Medium;
            lvs.Size = Size.Large;
            IOrderItem SVS = (IOrderItem)svs;
            IOrderItem MVS = (IOrderItem)mvs;
            IOrderItem LVS = (IOrderItem)lvs;
            sides.ToList().Add(SVS);
            sides.ToList().Add(MVS);
            sides.ToList().Add(LVS);


















            return sides;


        }
        public static IEnumerable<IOrderItem> FullMenu()
        {
            
            IEnumerable<IOrderItem> drinks = Drinks();
            IEnumerable<IOrderItem> sides = Sides();
            IEnumerable<IOrderItem> entrees = Entrees();
            IEnumerable<IOrderItem> drinksAndsides = drinks.Concat(sides);
            IEnumerable<IOrderItem> full = entrees.Concat(drinksAndsides);
            return full;

        }
    }
}
