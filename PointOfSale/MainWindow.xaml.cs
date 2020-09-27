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
        double total;
        List<string> lists = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            Customization.Visibility = Visibility.Hidden;
        }
        void ClickBriarheartBurger(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;




        }
        void ClickDoubleDraugr(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;




        }
        void ClickThalmorTriple(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;




        }
        void ClickSmokehouseSkeleton(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;
            






        }
        void ClickGardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;




        }
        void ClickThugsTBone(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;




        }
        void ClickPhillyPoacher(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Hidden;
            Customization.Visibility = Visibility.Visible;




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


        }
        void ClickPlace(object sender, RoutedEventArgs e)
        {
            Payment payment = new Payment();
            this.Visibility = Visibility.Hidden;
            payment.Visibility=Visibility.Visible;

        }




    }
}
