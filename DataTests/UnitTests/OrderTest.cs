using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using System.Collections.Specialized;
using System.Collections;
using System.Linq;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests
{
    /// <summary>
    /// unit test for order.cs
    /// </summary>
    public class OrderTest
    {
        [Fact]
        public void AddItemShouldNotifiesTotalProperty()
        {
            Order A = new Order();

            Assert.PropertyChanged(A, "Total", () =>
            {
                BriarheartBurger a = new BriarheartBurger();
                A.Add(a);

            });
        }

        [Fact]
        public void AddItemSHouldNotifiesSubtotalProperty()
        {
            Order A = new Order();

            Assert.PropertyChanged(A, "Subtotal", () =>
            {
                BriarheartBurger a = new BriarheartBurger();
                A.Add(a);

            });
        }
        [Fact]
        public void AddItemSHouldNotifiesTaxProperty()
        {
            Order A = new Order();

            Assert.PropertyChanged(A, "Tax", () =>
            {
                BriarheartBurger a = new BriarheartBurger();
                A.Add(a);

            });
        }


        [Fact]
        public void AddItemSHouldNotifiesCaloriesProperty()
        {
            Order A = new Order();

            Assert.PropertyChanged(A, "Calories", () =>
            {
                BriarheartBurger a = new BriarheartBurger();
                A.Add(a);

            });
        }


        [Fact]
        public void RemoveItemShouldNotifiesTotalProperty()
        {
            Order A = new Order();
            BriarheartBurger a = new BriarheartBurger();
            A.Add(a);
            Assert.PropertyChanged(A, "Total", () =>
            {

                A.Remove(a);

            });
        }

        [Fact]
        public void RemoveItemSHouldNotifiesSubtotalProperty()
        {
            Order A = new Order();
            BriarheartBurger a = new BriarheartBurger();
            A.Add(a);
            Assert.PropertyChanged(A, "Total", () =>
            {

                A.Remove(a);

            });
        }
        [Fact]
        public void RemoveItemSHouldNotifiesTaxProperty()
        {
            Order A = new Order();
            BriarheartBurger a = new BriarheartBurger();
            A.Add(a);
            Assert.PropertyChanged(A, "Total", () =>
            {

                A.Remove(a);

            });
        }


        [Fact]
        public void RemoveItemSHouldNotifiesCaloriesProperty()
        {
            Order A = new Order();
            BriarheartBurger a = new BriarheartBurger();
            A.Add(a);
            Assert.PropertyChanged(A, "Total", () =>
            {

                A.Remove(a);

            });
        }


        [Fact]
        public void ShouldGetCorrectCal()
        {
            Order a = new Order();
            BriarheartBurger b = new BriarheartBurger();
            SailorSoda s = new SailorSoda();
            FriedMiraak f = new FriedMiraak();
            a.Add(b);
            a.Add(s);
            a.Add(f);
            Assert.Equal(f.Calories + s.Calories + b.Calories, a.Calories);


        }

        [Fact]
        public void ShouldGetCorrectSubtotalPrice()
        {
            Order a = new Order();
            BriarheartBurger b = new BriarheartBurger();
            SailorSoda s = new SailorSoda();
            FriedMiraak f = new FriedMiraak();
            a.Add(b);
            a.Add(s);
            a.Add(f);
            Assert.Equal(f.Price + s.Price + b.Price, a.Subtotal);


        }

        [Fact]
        public void SalesTaxRatedefault()
        {
            Order a = new Order();
            
            Assert.Equal(0.12, a.SalesTaxRate);


        }

        [Fact]
        public void CheckTax()
        {
            Order a = new Order();
            BriarheartBurger b = new BriarheartBurger();
            SailorSoda s = new SailorSoda();
            FriedMiraak f = new FriedMiraak();
            a.Add(b);
            a.Add(s);
            a.Add(f);
            double p = (f.Price + s.Price + b.Price) * a.SalesTaxRate;
            Assert.Equal(p, a.Tax);


        }


        [Fact]
        public void CheckTotal()
        {
            Order a = new Order();
            BriarheartBurger b = new BriarheartBurger();
            SailorSoda s = new SailorSoda();
            FriedMiraak f = new FriedMiraak();
            a.Add(b);
            a.Add(s);
            a.Add(f);
            double p = (f.Price + s.Price + b.Price) * (1+a.SalesTaxRate) ;
            Assert.Equal(p, a.Total);


        }


    }
}
