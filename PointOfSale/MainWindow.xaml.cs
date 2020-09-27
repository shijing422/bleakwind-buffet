using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;




namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double total = 0;
        string button;
        List<string> lists = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            Customization.Visibility = Visibility.Hidden;
        }
        void hidden()
        {
            cBlackberry.Visibility = Visibility.Hidden;
            cSmall.Visibility = Visibility.Hidden;
            cMedium.Visibility = Visibility.Hidden;
            cLarge.Visibility = Visibility.Hidden;
            cCherry.Visibility = Visibility.Hidden;
            cGrapef.Visibility = Visibility.Hidden;
            cWatermelon.Visibility = Visibility.Hidden;
            cPeach.Visibility = Visibility.Hidden;
            cLemonflavor.Visibility = Visibility.Hidden;
            cBacon.Visibility = Visibility.Hidden;
            cBroccoli.Visibility = Visibility.Hidden;
            cBun.Visibility = Visibility.Hidden;
            cCheddar.Visibility = Visibility.Hidden;
            cCheese.Visibility = Visibility.Hidden;
            cDecaf.Visibility = Visibility.Hidden;
            cEgg.Visibility = Visibility.Hidden;
            cHashBrowns.Visibility = Visibility.Hidden;
            cIce.Visibility = Visibility.Hidden;
            cKetchup.Visibility = Visibility.Hidden;
            cLemon.Visibility = Visibility.Hidden;
            cLettuce.Visibility = Visibility.Hidden;
            cMayo.Visibility = Visibility.Hidden;
            cMushrooms.Visibility = Visibility.Hidden;
            cMustard.Visibility = Visibility.Hidden;
            cOnion.Visibility = Visibility.Hidden;
            cPancake.Visibility = Visibility.Hidden;
            cPickle.Visibility = Visibility.Hidden;
            cRoll.Visibility = Visibility.Hidden;
            cRoomForCream.Visibility = Visibility.Hidden;
            cSausageLink.Visibility = Visibility.Hidden;
            cSirloin.Visibility = Visibility.Hidden;
            cTomato.Visibility = Visibility.Hidden;
            
        }
        void ClickBriarheartBurger(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;
            BriarheartBurger a = new BriarheartBurger();
            total += a.Price;
            lists.Add(a.ToString());
            orderlist.Text = string.Join("\n", lists);
            string tp = "Subtotal: $" + total.ToString() + "\n" + "Tax:$" + (0.09*total).ToString() + "\n" + "Total:$" + (1.09*total).ToString();
            orderprice.Text = tp;
            button = "BriarheartBurger";
            hidden();
            cBun.Visibility = Visibility.Visible;
            cKetchup.Visibility = Visibility.Visible;
            cMustard.Visibility = Visibility.Visible;
            cPickle.Visibility = Visibility.Visible;
            cCheese.Visibility = Visibility.Visible;


        }
        void ClickDoubleDraugr(object sender, RoutedEventArgs e)
        {
            button = "DoubleDraugr";
            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;
            DoubleDraugr a = new DoubleDraugr();
            total += a.Price;
            lists.Add(a.ToString());
            orderlist.Text = string.Join("\n", lists);
            string tp = "Subtotal: $" + total.ToString() + "\n" + "Tax:$" + (0.09 * total).ToString() + "\n" + "Total:$" + (1.09 * total).ToString();
            orderprice.Text = tp;
            hidden();
            cBun.Visibility = Visibility.Visible;
            cKetchup.Visibility = Visibility.Visible;
            cMustard.Visibility = Visibility.Visible;
            cPickle.Visibility = Visibility.Visible;
            cCheese.Visibility = Visibility.Visible;
            cTomato.Visibility = Visibility.Visible;
            cLettuce.Visibility = Visibility.Visible;
            cMayo.Visibility = Visibility.Visible;


        }
        void ClickThalmorTriple(object sender, RoutedEventArgs e)
        {
            button = "ThalmorTriple";
            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;

            ThalmorTriple a = new ThalmorTriple();
            total += a.Price;
            lists.Add(a.ToString());
            orderlist.Text = string.Join("\n", lists);
            string tp = "Subtotal: $" + total.ToString() + "\n" + "Tax:$" + (0.09 * total).ToString() + "\n" + "Total:$" + (1.09 * total).ToString();
            orderprice.Text = tp;
            hidden();
            cBun.Visibility = Visibility.Visible;
            cKetchup.Visibility = Visibility.Visible;
            cMustard.Visibility = Visibility.Visible;
            cPickle.Visibility = Visibility.Visible;
            cCheese.Visibility = Visibility.Visible;
            cTomato.Visibility = Visibility.Visible;
            cLettuce.Visibility = Visibility.Visible;
            cMayo.Visibility = Visibility.Visible;
            cEgg.Visibility = Visibility.Visible;
            cBacon.Visibility = Visibility.Visible;

        }
        void ClickSmokehouseSkeleton(object sender, RoutedEventArgs e)
        {
            button = "SmokehouseSkeleton";
            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;

            SmokehouseSkeleton a = new SmokehouseSkeleton();
            total += a.Price;
            lists.Add(a.ToString());
            orderlist.Text = string.Join("\n", lists);
            string tp = "Subtotal: $" + total.ToString() + "\n" + "Tax:$" + (0.09 * total).ToString() + "\n" + "Total:$" + (1.09 * total).ToString();
            orderprice.Text = tp;
            hidden();
            cSausageLink.Visibility = Visibility.Visible;
            cEgg.Visibility = Visibility.Visible;
            cHashBrowns.Visibility = Visibility.Visible;
            cPancake.Visibility = Visibility.Visible;





        }
        void ClickGardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            button = "GardenOrcOmelette";
            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;

            GardenOrcOmelette a = new GardenOrcOmelette();
            total += a.Price;
            lists.Add(a.ToString());
            orderlist.Text = string.Join("\n", lists);
            string tp = "Subtotal: $" + total.ToString() + "\n" + "Tax:$" + (0.09 * total).ToString() + "\n" + "Total:$" + (1.09 * total).ToString();
            orderprice.Text = tp;
            hidden();
            cBroccoli.Visibility = Visibility.Visible;
            cMushrooms.Visibility = Visibility.Visible;
            cTomato.Visibility = Visibility.Visible;
            cCheddar.Visibility = Visibility.Visible;

        }
        void ClickThugsTBone(object sender, RoutedEventArgs e)
        {
            button = "ThugsTBone";
            
            ThugsTBone a = new ThugsTBone();
            total += a.Price;
            lists.Add(a.ToString());
            orderlist.Text = string.Join("\n", lists);
            string tp = "Subtotal: $" + total.ToString() + "\n" + "Tax:$" + (0.09 * total).ToString() + "\n" + "Total:$" + (1.09 * total).ToString();
            orderprice.Text = tp;



        }
        void ClickPhillyPoacher(object sender, RoutedEventArgs e)
        {
            button = "PhillyPoacher";
            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;
            PhillyPoacher a = new PhillyPoacher();
            total += a.Price;
            lists.Add(a.ToString());
            orderlist.Text = string.Join("\n", lists);
            string tp = "Subtotal: $" + total.ToString() + "\n" + "Tax:$" + (0.09 * total).ToString() + "\n" + "Total:$" + (1.09 * total).ToString();
            orderprice.Text = tp;
            hidden();
            cSirloin.Visibility = Visibility.Visible;
            cRoll.Visibility = Visibility.Visible;
            cOnion.Visibility = Visibility.Visible;


        }
        void ClickCancel(object sender, RoutedEventArgs e)
        {
            lists.Clear();
            total = 0;
            orderlist.Clear();

        }
        void ClickOK(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Visible;
            Customization.Visibility = Visibility.Hidden;
            if(string.Equals(button, "BriarheartBurger"))
            {
                BriarheartBurger a = new BriarheartBurger();

                if (cBun.IsChecked == false)
                {
                    a.Bun = false;
                }
                if (cKetchup.IsChecked == false)
                {
                    a.Ketchup = false;

                }
                if(cMustard.IsChecked == false) a.Mustard = false;
                if (cPickle.IsChecked == false) a.Pickle = false;
                if (cCheese.IsChecked == false) a.Cheese = false;
                var result = lists.Concat(a.SpecialInstructions);
                lists = result.ToList();
                orderlist.Text = string.Join("\n", lists);
                

            }

            if(string.Equals(button, "DoubleDraugr")){
                DoubleDraugr a = new DoubleDraugr();
                if (cBun.IsChecked == false)
                {
                    a.Bun = false;
                }
                if (cKetchup.IsChecked == false)
                {
                    a.Ketchup = false;

                }
                if (cMustard.IsChecked == false) a.Mustard = false;
                if (cPickle.IsChecked == false) a.Pickle = false;
                if (cCheese.IsChecked == false) a.Cheese = false;
                if (cTomato.IsChecked == false) a.Tomato = false;
                if (cLettuce.IsChecked == false) a.Lettuce = false;
                if (cMayo.IsChecked == false) a.Mayo = false;
                var result = lists.Concat(a.SpecialInstructions);
                lists = result.ToList();
                orderlist.Text = string.Join("\n", lists);

            }
            if (string.Equals(button, "ThalmorTriple"))
            {
                ThalmorTriple a = new ThalmorTriple();
                if (cBun.IsChecked == false)
                {
                    a.Bun = false;
                }
                if (cKetchup.IsChecked == false)
                {
                    a.Ketchup = false;

                }
                if (cBacon.IsChecked == false) a.Bacon = false;
                if (cEgg.IsChecked == false) a.Egg = false;
                if (cMustard.IsChecked == false) a.Mustard = false;
                if (cPickle.IsChecked == false) a.Pickle = false;
                if (cCheese.IsChecked == false) a.Cheese = false;
                if (cTomato.IsChecked == false) a.Tomato = false;
                if (cLettuce.IsChecked == false) a.Lettuce = false;
                if (cMayo.IsChecked == false) a.Mayo = false;
                var result = lists.Concat(a.SpecialInstructions);
                lists = result.ToList();
                orderlist.Text = string.Join("\n", lists);

            }


        }
        void ClickWater(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Visible;
            Customization.Visibility = Visibility.Hidden;

        }
        void ClickSoda(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Visible;
            Customization.Visibility = Visibility.Hidden;

        }
        void ClickCoffee(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Visible;
            Customization.Visibility = Visibility.Hidden;

        }
        void ClickMilk(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Visible;
            Customization.Visibility = Visibility.Hidden;

        }
        void ClickSalad(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Visible;
            Customization.Visibility = Visibility.Hidden;

        }
        void ClickMiraak(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Visible;
            Customization.Visibility = Visibility.Hidden;
        }
        void ClickFries(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Visible;
            Customization.Visibility = Visibility.Hidden;
        }
        void ClickGrits(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Visible;
            Customization.Visibility = Visibility.Hidden;
        }
        void ClickJuice(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Visible;
            Customization.Visibility = Visibility.Hidden;

        }








        void ClickPlace(object sender, RoutedEventArgs e)
        {
            Payment payment = new Payment();
            this.Visibility = Visibility.Hidden;
            payment.Visibility=Visibility.Visible;

        }




    }
}
