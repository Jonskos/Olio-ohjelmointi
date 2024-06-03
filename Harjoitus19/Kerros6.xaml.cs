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

namespace Harjoitus19
{
    /// <summary>
    /// Interaction logic for Kerros6.xaml
    /// </summary>
    public partial class Kerros6 : Page
    {
        public Kerros6()
        {
            InitializeComponent();
        }
        //Edelliseen kerrokseen navigointi
        private void PrevPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Kerros5());
        }
        private void HissiBtnGrid_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow).KerrosNavigointi(sender, e);
        }
    }
}
