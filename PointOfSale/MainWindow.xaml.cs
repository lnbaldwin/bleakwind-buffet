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
        MenuButtons buttonDisplay = new MenuButtons();
        public MainWindow()
        {
            InitializeComponent();
            //Make the MenuButtons the first thing displayed in the window upon opening
            displayBorder.Child = buttonDisplay;
            buttonDisplay.MainWindow = this;


        }

    }
}
