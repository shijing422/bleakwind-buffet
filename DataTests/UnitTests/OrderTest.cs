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
using System;

namespace BleakwindBuffet.DataTests.UnitTests
{
    /// <summary>
    /// unit test for order.cs
    /// </summary>
    public class OrderTest
    {
        [Fact]
        public void CheckNumber()
        {
            var obj = new Order();
            var num1 = obj.Number;
           
            obj = new Order();

            var num2 = obj.Number;
            Assert.Equal(num1+1, num2);
        }
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

        [Theory]
        [InlineData(0.01)]
        [InlineData(0.08)]
        [InlineData(0.09)]
        public void ShouldAbleToSetSalesTaxRate(double s)
        {
            Order a = new Order();
            a.SalesTaxRate = s;
            Assert.Equal(s, a.SalesTaxRate);


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
            double p = (f.Price + s.Price + b.Price) * (1 + a.SalesTaxRate);
            Assert.Equal(p, a.Total);


        }



        [Fact]
        public void CheckClear()
        {
            Order a = new Order();
            a.Add(new BriarheartBurger());
            a.Add(new WarriorWater());
            a.Clear();
            Assert.Equal(0, a.Count);

        }
        [Fact]
        public void CheckCount()
        {
            Order a = new Order();
            a.Add(new BriarheartBurger());
            a.Add(new WarriorWater());
            Assert.Equal(2, a.Count);
        }


        [Fact]
        public void CheckNotimplementExForContains()
        {

            Order a = new Order();
            BriarheartBurger i = new BriarheartBurger();
            a.Add(i);
            var ex = Assert.Throws<NotImplementedException>( () =>
            {
                bool c = a.Contains(i);

            });
        }

        [Fact]
        public void CheckNotimplementExForCopyto()
        {
            
            Order a = new Order();
            BriarheartBurger i = new BriarheartBurger();
            IOrderItem[] array = new IOrderItem[15];
            a.Add(i);
            var ex = Assert.Throws<NotImplementedException>(() =>
            {
                a.CopyTo(array, 1);

            });
        }
        [Fact]
        public void CheckNotimplementExForIsReadOnly()
        {

            Order a = new Order();
            BriarheartBurger i = new BriarheartBurger();
            
            a.Add(i);
            var ex = Assert.Throws<NotImplementedException>(() =>
            {
                bool c = a.IsReadOnly;

            });
        }


        

    }
}
