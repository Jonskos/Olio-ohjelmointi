using System.DirectoryServices.ActiveDirectory;
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

namespace Harjoitus22
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
        private void laskeIkkunaBtn_Click(object sender, RoutedEventArgs e)
        {
            int korkeus = int.Parse(ikkunanKorkeusTb.Text);
            int leveys = int.Parse(ikkunanLeveysTb.Text);
            int thicknessInt = int.Parse(karmipuunLeveysTb.Text);
            Thickness thickness = new Thickness(thicknessInt, thicknessInt, thicknessInt, thicknessInt);
            PintaAlaIkkuna pintaAlaIkkuna = new PintaAlaIkkuna()
            {
                Height = korkeus,
                Width = leveys,
                BorderThickness = thickness

            };
            pintaAlaIkkuna.Show();
            int ikkunanPintaAla = (leveys + thicknessInt) * (korkeus + thicknessInt);
            lasinPintaAlaTb.Text = (leveys * korkeus) + "^2".ToString();
            ikkunanPintaAlaTb.Text = ikkunanPintaAla + "^2".ToString();
            karminPiiriTb.Text = (thicknessInt * 4).ToString();
        }
    }
}