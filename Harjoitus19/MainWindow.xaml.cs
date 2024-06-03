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

namespace Harjoitus19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Kun Window aloitaa, navigoi Kerros1:een
            mainFrame.NavigationService.Navigate(new Kerros1());
        }
        //Navigaatio metodi, jota kerrokset kutsuvat
        public void KerrosNavigointi(object sender, RoutedEventArgs e)
        {
            Button hissiBtn = (Button)e.OriginalSource;

            //tarkistaa napin numero, ja siirtyy sitten kerrokseen.
            switch (hissiBtn.Content)
            {
                case "1":
                    mainFrame.NavigationService.Navigate(new Kerros1());
                    break;
                case "2":
                    mainFrame.NavigationService.Navigate(new Kerros2());
                    break;
                case "3":
                    mainFrame.NavigationService.Navigate(new Kerros3());
                    break;
                case "4":
                    mainFrame.NavigationService.Navigate(new Kerros4());
                    break;
                case "5":
                    mainFrame.NavigationService.Navigate(new Kerros5());
                    break;
                case "6":
                    mainFrame.NavigationService.Navigate(new Kerros6());
                    break;
                default:
                    break;
            }
        }
    }
}