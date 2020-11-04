using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System.IO;
using System.Runtime.CompilerServices;

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
            List<IOrderItem> entrees = new List<IOrderItem>();



   
            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new ThugsTBone());
            entrees.Add(new ThalmorTriple());
            entrees.Add(new SmokehouseSkeleton());
            entrees.Add(new PhillyPoacher());
            entrees.Add(new GardenOrcOmelette());

            return entrees;


            


        }
        /// <summary>
        /// A method return all drinks
        /// </summary>
        /// <returns>an IEnumerable<IOrderItem> containing all available drinks offered by BleakwindBuffet. As each drink has 3 different sizes, this collection should contain a small, medium, and large instance of each. Similarly, it should contain three of each flavor of SailorSoda: one large, one medium, and one small.</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();

            AretinoAppleJuice saa = new AretinoAppleJuice();
            AretinoAppleJuice maa = new AretinoAppleJuice();
            AretinoAppleJuice laa = new AretinoAppleJuice();
            saa.Size = Size.Small;
            maa.Size = Size.Medium;
            laa.Size = Size.Large;
          
            
            drinks.Add(saa);
            drinks.Add(maa);
            drinks.Add(laa);

            WarriorWater sww = new WarriorWater();
            WarriorWater mww = new WarriorWater();
            WarriorWater lww = new WarriorWater();
            sww.Size = Size.Small;
            mww.Size = Size.Medium;
            lww.Size = Size.Large;
           
            drinks.Add(sww);
            drinks.Add(mww);
            drinks.Add(lww);

            MarkarthMilk smm = new MarkarthMilk();
            MarkarthMilk mmm = new MarkarthMilk();
            MarkarthMilk lmm = new MarkarthMilk();
            smm.Size = Size.Small;
            mmm.Size = Size.Medium;
            lmm.Size = Size.Large;
           
            drinks.Add(smm);
            drinks.Add(mmm);
            drinks.Add(lmm);

            CandlehearthCoffee scc = new CandlehearthCoffee();
            CandlehearthCoffee mcc = new CandlehearthCoffee();
            CandlehearthCoffee lcc = new CandlehearthCoffee();
            scc.Size = Size.Small;
            mcc.Size = Size.Medium;
            lcc.Size = Size.Large;
          
            drinks.Add(scc);
            drinks.Add(mcc);
            drinks.Add(lcc);

            CandlehearthCoffee sdc = new CandlehearthCoffee();
            CandlehearthCoffee mdc = new CandlehearthCoffee();
            CandlehearthCoffee ldc = new CandlehearthCoffee();
            sdc.Decaf = true;
            mdc.Decaf = true;
            ldc.Decaf = true;
            sdc.Size = Size.Small;
            mdc.Size = Size.Medium;
            ldc.Size = Size.Large;
            
            drinks.Add(sdc);
            drinks.Add(mdc);
            drinks.Add(ldc);


            SailorSoda scherry = new SailorSoda();
            SailorSoda mcherry = new SailorSoda();
            SailorSoda lcherry = new SailorSoda();
            scherry.Size = Size.Small;
            mcherry.Size = Size.Medium;
            lcherry.Size = Size.Large;
           
            drinks.Add(scherry);
            drinks.Add(mcherry);
            drinks.Add(lcherry) ;


            SailorSoda sblac = new SailorSoda();
            SailorSoda mblac = new SailorSoda();
            SailorSoda lblac = new SailorSoda();
            sblac.Size = Size.Small;
            mblac.Size = Size.Medium;
            lblac.Size = Size.Large;
            sblac.Flavor = SodaFlavor.Blackberry;
            mblac.Flavor = SodaFlavor.Blackberry;
            lblac.Flavor = SodaFlavor.Blackberry;
            
            drinks.Add(sblac);
            drinks.Add(mblac);
            drinks.Add(lblac);



            SailorSoda sgra = new SailorSoda();
            SailorSoda mgra = new SailorSoda();
            SailorSoda lgra = new SailorSoda();
            sgra.Flavor = SodaFlavor.Grapefruit;
            mgra.Flavor = SodaFlavor.Grapefruit;
            lgra.Flavor = SodaFlavor.Grapefruit;
            sgra.Size = Size.Small;
            mgra.Size = Size.Medium;
            lgra.Size = Size.Large;
    
            drinks.Add(sgra);
            drinks.Add(mgra);
            drinks.Add(lgra);

            SailorSoda slem = new SailorSoda();
            SailorSoda mlem = new SailorSoda();
            SailorSoda llem = new SailorSoda();
            slem.Flavor = SodaFlavor.Lemon;
            mlem.Flavor = SodaFlavor.Lemon;
            llem.Flavor = SodaFlavor.Lemon;
            slem.Size = Size.Small;
            mlem.Size = Size.Medium;
            llem.Size = Size.Large;
          
            drinks.Add(slem);
            drinks.Add(mlem);
            drinks.Add(llem);

            SailorSoda spea = new SailorSoda();
            SailorSoda mpea = new SailorSoda();
            SailorSoda lpea = new SailorSoda();
            spea.Size = Size.Small;
            mpea.Size = Size.Medium;
            lpea.Size = Size.Large;
            spea.Flavor = SodaFlavor.Peach;
            mpea.Flavor = SodaFlavor.Peach;
            lpea.Flavor = SodaFlavor.Peach;
          
            drinks.Add(spea);
            drinks.Add(mpea);
            drinks.Add(lpea);



            SailorSoda swat = new SailorSoda();
            SailorSoda mwat = new SailorSoda();
            SailorSoda lwat = new SailorSoda();
            swat.Flavor = SodaFlavor.Watermelon;
            mwat.Flavor = SodaFlavor.Watermelon;
            lwat.Flavor = SodaFlavor.Watermelon;
            swat.Size = Size.Small;
            mwat.Size = Size.Medium;
            lwat.Size = Size.Large;
            
            drinks.Add(swat);
            drinks.Add(mwat);
            drinks.Add(lwat);



            return drinks;




        }
        /// <summary>
        /// A method return all sides
        /// </summary>
        /// <returns>an IEnumerable<IOrderItem> containing an instance of all available sides offered by Bleakwind Buffet. As each side has 3 different sizes, this collection should contain a small, medium, and large instance of each.</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();

            DragonbornWaffleFries sdw = new DragonbornWaffleFries();
            sdw.Size = Size.Small;
            DragonbornWaffleFries mdw = new DragonbornWaffleFries();
            DragonbornWaffleFries ldw = new DragonbornWaffleFries();
            mdw.Size = Size.Medium;
            ldw.Size = Size.Large;
       
            sides.Add(sdw);
            sides.Add(mdw);
            sides.Add(ldw);

            FriedMiraak sfm = new FriedMiraak();
            FriedMiraak mfm = new FriedMiraak();
            FriedMiraak lfm = new FriedMiraak();
            sfm.Size = Size.Small;
            mfm.Size = Size.Medium;
            lfm.Size = Size.Large;
            

            sides.Add(sfm);
            sides.Add(mfm);
            sides.Add(lfm);

            MadOtarGrits smo = new MadOtarGrits();
            MadOtarGrits mmo = new MadOtarGrits();
            MadOtarGrits lmo = new MadOtarGrits();
            smo.Size = Size.Small;
            mmo.Size = Size.Medium;
            lmo.Size = Size.Large;
        
            sides.Add(smo);
            sides.Add(mmo);
            sides.Add(lmo);

            VokunSalad svs = new VokunSalad();
            VokunSalad mvs = new VokunSalad();
            VokunSalad lvs = new VokunSalad();
            svs.Size = Size.Small;
            mvs.Size = Size.Medium;
            lvs.Size = Size.Large;
          
            sides.Add(svs);
            sides.Add(mvs);
            sides.Add(lvs);


















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


        public static IEnumerable<IOrderItem> SearchEntrees(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            //null check
            if (terms == null)
            {
                return Entrees();
            }

            foreach (IOrderItem i in Entrees())
            {
                string name = i.ToString();
                
                // add if title is a match
                if (name != null && name.ToLower().Contains(terms.ToLower()))
                {

                
                    results.Add(i);
                }
            }

            return results;

            
        }

        public static IEnumerable<IOrderItem> SearchSides(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            //null check
            if (terms == null)
            {
                return Sides();
            }

            foreach (IOrderItem i in Sides())
            {
                string name = i.ToString();

                // add if title is a match
                if (name != null && name.ToLower().Contains(terms.ToLower()))
                {


                    results.Add(i);
                }
            }

            return results;


        }


        public static IEnumerable<IOrderItem> SearchDrinks(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            //null check
            if (terms == null)
            {
                return Drinks();
            }

            foreach (IOrderItem i in Drinks())
            {
                string name = i.ToString();

                // add if title is a match
                if (name != null && name.ToLower().Contains(terms.ToLower()))
                {


                    results.Add(i);
                }
            }

            return results;


        }


    }
}
