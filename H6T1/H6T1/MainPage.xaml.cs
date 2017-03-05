﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace H6T1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void buttonTruck_Click(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(numTrucks.Text);
            value++;
            numTrucks.Text = value.ToString();
        }

        private void buttonCars_Click(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(numCars.Text);
            value++;
            numCars.Text = value.ToString();
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            numTrucks.Text = "0";
            numCars.Text = "0";
        }
    }
}
