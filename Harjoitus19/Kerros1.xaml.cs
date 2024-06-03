using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace Harjoitus19
{
    /// <summary>
    /// Interaction logic for Kerros1.xaml
    /// </summary>
    public partial class Kerros1 : Page
    {
        public Kerros1()
        {
            InitializeComponent();
        }
        //Seuraavaan Kerrokseen navigointi
        private void NextPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Kerros2());
        }
        private void HissiBtnGrid_Click(object sender, RoutedEventArgs e)
        {
            //on mahdollista tehdä eventeillä, mutta en tiedä miten.
            //kutsuu MainWindowin KerrosNavigointi metodin
            ((MainWindow)System.Windows.Application.Current.MainWindow).KerrosNavigointi(sender, e);
        }
    }
}
