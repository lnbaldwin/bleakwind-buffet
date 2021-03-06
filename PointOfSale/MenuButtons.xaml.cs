﻿using System;
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
using BleakwindBuffet.PointOfSale.DrinkWindows;
using BleakwindBuffet.PointOfSale.SideWindows;
using BleakwindBuffet.PointOfSale.EntreeWindows;

namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuButtons.xaml
    /// </summary>
    public partial class MenuButtons : UserControl
    {
        public MainWindow MainWindow
        {
            get
            {
                return ((Border)this.Parent).Parent as MainWindow;
            }
            set
            {
                MainWindow = value;
            }
        }

        public MenuButtons()
        {
            InitializeComponent();
        }
        //when the user clicks a button, we want them to be taken to the coresponding customization screen:
        //If a button is pressed, we will open the customization screen by making it the child of displayBorder

        //Drink Event Handlers:

        void CustomizeAAJHandler(Object sender, RoutedEventArgs e)
        {
            var AAJWindow = new CustomizeAAJ();
            AAJWindow.MainWindow = MainWindow;
            MainWindow.displayBorder.Child = AAJWindow;
        }
        void CustomizeCCHandler(Object sender, RoutedEventArgs e)
        {
            var CCWindow = new CustomizeCC();
            CCWindow.MainWindow = MainWindow;
            MainWindow.displayBorder.Child = CCWindow;
        }
        void CustomizeMMHandler(Object sender, RoutedEventArgs e)
        {
            var MMWindow = new CustomizeMM();
            MMWindow.MainWindow = MainWindow;
            MainWindow.displayBorder.Child = MMWindow;
        }
        void CustomizeSSHandler(Object sender, RoutedEventArgs e)
        {
            var SSWindow = new CustomizeSS();
            SSWindow.MainWindow = MainWindow;
            MainWindow.displayBorder.Child = SSWindow;
        }
        void CustomizeWWHandler(Object sender, RoutedEventArgs e)
        {
            var WWWindow = new CustomizeWW();
            WWWindow.MainWindow = MainWindow;
            MainWindow.displayBorder.Child = WWWindow;
        }

        //Entree Event Handlers:

        void CustomizeBBHandler(Object sender, RoutedEventArgs e)
        {
            var BBWindow = new CustomizeBB();
            BBWindow.MainWindow = MainWindow;
            MainWindow.displayBorder.Child = BBWindow;
        }
        void CustomizeDDHandler(Object sender, RoutedEventArgs e)
        {
            var DDWindow = new CustomizeDD();
            DDWindow.MainWindow = MainWindow;
            MainWindow.displayBorder.Child = DDWindow;
        }
        void CustomizeOOHandler(Object sender, RoutedEventArgs e)
        {
            var OOWindow = new CustomizeOO();
            OOWindow.MainWindow = MainWindow;
            MainWindow.displayBorder.Child = OOWindow;
        }
        void CustomizePPHandler(Object sender, RoutedEventArgs e)
        {
            var PPWindow = new CustomizePP();
            PPWindow.MainWindow = MainWindow;
            MainWindow.displayBorder.Child = PPWindow;
        }
        void CustomizeSHSHandler(Object sender, RoutedEventArgs e)
        {
            var SHSWindow = new CustomizeSHS();
            SHSWindow.MainWindow = MainWindow;
            MainWindow.displayBorder.Child = SHSWindow;
        }
        void CustomizeTBHandler(Object sender, RoutedEventArgs e)
        {
            var TBWindow = new CustomizeTB();
            TBWindow.MainWindow = MainWindow;
            MainWindow.displayBorder.Child = TBWindow;
        }
        void CustomizeTTHandler(Object sender, RoutedEventArgs e)
        {
            var TTWindow = new CustomizeTT();
            TTWindow.MainWindow = MainWindow;
            MainWindow.displayBorder.Child = TTWindow;
        }

        //Side Event Handlers:

        void CustomizeDWHandler(Object sender, RoutedEventArgs e)
        {
            var DWWindow = new CustomizeDW();
            DWWindow.MainWindow = MainWindow;
            MainWindow.displayBorder.Child = DWWindow;
        }
        void CustomizeFMHandler(Object sender, RoutedEventArgs e)
        {
            var FMWindow = new CustomizeFM();
            FMWindow.MainWindow = MainWindow;
            MainWindow.displayBorder.Child = FMWindow;
        }
        void CustomizeMGHandler(Object sender, RoutedEventArgs e)
        {
            var MGWindow = new CustomizeMG();
            MGWindow.MainWindow = MainWindow;
            MainWindow.displayBorder.Child = MGWindow;
        }
        void CustomizeVSHandler(Object sender, RoutedEventArgs e)
        {
            var VSWindow = new CustomizeVS();
            VSWindow.MainWindow = MainWindow;
            MainWindow.displayBorder.Child = VSWindow;
        }
    }
}
