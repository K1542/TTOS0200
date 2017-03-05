using System;
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

namespace H6T3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    private readonly double conversionRate = 5.946;
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void toEuro(object sender, RoutedEventArgs e)
        {
            double result;
            bool isOk = double.TryParse(textBoxMarkka.Text.Replace(",", "."), out result);
            if (isOk)
            {
                textBoxEuro.Text = (result / conversionRate).ToString("0.00");
            }
            else
            {
                textBoxEuro.Text = "ERROR";
            }
        }

        private void toMarkka(object sender, RoutedEventArgs e)
        {
            double result;
            bool isOk = double.TryParse(textBoxEuro.Text.Replace(",", "."), out result);
            if (isOk)
            {
                textBoxMarkka.Text = (result * conversionRate).ToString("0.00");
            }
            else
            {
                textBoxMarkka.Text = "ERROR";
            }
    }
}
