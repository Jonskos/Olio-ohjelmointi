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

namespace Harjoitus16
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void UnitSelectBtn_OnClick(object sender, RoutedEventArgs e)
        {
            //jos nappi on km muuta se mi, muuten km
            if (unitSelectBtn.Content.ToString() == "km")
            {
                unitSelectBtn.Content = "mi";
            }
            else
            {
                unitSelectBtn.Content = "km";
            }
        }
        private void BtnKmToMiles_OnClick(object sender, RoutedEventArgs e)
        {
            //jos on valittuna kilometrit
            if (unitSelectBtn.Content.ToString() == "km")
            {
                //ja input on numero
                if (float.TryParse(kilometersInput.Text, out float kilometers))
                {
                    //muunna kilometrit mailiksi, ja tulosta se milesinputtiin
                    milesInput.Text = ConvertKmToMiles(kilometers).ToString();
                }
                else { throw new Exception(); }
            }
            //muuten jos on mailit
            else if (unitSelectBtn.Content.ToString() == "mi")
            {
                //ja input on numero
                if (float.TryParse(milesInput.Text, out float miles))
                {
                    //muunna mailit kilometreiksi ja tulosta se kilometersinputtiin
                    kilometersInput.Text = ConvertMilesToKm(miles).ToString();
                }
                else { throw new Exception(); }
            }
        }
        private float ConvertKmToMiles(float kilometers)
        {
            //muuntaa kilometrit maileiksi
            float miles = kilometers / 1.6093445f;
            return miles;
        }
        private float ConvertMilesToKm(float miles)
        {
            //muunna kilometriksi
            float kilometers = miles * 1.6093445f;
            return kilometers;
        }
    }
}
