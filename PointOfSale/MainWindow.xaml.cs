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
using BleakwindBuffet.PointOfSale.DrinkWindows;
using BleakwindBuffet.PointOfSale.SideWindows;
using BleakwindBuffet.PointOfSale.EntreeWindows;

namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<IOrderItem> order = new List<IOrderItem>();
        public MainWindow()
        {
            InitializeComponent();
        }

        //when the user clicks a button, we want them to be taken to the cooresponding customization screen:
        //If a button is pressed, we will open the customization screen
        //Closing and adding orderItem to list will be handeled in each individua window
        
        //Opening the Customization Screens:
        void CustomizeAAJHandler(Object sender, RoutedEventArgs e)
        {
            var AAJWindow = new CustomizeAAJ();
            ButtonAndCustomizationDisplay.Child = AAJWindow;
        }
        void CustomizeCCHandler(Object sender, RoutedEventArgs e)
        {
            var CCWindow = new CustomizeCC();
            ButtonAndCustomizationDisplay.Child = CCWindow;
        }
        void CustomizeMMHandler(Object sender, RoutedEventArgs e)
        {
            var MMWindow = new CustomizeMM();
            ButtonAndCustomizationDisplay.Child = MMWindow;
        }
        void CustomizeSSHandler(Object sender, RoutedEventArgs e)
        {
            var SSWindow = new CustomizeSS();
            ButtonAndCustomizationDisplay.Child = SSWindow;
        }
        void CustomizeWWHandler(Object sender, RoutedEventArgs e)
        {
            var WWWindow = new CustomizeWW();
            ButtonAndCustomizationDisplay.Child = WWWindow;
        }
        void CustomizeBBHandler(Object sender, RoutedEventArgs e)
        {
            var BBWindow = new CustomizeBB();
            ButtonAndCustomizationDisplay.Child = BBWindow;
        }
        void CustomizeDDHandler(Object sender, RoutedEventArgs e)
        {
            var DDWindow = new CustomizeDD();
            ButtonAndCustomizationDisplay.Child = DDWindow;
        }
        void CustomizeOOHandler(Object sender, RoutedEventArgs e)
        {
            var OOWindow = new CustomizeOO();
            ButtonAndCustomizationDisplay.Child = OOWindow;
        }
        void CustomizePPHandler(Object sender, RoutedEventArgs e)
        {
            var PPWindow = new CustomizePP();
            ButtonAndCustomizationDisplay.Child = PPWindow;
        }
        void CustomizeDWHandler(Object sender, RoutedEventArgs e)
        {
            var DWWindow = new CustomizeDW();
            ButtonAndCustomizationDisplay.Child = DWWindow;
        }
        void CustomizeFMHandler(Object sender, RoutedEventArgs e)
        {
            var FMWindow = new CustomizeFM();
            ButtonAndCustomizationDisplay.Child = FMWindow;
        }
        void CustomizeMGHandler(Object sender, RoutedEventArgs e)
        {
            var MGWindow = new CustomizeMG();
            ButtonAndCustomizationDisplay.Child = MGWindow;
        }
        void CustomizeVSHandler(Object sender, RoutedEventArgs e)
        {
            var VSWindow = new CustomizeVS();
            ButtonAndCustomizationDisplay.Child = VSWindow;
        }
        
        void CustomizeSHSHandler(Object sender, RoutedEventArgs e)
        {
            var SHSWindow = new CustomizeSHS();
            ButtonAndCustomizationDisplay.Child = SHSWindow;
        }
        void CustomizeTBHandler(Object sender, RoutedEventArgs e)
        {
            var TBWindow = new CustomizeTB();
            ButtonAndCustomizationDisplay.Child = TBWindow;
        }
        void CustomizeTTHandler(Object sender, RoutedEventArgs e)
        {
            var TTWindow = new CustomizeTT();
            ButtonAndCustomizationDisplay.Child = TTWindow;
        }

    }
}
