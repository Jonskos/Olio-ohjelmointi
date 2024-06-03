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

namespace Harjoitus15
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
        public int kuormaautotCounter = 0;
        public int henkiloautotCounter = 0;

        //kun clickataan henkilöautonappia
        private void henkilöautoNappi_OnClick(object sender, RoutedEventArgs e)
        {
            //lisää henkilöauto, ja päivitä henkilöautotextblock
            henkiloautotCounter++;
            henkilöautoText.Text = $"henkilöautoja: {henkiloautotCounter}";
        }

        private void kuormaautoNappi_OnClick(object sender, RoutedEventArgs e)
        {
            //lisää kuormaauto, ja päivitä kuormaautotextblock
            kuormaautotCounter++;
            kuormaautoText.Text = $"kuormaautoja: {kuormaautotCounter}";
        }
    }
}
