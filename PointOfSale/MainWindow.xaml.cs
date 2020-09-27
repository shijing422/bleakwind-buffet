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
using BleakwindBuffet.Data.Enums;
using Size = BleakwindBuffet.Data.Enums.Size;
/*
 * Author: Shijing Zhang
 * Class name: MainWindow.xaml.cs
 * Purpose: Class used for Interaction logic for MainWindow.xaml
 */
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <value>
        /// the total price for the order
        /// </value>
        double total = 0;
        /// <value>
        /// string name from button
        /// </value>
        string button;
        /// <value>
        /// list<string> contains the order lists
        /// </value>
        List<string> lists = new List<string>();
        /// <summary>
        /// initialize
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Customization.Visibility = Visibility.Hidden;
        }
        /// <summary>
        /// check for sodaflavor click, if one sodaflavor clicked, disable others
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void clickflavor(object sender, RoutedEventArgs e)
        {
            if (cCherry.IsChecked == true)
            {
                cBlackberry.IsEnabled = false;
                cGrapef.IsEnabled = false;
                cPeach.IsEnabled = false;
                cWatermelon.IsEnabled = false;
                cLemonflavor.IsEnabled = false;
            }
            else if (cBlackberry.IsChecked == true)
            {
                cCherry.IsEnabled = false;
                cGrapef.IsEnabled = false;
                cPeach.IsEnabled = false;
                cWatermelon.IsEnabled = false;
                cLemonflavor.IsEnabled = false;

            }
            else if (cGrapef.IsChecked == true)
            {
                cCherry.IsEnabled = false;
                cBlackberry.IsEnabled = false;
                cPeach.IsEnabled = false;
                cWatermelon.IsEnabled = false;
                cLemonflavor.IsEnabled = false;

            }
            else if (cPeach.IsChecked == true)
            {
                cCherry.IsEnabled = false;
                cGrapef.IsEnabled = false;
                cBlackberry.IsEnabled = false;
                cWatermelon.IsEnabled = false;
                cLemonflavor.IsEnabled = false;

            }
            else if(cWatermelon.IsChecked == true)
            {
                cCherry.IsEnabled = false;
                cGrapef.IsEnabled = false;
                cPeach.IsEnabled = false;
                cBlackberry.IsEnabled = false;
                cLemonflavor.IsEnabled = false;

            }
            else if (cLemonflavor.IsChecked == true)
            {
                cCherry.IsEnabled = false;
                cGrapef.IsEnabled = false;
                cPeach.IsEnabled = false;
                cWatermelon.IsEnabled = false;
                cBlackberry.IsEnabled = false;

            }
            else
            {
                cBlackberry.IsEnabled = true;
                cCherry.IsEnabled = true;
                cGrapef.IsEnabled = true;
                cPeach.IsEnabled=true;
                cWatermelon.IsEnabled = true;
                cBlackberry.IsEnabled = true;
            }
        }
        /// <summary>
        /// if one size clicked, disable other
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void clicksize(object sender, RoutedEventArgs e)
        {
            if (cSmall.IsChecked == true)
            {
                cMedium.IsEnabled = false;
                cLarge.IsEnabled = false;

            }
            else if (cMedium.IsChecked == true)
            {
                cSmall.IsEnabled = false;
                cLarge.IsEnabled = false;
            }
            else if (cLarge.IsChecked == true)
            {
                cMedium.IsEnabled = false;
                cSmall.IsEnabled = false;
            }
            else
            {
                cMedium.IsEnabled = true;
                cLarge.IsEnabled = true;
                cSmall.IsEnabled = true;
            }

        }
        /// <summary>
        /// initialize Customization
        /// </summary>
        void initialize()
        {
            cBlackberry.IsEnabled = true;
            cCherry.IsEnabled = true;
            cGrapef.IsEnabled = true;
            cPeach.IsEnabled = true;
            cWatermelon.IsEnabled = true;
            cBlackberry.IsEnabled = true;
            cMedium.IsEnabled = true;
            cLarge.IsEnabled = true;
            cSmall.IsEnabled = true;
            cBlackberry.IsChecked = false;
            cSmall.IsChecked = false;
            cMedium.IsChecked = false;
            cLarge.IsChecked = false;
            cCherry.IsChecked = false;
            cGrapef.IsChecked = false;
            cWatermelon.IsChecked = false;
            cPeach.IsChecked = false;
            cLemonflavor.IsChecked = false;
            cBacon.IsChecked = true;
            cBroccoli.IsChecked = true;
            cBun.IsChecked = true;
            cCheddar.IsChecked = true;
            cCheese.IsChecked = true;
            cDecaf.IsChecked = false;
            cEgg.IsChecked = true;
            cHashBrowns.IsChecked = true;
            cIce.IsChecked = true;
            cKetchup.IsChecked = true;
            cLemon.IsChecked = false;
            cLettuce.IsChecked = true;
            cMayo.IsChecked = true;
            cMushrooms.IsChecked = true;
            cMustard.IsChecked = true;
            cOnion.IsChecked = true;
            cPancake.IsChecked = true;
            cPickle.IsChecked = true;
            cRoll.IsChecked = true;
            cRoomForCream.IsChecked = false;
            cSausageLink.IsChecked = true;
            cSirloin.IsChecked = true;
            cTomato.IsChecked = true;

        }
        /// <summary>
        /// hida all Customization
        /// </summary>
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
        /// <summary>
        /// clicked BriarheartBurger button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// clicked doubledraugr button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// click thalmorTriple button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Click SmokehouseSkeleton button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Click GardenOrcOmelette button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Click ThugsTBone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Click PhillyPoacher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Click cancel button, clear all
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickCancel(object sender, RoutedEventArgs e)
        {
            lists.Clear();
            total = 0;
            orderlist.Clear();
            orderprice.Clear();
        }
        /// <summary>
        /// Click ok to finish Customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                initialize();

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
                initialize();
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
                initialize();
            }
            if (string.Equals(button, "SmokehouseSkeleton"))
            {
                SmokehouseSkeleton a = new SmokehouseSkeleton();
                if (cSausageLink.IsChecked == false) a.SausageLink = false;
                if (cPancake.IsChecked == false) a.Pancake = false;
                if (cHashBrowns.IsChecked == false) a.HashBrowns = false;
                if (cEgg.IsChecked == false) a.Egg = false;
                var result = lists.Concat(a.SpecialInstructions);
                lists = result.ToList();
                orderlist.Text = string.Join("\n", lists);
                initialize();
            }
            if (string.Equals(button, "GardenOrcOmelette"))
            {
                GardenOrcOmelette a = new GardenOrcOmelette();
                if (cBroccoli.IsChecked == false) a.Broccoli = false;
                if (cCheddar.IsChecked == false) a.Cheddar = false;
                if (cMushrooms.IsChecked == false) a.Mushrooms = false;
                if (cTomato.IsChecked == false) a.Tomato = false;
                var result = lists.Concat(a.SpecialInstructions);
                lists = result.ToList();
                orderlist.Text = string.Join("\n", lists);

                initialize();
            }
            if (string.Equals(button, "PhillyPoacher"))
            {
                PhillyPoacher a = new PhillyPoacher();
                
                if (cOnion.IsChecked == false) a.Onion = false;
                if (cSirloin.IsChecked == false) a.Sirloin = false;
                if (cRoll.IsChecked == false) a.Roll = false;
                var result = lists.Concat(a.SpecialInstructions);
                lists = result.ToList();
                orderlist.Text = string.Join("\n", lists);
                initialize();

            }
            if (string.Equals(button, "WarriorWater"))
            {
                WarriorWater a = new WarriorWater();
                if (cMedium.IsChecked == true)
                {
                    a.Size = Size.Medium;
                }
                if (cLarge.IsChecked == true)
                {
                    a.Size = Size.Large;

                }
                if (cIce.IsChecked == false)
                {
                    a.Ice = false;
                }
                if (cLemon.IsChecked == true)
                {
                    a.Lemon = true;
                }
                total += a.Price;
                lists.Add(a.ToString());
                var result = lists.Concat(a.SpecialInstructions);
                lists = result.ToList();
                orderlist.Text = string.Join("\n", lists);
                string tp = "Subtotal: $" + total.ToString() + "\n" + "Tax:$" + (0.09 * total).ToString() + "\n" + "Total:$" + (1.09 * total).ToString();
                orderprice.Text = tp;
                initialize();

            }
            if (string.Equals(button, "CandlehearthCoffee"))
            {
                CandlehearthCoffee a = new CandlehearthCoffee();
                if (cMedium.IsChecked == true)
                {
                    a.Size = Size.Medium;
                }
                if (cLarge.IsChecked == true)
                {
                    a.Size = Size.Large;

                }
                if (cIce.IsChecked == true) a.Ice = true;
                if (cRoomForCream.IsChecked == true) a.RoomForCream = true;
                if (cDecaf.IsChecked == true) a.Decaf = true;
                total += a.Price;
                lists.Add(a.ToString());
                var result = lists.Concat(a.SpecialInstructions);
                lists = result.ToList();
                orderlist.Text = string.Join("\n", lists);
                string tp = "Subtotal: $" + total.ToString() + "\n" + "Tax:$" + (0.09 * total).ToString() + "\n" + "Total:$" + (1.09 * total).ToString();
                orderprice.Text = tp;
                initialize();
            }
            if (string.Equals(button, "SailorSoda"))
            {
                SailorSoda a = new SailorSoda();
                if (cMedium.IsChecked == true)
                {
                    a.Size = Size.Medium;
                }
                if (cLarge.IsChecked == true)
                {
                    a.Size = Size.Large;

                }
                if (cIce.IsChecked == false) a.Ice = false;
                if (cBlackberry.IsChecked == true) a.Flavor = SodaFlavor.Blackberry;
                if (cGrapef.IsChecked == true) a.Flavor = SodaFlavor.Grapefruit;
                if (cWatermelon.IsChecked == true) a.Flavor = SodaFlavor.Watermelon;
                if (cPeach.IsChecked == true) a.Flavor = SodaFlavor.Peach;
                if (cLemonflavor.IsChecked == true) a.Flavor = SodaFlavor.Lemon;

                total += a.Price;
                lists.Add(a.ToString());
                var result = lists.Concat(a.SpecialInstructions);
                lists = result.ToList();
                orderlist.Text = string.Join("\n", lists);
                string tp = "Subtotal: $" + total.ToString() + "\n" + "Tax:$" + (0.09 * total).ToString() + "\n" + "Total:$" + (1.09 * total).ToString();
                orderprice.Text = tp;
                initialize();
            }
            if (string.Equals(button, "MarkarthMilk"))
            {
                MarkarthMilk a = new MarkarthMilk();
                if (cMedium.IsChecked == true)
                {
                    a.Size = Size.Medium;
                }
                if (cLarge.IsChecked == true)
                {
                    a.Size = Size.Large;

                }
                if (cIce.IsChecked == true) a.Ice = true;
                
                total += a.Price;
                lists.Add(a.ToString());
                var result = lists.Concat(a.SpecialInstructions);
                lists = result.ToList();
                orderlist.Text = string.Join("\n", lists);
                string tp = "Subtotal: $" + total.ToString() + "\n" + "Tax:$" + (0.09 * total).ToString() + "\n" + "Total:$" + (1.09 * total).ToString();
                orderprice.Text = tp;
                initialize();
            }

            if (string.Equals(button, "AretinoAppleJuice"))
            {
                AretinoAppleJuice a = new AretinoAppleJuice();
                if (cMedium.IsChecked == true)
                {
                    a.Size = Size.Medium;
                }
                if (cLarge.IsChecked == true)
                {
                    a.Size = Size.Large;

                }
                if (cIce.IsChecked == true) a.Ice = true;

                total += a.Price;
                lists.Add(a.ToString());
                var result = lists.Concat(a.SpecialInstructions);
                lists = result.ToList();
                orderlist.Text = string.Join("\n", lists);
                string tp = "Subtotal: $" + total.ToString() + "\n" + "Tax:$" + (0.09 * total).ToString() + "\n" + "Total:$" + (1.09 * total).ToString();
                orderprice.Text = tp;
                initialize();
            }
            if (string.Equals(button, "VokunSalad"))
            {
                VokunSalad a = new VokunSalad();

                if (cMedium.IsChecked == true)
                {
                    a.Size = Size.Medium;
                }
                if (cLarge.IsChecked == true)
                {
                    a.Size = Size.Large;

                }
                

                total += a.Price;
                lists.Add(a.ToString());
                var result = lists.Concat(a.SpecialInstructions);
                lists = result.ToList();
                orderlist.Text = string.Join("\n", lists);
                string tp = "Subtotal: $" + total.ToString() + "\n" + "Tax:$" + (0.09 * total).ToString() + "\n" + "Total:$" + (1.09 * total).ToString();
                orderprice.Text = tp;
                initialize();
            }
            if (string.Equals(button, "FriedMiraak"))
            {
                FriedMiraak a = new FriedMiraak();

                if (cMedium.IsChecked == true)
                {
                    a.Size = Size.Medium;
                }
                if (cLarge.IsChecked == true)
                {
                    a.Size = Size.Large;

                }


                total += a.Price;
                lists.Add(a.ToString());
                var result = lists.Concat(a.SpecialInstructions);
                lists = result.ToList();
                orderlist.Text = string.Join("\n", lists);
                string tp = "Subtotal: $" + total.ToString() + "\n" + "Tax:$" + (0.09 * total).ToString() + "\n" + "Total:$" + (1.09 * total).ToString();
                orderprice.Text = tp;
                initialize();
            }
            if (string.Equals(button, "DragonbornWaffleFries"))
            {
                DragonbornWaffleFries a = new DragonbornWaffleFries();

                if (cMedium.IsChecked == true)
                {
                    a.Size = Size.Medium;
                }
                if (cLarge.IsChecked == true)
                {
                    a.Size = Size.Large;

                }


                total += a.Price;
                lists.Add(a.ToString());
                var result = lists.Concat(a.SpecialInstructions);
                lists = result.ToList();
                orderlist.Text = string.Join("\n", lists);
                string tp = "Subtotal: $" + total.ToString() + "\n" + "Tax:$" + (0.09 * total).ToString() + "\n" + "Total:$" + (1.09 * total).ToString();
                orderprice.Text = tp;
                initialize();
            }
            if (string.Equals(button, "MadOtarGrits"))
            {
                MadOtarGrits a = new MadOtarGrits();

                if (cMedium.IsChecked == true)
                {
                    a.Size = Size.Medium;
                }
                if (cLarge.IsChecked == true)
                {
                    a.Size = Size.Large;

                }


                total += a.Price;
                lists.Add(a.ToString());
                var result = lists.Concat(a.SpecialInstructions);
                lists = result.ToList();
                orderlist.Text = string.Join("\n", lists);
                string tp = "Subtotal: $" + total.ToString() + "\n" + "Tax:$" + (0.09 * total).ToString() + "\n" + "Total:$" + (1.09 * total).ToString();
                orderprice.Text = tp;
                initialize();
            }


        }
        /// <summary>
        /// click water button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickWater(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;
            hidden();
            cSmall.Visibility = Visibility.Visible;
            cMedium.Visibility = Visibility.Visible;
            cLarge.Visibility = Visibility.Visible;
            cIce.Visibility = Visibility.Visible;
            cLemon.Visibility = Visibility.Visible;

            button = "WarriorWater";

        }
        /// <summary>
        /// click soda button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickSoda(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;
            hidden();
            cSmall.Visibility = Visibility.Visible;
            cMedium.Visibility = Visibility.Visible;
            cLarge.Visibility = Visibility.Visible;
            cIce.Visibility = Visibility.Visible;
            cCherry.Visibility = Visibility.Visible;
            cBlackberry.Visibility = Visibility.Visible;
            cGrapef.Visibility = Visibility.Visible;
            cWatermelon.Visibility = Visibility.Visible;
            cPeach.Visibility = Visibility.Visible;
            cLemonflavor.Visibility = Visibility.Visible;
            button = "SailorSoda";
        }
        /// <summary>
        /// click coffee button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickCoffee(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;
            hidden();
            cSmall.Visibility = Visibility.Visible;
            cMedium.Visibility = Visibility.Visible;
            cLarge.Visibility = Visibility.Visible;
            button = "CandlehearthCoffee";
            cIce.Visibility = Visibility.Visible;
            cDecaf.Visibility = Visibility.Visible;
            cIce.IsChecked = false;
            cRoomForCream.Visibility = Visibility.Visible;


        }
        /// <summary>
        /// click milk button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickMilk(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;
            hidden();
            cSmall.Visibility = Visibility.Visible;
            cMedium.Visibility = Visibility.Visible;
            cLarge.Visibility = Visibility.Visible;
            button = "MarkarthMilk";
            cIce.Visibility = Visibility.Visible;
            cIce.IsChecked = false;

        }
        /// <summary>
        /// click salad button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickSalad(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;
            hidden();
            cSmall.Visibility = Visibility.Visible;
            cMedium.Visibility = Visibility.Visible;
            cLarge.Visibility = Visibility.Visible;
            button = "VokunSalad";

        }
        /// <summary>
        /// click FriedMiraak button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickMiraak(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;
            hidden();
            cSmall.Visibility = Visibility.Visible;
            cMedium.Visibility = Visibility.Visible;
            cLarge.Visibility = Visibility.Visible;
            button = "FriedMiraak";
        }
        /// <summary>
        /// DragonbornWaffleFries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickFries(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;
            hidden();
            cSmall.Visibility = Visibility.Visible;
            cMedium.Visibility = Visibility.Visible;
            cLarge.Visibility = Visibility.Visible;
            button = "DragonbornWaffleFries";
        }
        /// <summary>
        /// click MadOtarGrits button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickGrits(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;
            hidden();
            cSmall.Visibility = Visibility.Visible;
            cMedium.Visibility = Visibility.Visible;
            cLarge.Visibility = Visibility.Visible;
            button = "MadOtarGrits";
        }
        /// <summary>
        /// click AretinoAppleJuice button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickJuice(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;
            hidden();
            cSmall.Visibility = Visibility.Visible;
            cMedium.Visibility = Visibility.Visible;
            cLarge.Visibility = Visibility.Visible;
            cIce.Visibility = Visibility.Visible;
            cIce.IsChecked = false;
            button = "AretinoAppleJuice";

        }







        /// <summary>
        /// placed order, going to payment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickPlace(object sender, RoutedEventArgs e)
        {

            payment pay = new payment();
            this.Visibility = Visibility.Hidden;
            pay.Show();

        }




    }
}
