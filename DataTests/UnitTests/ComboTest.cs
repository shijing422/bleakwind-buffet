using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTes
    {
        [Fact]

        public void ShouldBeAbleToEntree()
        {
            Combo a = new Combo();
            BriarheartBurger b = new BriarheartBurger();
            a.Entree = b;
            Assert.Equal(b, a.Entree);

            DoubleDraugr d = new DoubleDraugr();
            a.Entree = d;
            Assert.Equal(d, a.Entree);

            GardenOrcOmelette g = new GardenOrcOmelette();
            a.Entree = g;
            Assert.Equal(g, a.Entree);

            PhillyPoacher p = new PhillyPoacher();
            a.Entree = p;
            Assert.Equal(p, a.Entree);

            SmokehouseSkeleton s = new SmokehouseSkeleton();
            a.Entree = s;
            Assert.Equal(s, a.Entree);

            ThalmorTriple t = new ThalmorTriple();
            a.Entree = t;
            Assert.Equal(t, a.Entree);

            ThugsTBone tb = new ThugsTBone();
            a.Entree = tb;
            Assert.Equal(tb, a.Entree);

        }

        [Fact]
        public void ShouldBeableToSetDrink()
        {
            Combo a = new Combo();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            a.Drink = aj;
            Assert.Equal(aj, a.Drink);

            CandlehearthCoffee c = new CandlehearthCoffee();
            a.Drink = c;
            Assert.Equal(c, a.Drink);

            MarkarthMilk m = new MarkarthMilk();
            a.Drink = m;
            Assert.Equal(m, a.Drink);

            SailorSoda s = new SailorSoda();
            a.Drink = s;
            Assert.Equal(s, a.Drink);

            WarriorWater w = new WarriorWater();
            a.Drink = w;
            Assert.Equal(w, a.Drink);








        }



        [Fact]
        public void ShouldAbleToSetSide()
        {
            Combo a = new Combo();
            DragonbornWaffleFries d = new DragonbornWaffleFries();
            a.Side = d;
            Assert.Equal(d, a.Side);

            VokunSalad v = new VokunSalad();
            a.Side = v;
            Assert.Equal(v, a.Side);
            MadOtarGrits m = new MadOtarGrits();
            a.Side = m;
            Assert.Equal(m, a.Side);
            FriedMiraak f = new FriedMiraak();
            a.Side = f;
            Assert.Equal(f, a.Side);


        }

        [Fact]
        public void ShouldGetCorrectPrice()
        {
            Combo a = new Combo();
            BriarheartBurger b = new BriarheartBurger();
            SailorSoda s = new SailorSoda();
            FriedMiraak f = new FriedMiraak();
            a.Side = f;
            a.Drink = s;
            a.Entree = b;
            Assert.Equal(f.Price + s.Price + b.Price - 1, a.Price);


        }
        [Fact]
        public void ShouldGetCorrectCal()
        {
            Combo a = new Combo();
            BriarheartBurger b = new BriarheartBurger();
            SailorSoda s = new SailorSoda();
            FriedMiraak f = new FriedMiraak();
            a.Side = f;
            a.Drink = s;
            a.Entree = b;
            Assert.Equal(f.Calories + s.Calories + b.Calories, a.Calories);


        }
        [Fact]
        public void ShouldGetCorrectSpecialInstrcutions()
        {
            Combo a = new Combo();
            BriarheartBurger b = new BriarheartBurger();
            b.Cheese = false;

            SailorSoda s = new SailorSoda();
            s.Size = Size.Large;
            FriedMiraak f = new FriedMiraak();
            f.Size = Size.Medium;
            a.Side = f;
            a.Drink = s;
            a.Entree = b;
            Assert.Contains("Hold cheese", a.SpecialInstructions);

            Assert.Contains(f.ToString(), a.SpecialInstructions);
            Assert.Contains(s.ToString(), a.SpecialInstructions);
            Assert.Contains(b.ToString(), a.SpecialInstructions);
        }
        [Fact]
        public void SetEntreeNotifiesEntreeProperty()
        {
            Combo A = new Combo();
            Assert.PropertyChanged(A, "Entree", () =>
            {
                A.Entree = new BriarheartBurger();
            });
            Assert.PropertyChanged(A, "Entree", () =>
            {
                A.Entree = new DoubleDraugr();
            });
            Assert.PropertyChanged(A, "Entree", () =>
            {
                A.Entree = new GardenOrcOmelette();
            });
            Assert.PropertyChanged(A, "Entree", () =>
            {
                A.Entree = new PhillyPoacher();
            });
            Assert.PropertyChanged(A, "Entree", () =>
            {
                A.Entree = new SmokehouseSkeleton();
            });
            Assert.PropertyChanged(A, "Entree", () =>
            {
                A.Entree = new ThalmorTriple();
            });
            Assert.PropertyChanged(A, "Entree", () =>
            {
                A.Entree = new ThugsTBone();
            });

        }
        [Fact]
        public void SetEntreeNotifiesPriceProperty()
        {
            Combo A = new Combo();
            Assert.PropertyChanged(A, "Price", () =>
            {
                A.Entree = new BriarheartBurger();
            });
            Assert.PropertyChanged(A, "Price", () =>
            {
                A.Entree = new DoubleDraugr();
            });
            Assert.PropertyChanged(A, "Price", () =>
            {
                A.Entree = new GardenOrcOmelette();
            });
            Assert.PropertyChanged(A, "Price", () =>
            {
                A.Entree = new PhillyPoacher();
            });
            Assert.PropertyChanged(A, "Price", () =>
            {
                A.Entree = new SmokehouseSkeleton();
            });
            Assert.PropertyChanged(A, "Price", () =>
            {
                A.Entree = new ThalmorTriple();
            });
            Assert.PropertyChanged(A, "Price", () =>
            {
                A.Entree = new ThugsTBone();
            });

        }


        [Fact]
        public void SetEntreeNotifiesCaloriesProperty()
        {
            Combo A = new Combo();
            Assert.PropertyChanged(A, "Calories", () =>
            {
                A.Entree = new BriarheartBurger();
            });
            Assert.PropertyChanged(A, "Calories", () =>
            {
                A.Entree = new DoubleDraugr();
            });
            Assert.PropertyChanged(A, "Calories", () =>
            {
                A.Entree = new GardenOrcOmelette();
            });
            Assert.PropertyChanged(A, "Calories", () =>
            {
                A.Entree = new PhillyPoacher();
            });
            Assert.PropertyChanged(A, "Calories", () =>
            {
                A.Entree = new SmokehouseSkeleton();
            });
            Assert.PropertyChanged(A, "Calories", () =>
            {
                A.Entree = new ThalmorTriple();
            });
            Assert.PropertyChanged(A, "Calories", () =>
            {
                A.Entree = new ThugsTBone();
            });

        }


        [Fact]
        public void SetEntreeNotifiesSpecialInstructionsProperty()
        {
            Combo A = new Combo();
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Entree = new BriarheartBurger();
            });
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Entree = new DoubleDraugr();
            });
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Entree = new GardenOrcOmelette();
            });
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Entree = new PhillyPoacher();
            });
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Entree = new SmokehouseSkeleton();
            });
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Entree = new ThalmorTriple();
            });
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Entree = new ThugsTBone();
            });

        }

        [Fact]
        public void SetSideNotifiesSideProperty()
        {
            Combo A = new Combo();

            Assert.PropertyChanged(A, "Side", () =>
            {
                A.Side= new VokunSalad();
            });
            Assert.PropertyChanged(A, "Side", () =>
            {
                A.Side = new FriedMiraak();
            });
            Assert.PropertyChanged(A, "Side", () =>
            {
                A.Side = new DragonbornWaffleFries();
            });
            Assert.PropertyChanged(A, "Side", () =>
            {
                A.Side = new MadOtarGrits();
            });

        }

        [Fact]
        public void SetSideNotifiePriceProperty()
        {
            Combo A = new Combo();

            Assert.PropertyChanged(A, "Price", () =>
            {
                A.Side = new VokunSalad();
            });
            Assert.PropertyChanged(A, "Price", () =>
            {
                A.Side = new FriedMiraak();
            });
            Assert.PropertyChanged(A, "Price", () =>
            {
                A.Side = new DragonbornWaffleFries();
            });
            Assert.PropertyChanged(A, "Price", () =>
            {
                A.Side = new MadOtarGrits();
            });

        }


        [Fact]
        public void SetSideNotifieCaloriesProperty()
        {
            Combo A = new Combo();

            Assert.PropertyChanged(A, "Calories", () =>
            {
                A.Side = new VokunSalad();
            });
            Assert.PropertyChanged(A, "Calories", () =>
            {
                A.Side = new FriedMiraak();
            });
            Assert.PropertyChanged(A, "Calories", () =>
            {
                A.Side = new DragonbornWaffleFries();
            });
            Assert.PropertyChanged(A, "Calories", () =>
            {
                A.Side = new MadOtarGrits();
            });

        }


        [Fact]
        public void SetSideNotifieSpecialinstructionsProperty()
        {
            Combo A = new Combo();

            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Side = new VokunSalad();
            });
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Side = new FriedMiraak();
            });
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Side = new DragonbornWaffleFries();
            });
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Side = new MadOtarGrits();
            });

        }




        [Fact]
        public void SetDrinkNotifieDrinkProperty()
        {
            Combo A = new Combo();

            Assert.PropertyChanged(A, "Drink", () =>
            {
                A.Drink = new WarriorWater();
            });
            Assert.PropertyChanged(A, "Drink", () =>
            {
                A.Drink = new SailorSoda();
            });
            Assert.PropertyChanged(A, "Drink", () =>
            {
                A.Drink = new CandlehearthCoffee();
            });
            Assert.PropertyChanged(A, "Drink", () =>
            {
                A.Drink = new AretinoAppleJuice();

            });
            Assert.PropertyChanged(A, "Drink", () =>
            {
                A.Drink = new MarkarthMilk();

            });


        }
        [Fact]
        public void SetDrinkNotifiesPriceProperty()
        {
            Combo A = new Combo();

            Assert.PropertyChanged(A, "Price", () =>
            {
                A.Drink = new SailorSoda();
            });
            Assert.PropertyChanged(A, "Price", () =>
            {
                A.Drink = new WarriorWater();
            });
            Assert.PropertyChanged(A, "Price", () =>
            {
                A.Drink = new MarkarthMilk();
            });
            Assert.PropertyChanged(A, "Price", () =>
            {
                A.Drink = new CandlehearthCoffee();
            });
            Assert.PropertyChanged(A, "Price", () =>
            {
                A.Drink = new AretinoAppleJuice();
            });

        }


        [Fact]
        public void SetDrinkNotifieCaloriesProperty()
        {
            Combo A = new Combo();

            Assert.PropertyChanged(A, "Calories", () =>
            {
                A.Drink = new WarriorWater();
            });
            Assert.PropertyChanged(A, "Calories", () =>
            {
                A.Drink = new SailorSoda();
            });
            Assert.PropertyChanged(A, "Calories", () =>
            {
                A.Drink = new CandlehearthCoffee();
            });
            Assert.PropertyChanged(A, "Calories", () =>
            {
                A.Drink = new AretinoAppleJuice();

            });
            Assert.PropertyChanged(A, "Calories", () =>
            {
                A.Drink = new MarkarthMilk();

            });


        }


        [Fact]
        public void SetDrinkNotifieSpecialinstructionsProperty()
        {
            Combo A = new Combo();

            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Drink = new WarriorWater();
            });
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Drink = new SailorSoda();
            });
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Drink = new AretinoAppleJuice();
            });
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Drink = new CandlehearthCoffee();
            });
            Assert.PropertyChanged(A, "SpecialInstructions", () =>
            {
                A.Drink = new MarkarthMilk();
            });

        }
    }






    

}
