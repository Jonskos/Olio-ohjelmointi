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

namespace Harjoitus17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float lämpötila;
        bool keittiöValot;
        bool olohuoneenValot;
        bool oviLukossa;
        public MainWindow()
        {
            InitializeComponent();
            lämpötila = 0;
            keittiöValot = false;
            keittiöValotTila.Text = "Pois";
            keittiöValotBtn.Content = "Päälle";
            olohuoneenValot = false;
            olohuoneenValotTila.Text = "Pois";
            olohuoneenValotBtn.Content = "Päälle";
            oviLukossa = true;
            oviLukossaTila.Text = "Lukossa";
            oviLukossaBtn.Content = "Avaa";

        }

        private void OlohuoneenValotBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (!olohuoneenValot)
            {
                olohuoneenValot = !olohuoneenValot;
                olohuoneenValotTila.Text = "Päällä";
                olohuoneenValotBtn.Content = "Pois";
            }
            else
            {
                olohuoneenValot = !olohuoneenValot;
                olohuoneenValotTila.Text = "Pois";
                olohuoneenValotBtn.Content = "Päälle";
            }
        }

        private void KeittiöValotBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (!keittiöValot)
            {
                keittiöValot = !keittiöValot;
                keittiöValotTila.Text = "Päällä";
                keittiöValotBtn.Content = "Pois";
            }
            else
            {
                keittiöValot = !keittiöValot;
                keittiöValotTila.Text = "Pois";
                keittiöValotBtn.Content = "Päälle";
            }
        }

        private void OviLukossaBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (!oviLukossa)
            {
                oviLukossa = !oviLukossa;
                oviLukossaTila.Text = "Lukossa";
                oviLukossaBtn.Content = "Avaa";
            }
            else
            {
                oviLukossa = !oviLukossa;
                oviLukossaTila.Text = "Avattu";
                oviLukossaBtn.Content = "Lukitse";
            }
        }
    }
}
