using Harjoitus26.View.UserControls;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
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
using System.Diagnostics;

namespace Harjoitus26
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

        private void lisääTehtäväBtn_Click(object sender, RoutedEventArgs e)
        {
            Tehtävä tehtävä = new Tehtävä()
            {
                Nimi = tehtäväNimiTb.Text.ToString(),
                Kuvaus = tehtäväKuvausTb.Text.ToString(),
                Antaja = tehtäväAntajaTb.Text.ToString(),
            };
            tehtäväPanel.Children.Add(tehtävä);
        }

        private void poistaTehtäväBtn_Click(object sender, RoutedEventArgs e)
        {
            TehtäväLista.Remove(poistaTehtäväNimiTb.Text.ToString());
            tehtäväPanel.Children.Clear();

            foreach (Tehtävä tehtävä in TehtäväLista.Get())
            {
                tehtäväPanel.Children.Add(tehtävä);
                
            }
        }
    }
}