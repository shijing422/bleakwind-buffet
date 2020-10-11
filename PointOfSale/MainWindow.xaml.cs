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
using BleakwindBuffet.Data;
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





        Order Orders = new Order();
        /// <summary>
        /// initialize
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            Customization.Visibility = Visibility.Hidden;
        }

        /* /// <summary>
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

                 cLemonflavor.IsEnabled = true;
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

         }*/



        /// <summary>
        /// initialize Customization
        /// </summary>
        void initialize()
        {
            /* cLemonflavor.IsEnabled = true;
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
             */
        }
        /// <summary>
        /// hida all Customization
        /// </summary>
        void hidden()
        {
            sizelist.Visibility = Visibility.Hidden;
            flvaorlist.Visibility = Visibility.Hidden;

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
            /*BriarheartBurger a = new BriarheartBurger();
            total += a.Price;
            lists.Add(a.ToString());
            orderlists.Text = string.Join("\n", lists);
            string tp = "Subtotal: $" + total.ToString() + "\n" + "Tax:$" + Math.Round((0.09*total),4).ToString() + "\n" + "Total:$" + Math.Round((1.09*total),4).ToString();
            orderprice.Text = tp;*/

            hidden();
            cBun.Visibility = Visibility.Visible;
            cKetchup.Visibility = Visibility.Visible;
            cMustard.Visibility = Visibility.Visible;
            cPickle.Visibility = Visibility.Visible;
            cCheese.Visibility = Visibility.Visible;

            this.DataContext = new BriarheartBurger();


        }
        /// <summary>
        /// clicked doubledraugr button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickDoubleDraugr(object sender, RoutedEventArgs e)
        {

            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;

            hidden();
            cBun.Visibility = Visibility.Visible;
            cKetchup.Visibility = Visibility.Visible;
            cMustard.Visibility = Visibility.Visible;
            cPickle.Visibility = Visibility.Visible;
            cCheese.Visibility = Visibility.Visible;
            cTomato.Visibility = Visibility.Visible;
            cLettuce.Visibility = Visibility.Visible;
            cMayo.Visibility = Visibility.Visible;
            this.DataContext = new DoubleDraugr();


        }
        /// <summary>
        /// click thalmorTriple button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickThalmorTriple(object sender, RoutedEventArgs e)
        {

            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;


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
            this.DataContext = new ThalmorTriple();

        }
        /// <summary>
        /// Click SmokehouseSkeleton button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickSmokehouseSkeleton(object sender, RoutedEventArgs e)
        {

            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;


            hidden();
            cSausageLink.Visibility = Visibility.Visible;
            cEgg.Visibility = Visibility.Visible;
            cHashBrowns.Visibility = Visibility.Visible;
            cPancake.Visibility = Visibility.Visible;


            this.DataContext = new SmokehouseSkeleton();


        }
        /// <summary>
        /// Click GardenOrcOmelette button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickGardenOrcOmelette(object sender, RoutedEventArgs e)
        {

            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;


            hidden();
            cBroccoli.Visibility = Visibility.Visible;
            cMushrooms.Visibility = Visibility.Visible;
            cTomato.Visibility = Visibility.Visible;
            cCheddar.Visibility = Visibility.Visible;

            this.DataContext = new GardenOrcOmelette();

        }
        /// <summary>
        /// Click ThugsTBone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickThugsTBone(object sender, RoutedEventArgs e)
        {
            ThugsTBone a = new ThugsTBone();
            Orders.Add(a);
            listviewload();



        }
        /// <summary>
        /// Click PhillyPoacher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickPhillyPoacher(object sender, RoutedEventArgs e)
        {

            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;

            hidden();
            cSirloin.Visibility = Visibility.Visible;
            cRoll.Visibility = Visibility.Visible;
            cOnion.Visibility = Visibility.Visible;

            this.DataContext = new PhillyPoacher();
        }
        /// <summary>
        /// Click cancel button, clear all
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickCancel(object sender, RoutedEventArgs e)
        {

            Orders.Clear();
            listviewload();


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

            if (DataContext is BriarheartBurger bb)
            {
                Orders.Add(bb);
                listviewload();

                initialize();
            }


            if (DataContext is DoubleDraugr dd)
            {
                Orders.Add(dd);
                listviewload();



                initialize();
            }
            if (DataContext is ThalmorTriple tt)
            {
                Orders.Add(tt);
                listviewload();

                initialize();
            }
            if (DataContext is SmokehouseSkeleton ss)
            {
                Orders.Add(ss);
                listviewload();

                initialize();
            }
            if (DataContext is GardenOrcOmelette goo)
            {
                Orders.Add(goo);
                listviewload();

                initialize();
            }
            if (DataContext is PhillyPoacher pp)
            {
                Orders.Add(pp);
                listviewload();

                initialize();

            }
            if (DataContext is WarriorWater ww)
            {


                Orders.Add(ww);
                listviewload();

                initialize();

            }
            if (DataContext is CandlehearthCoffee cc)
            {


                Orders.Add(cc);
                listviewload();

                initialize();
            }
            if (DataContext is SailorSoda soda)
            {

                /*if (cMedium.IsChecked == true)
                {
                    soda.Size = Size.Medium;
                }
                if (cLarge.IsChecked == true)
                {
                    soda.Size = Size.Large;

                }
                
                if (cBlackberry.IsChecked == true) soda.Flavor = SodaFlavor.Blackberry;
                if (cGrapef.IsChecked == true) soda.Flavor = SodaFlavor.Grapefruit;
                if (cWatermelon.IsChecked == true) soda.Flavor = SodaFlavor.Watermelon;
                if (cPeach.IsChecked == true) soda.Flavor = SodaFlavor.Peach;
                if (cLemonflavor.IsChecked == true) soda.Flavor = SodaFlavor.Lemon;
                */

                Orders.Add(soda);
                listviewload();

                initialize();
            }
            if (DataContext is MarkarthMilk mm)
            {

                Orders.Add(mm);
                listviewload();
                /*total += mm.Price;
                lists.Add(mm.ToString());
                var result = lists.Concat(mm.SpecialInstructions);
                lists = result.ToList();
                orderlists.Text = string.Join("\n", lists);
                string tp = "Subtotal: $" + total.ToString() + "\n" + "Tax:$" + Math.Round((0.09*total),4).ToString() + "\n" + "Total:$" + Math.Round((1.09*total),4).ToString();
                orderprice.Text = tp;*/
                initialize();
            }

            if (DataContext is AretinoAppleJuice aa)
            {




                Orders.Add(aa);
                listviewload();

                initialize();
            }
            if (DataContext is VokunSalad a)
            {



                Orders.Add(a);
                listviewload();

                initialize();
            }
            if (DataContext is FriedMiraak f)
            {


                Orders.Add(f);
                listviewload();

                initialize();
            }
            if (DataContext is DragonbornWaffleFries d)
            {



                Orders.Add(d);
                listviewload();

                initialize();
            }
            if (DataContext is MadOtarGrits m)
            {




                Orders.Add(m);
                listviewload();


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
            sizelist.Visibility = Visibility.Visible;
            cIce.Visibility = Visibility.Visible;
            cLemon.Visibility = Visibility.Visible;

            this.DataContext = new WarriorWater();

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
            flvaorlist.Visibility = Visibility.Visible;
            sizelist.Visibility = Visibility.Visible;
            cIce.Visibility = Visibility.Visible;



            this.DataContext = new SailorSoda();
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
            sizelist.Visibility = Visibility.Visible;

            cIce.Visibility = Visibility.Visible;
            cDecaf.Visibility = Visibility.Visible;
            cIce.IsChecked = false;
            cRoomForCream.Visibility = Visibility.Visible;
            this.DataContext = new CandlehearthCoffee();

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
            sizelist.Visibility = Visibility.Visible;

            cIce.Visibility = Visibility.Visible;
            cIce.IsChecked = false;
            this.DataContext = new MarkarthMilk();

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
            sizelist.Visibility = Visibility.Visible;

            this.DataContext = new VokunSalad();


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
            sizelist.Visibility = Visibility.Visible;


            this.DataContext = new FriedMiraak();
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
            sizelist.Visibility = Visibility.Visible;


            this.DataContext = new DragonbornWaffleFries();
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
            sizelist.Visibility = Visibility.Visible;

            this.DataContext = new MadOtarGrits();

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
            sizelist.Visibility = Visibility.Visible;
            cIce.Visibility = Visibility.Visible;
            cIce.IsChecked = false;


            this.DataContext = new AretinoAppleJuice();

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


        public void listviewload()

        {
            listview.Items.Clear();
            foreach (IOrderItem i in Orders)
            {
                string row = i.ToString() + "  $:" + i.Price.ToString() + "\n" + string.Join("\n", i.SpecialInstructions);
                ListViewItem lvl = new ListViewItem();

                lvl.Tag = i;
                lvl.Content = row;

                listview.Items.Add(lvl);

            }

            string tp = "Subtotal: $" + Math.Round(Orders.Subtotal, 4).ToString() + "\n" + "Tax:$" + Math.Round(Orders.Tax, 4).ToString() + "\n" + "Total:$" + Math.Round(Orders.Total, 4).ToString();
            orderprice.Text = tp;

            string num = "Order# " + Orders.Number.ToString();

            ordernum.Text = num;


        }

        void clickRemoveItem(object sender, RoutedEventArgs e)
        {
            try
            {
                ListViewItem selectedItem = (ListViewItem)listview.SelectedItem;
                if (selectedItem != null)
                {
                    IOrderItem i = (IOrderItem)selectedItem.Tag;

                    Orders.Remove(i);
                    listviewload();
                }



            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }

        }
        void clickNewOrder(object sender, RoutedEventArgs e)
        {
            Orders = new Order();
            listviewload();


        }



    }
}
