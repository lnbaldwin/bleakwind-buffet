using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BleakwindBuffet.PointOfSale.DrinkWindows
{
    /// <summary>
    /// Interaction logic for CustomizeMarkarthMilk.xaml
    /// </summary>
    public partial class CustomizeMM : UserControl
    {
        public MainWindow MainWindow { get; set; }
        public CustomizeMM()
        {
            InitializeComponent();
        }

        //navigation Event Handlers:
        //rn, both events will change the child of buttonDisplay to a new MenuButtons obj
        //later, the functionality will be added to the finish button

        void CancelOrder(Object sender, RoutedEventArgs e)
        {
            var buttonDisplay = new MenuButtons();
            buttonDisplay.MainWindow = MainWindow;
            MainWindow.displayBorder.Child = buttonDisplay;
        }

        void FinishOrder(Object sender, RoutedEventArgs e)
        {
            var buttonDisplay = new MenuButtons();
            buttonDisplay.MainWindow = MainWindow;
            MainWindow.displayBorder.Child = buttonDisplay;
        }
    }
}
