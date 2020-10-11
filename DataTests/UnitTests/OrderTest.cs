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
        public void AbleToAddItem()
        {
            Order A = new Order();
            BriarheartBurger a = new BriarheartBurger();
            A.Add(a);

        }


    }
}
