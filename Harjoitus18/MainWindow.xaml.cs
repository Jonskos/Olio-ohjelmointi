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
using Harjoitus5;

namespace Harjoitus18
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

        private void Laskin_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)e.OriginalSource;
            inputTb.Text = inputTb.Text.ToString() + button.Content;
        }
        private void Lasku_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)e.OriginalSource;
            
            if (!float.TryParse(inputTb.Text, out float input1))
            {
                throw new Exception();
            }
            if(!float.TryParse(inputTb2.Text, out float input2))
            {
                throw new Exception();
            }
            switch (button.Content)
            {
                case "Summa":
                    outputTb.Text = Harjoitus5.Laskin.Summa(input1, input2).ToString();
                    break;
                case "Erotus":
                    outputTb.Text = Harjoitus5.Laskin.Erotus(input1, input2).ToString();
                    break;
                case "Jako":
                    outputTb.Text = Harjoitus5.Laskin.Jako(input1, input2).ToString();
                    break;
                case "Kertolasku":
                    outputTb.Text = Harjoitus5.Laskin.Kertolasku(input1, input2).ToString();
                    break;
            }
        }

    }
}