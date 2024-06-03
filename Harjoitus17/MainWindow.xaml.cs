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
            //Aseta lähtömuuntujat
            lämpötila = 19;
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
            //jos olohuoneenvalot on pois
            if (!olohuoneenValot)
            {
                //vaihda olohuoneenValot muuntujan tila toiseksi kuin on (päälle)
                olohuoneenValot = !olohuoneenValot;
                //ja vaihda textblockien texti samaksi kuin tila
                olohuoneenValotTila.Text = "Päällä";
                olohuoneenValotBtn.Content = "Pois";
            }
            //muuten
            else
            {
                //vaihda olohuoneenValot muuntujan tila toiseksi kuin on (pois)
                olohuoneenValot = !olohuoneenValot;
                //ja vaihda textblockien texti samaksi kuin tila
                olohuoneenValotTila.Text = "Pois";
                olohuoneenValotBtn.Content = "Päälle";
            }
        }

        private void KeittiöValotBtn_OnClick(object sender, RoutedEventArgs e)
        {
            //jos keittiönvalot on pois
            if (!keittiöValot)
            {
                //vaihda keittiöValot muuntujan tila toiseksi kuin on (päälle)
                keittiöValot = !keittiöValot;
                //ja vaihda textblockien texti samaksi kuin tila
                keittiöValotTila.Text = "Päällä";
                keittiöValotBtn.Content = "Pois";
            }
            //muuten
            else
            {
                //vaihda keittiöValot muuntujan tila toiseksi kuin on (pois)
                keittiöValot = !keittiöValot;
                //ja vaihda textblockien texti samaksi kuin tila
                keittiöValotTila.Text = "Pois";
                keittiöValotBtn.Content = "Päälle";
            }
        }

        private void OviLukossaBtn_OnClick(object sender, RoutedEventArgs e)
        {
            //jos oviLukossa on pois, eli avattuna
            if (!oviLukossa)
            {
                //vaihda oviLukossa muuntujan tila toiseksi kuin on (päälle)
                oviLukossa = !oviLukossa;
                //ja vaihda textblockien texti samaksi kuin tila
                oviLukossaTila.Text = "Lukossa";
                oviLukossaBtn.Content = "Avaa";
            }
            //muuten
            else
            {
                //vaihda oviLukossa muuntujan tila toiseksi kuin on (pois)
                oviLukossa = !oviLukossa;
                //ja vaihda textblockien texti samaksi kuin tila
                oviLukossaTila.Text = "Avattu";
                oviLukossaBtn.Content = "Lukitse";
            }
        }
        private void LämpötilaSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //muunna lämpötila muuttuja samaksi kuin lämpötilaSlider, kun sen arvo vaihtuu
            lämpötila = Convert.ToInt32(lämpötilaSlider.Value);
        }
    }
}
