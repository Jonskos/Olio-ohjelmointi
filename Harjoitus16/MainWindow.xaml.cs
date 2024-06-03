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
            if (unitSelectBtn.Content.ToString() == "km")
            {
                if (float.TryParse(kilometersInput.Text, out float kilometers))
                {
                    milesInput.Text = ConvertKmToMiles(kilometers).ToString();
                }
                else { throw new Exception(); }
            }
            else if (unitSelectBtn.Content.ToString() == "mi")
            {
                
                if (float.TryParse(milesInput.Text, out float miles))
                {
                    kilometersInput.Text = ConvertMilesToKm(miles).ToString();
                }
                else { throw new Exception(); }
            }
        }
        private float ConvertKmToMiles(float kilometers)
        {
            float miles = kilometers / 1.6093445f;
            return miles;
        }
        private float ConvertMilesToKm(float miles)
        {
            float kilometers = miles * 1.6093445f;
            return kilometers;
        }
    }
}
