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
            //Nappi, jota painettiin (castataan napiksi jotta voidaan accessaa napin numero.)
            Button laskinBtn = (Button)e.OriginalSource;
            //näppäimistön (ei looginen, koska käytetään textboxeja, johon kirjoitetaan.) focusattu elementti
            IInputElement focusedControl = Keyboard.FocusedElement;
            //jos focusattu elementti on TextBox, asettaa TextBoxin textBox
            if (focusedControl is TextBox textBox)
            {
                //Aseta textbox textboxin textiin ja laskimen napin numeroon
                textBox.Text += laskinBtn.Content;
            }
        }
        private void Lasku_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)e.OriginalSource;
            //Hard codetetut textboxit, jos olisi iso projekti en tekisi, mutta tässä annan sen olla
            if (!float.TryParse(inputTb.Text, out float input1))
            {
                throw new Exception();
            }
            if(!float.TryParse(inputTb2.Text, out float input2))
            {
                throw new Exception();
            }
            //myöskin voisin varmaan tehdä paremmin, mutta se toimií.
            //tarkistaa, mitä funkitota käyttää.
            switch (button.Content)
            {
                case "Summa":
                    outputTb.Text = Laskin.Summa(input1, input2).ToString();
                    break;
                case "Erotus":
                    outputTb.Text = Laskin.Erotus(input1, input2).ToString();
                    break;
                case "Jako":
                    outputTb.Text = Laskin.Jako(input1, input2).ToString();
                    break;
                case "Kertolasku":
                    outputTb.Text = Laskin.Kertolasku(input1, input2).ToString();
                    break;
            }
        }

    }
}