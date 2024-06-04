using System.ComponentModel;
using System.Runtime.CompilerServices;
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

namespace Harjoitus23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private bool paalla;

        public bool Paalla
        {
            get { return paalla; }
            set 
            { 
                paalla = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Paalla)));

            }
        }

        private float lämpötila;

        public float Lämpötila
        {
            get { return lämpötila; }
            set 
            { 
                if (value  < 0 || value > 120)
                {
                    new ArgumentOutOfRangeException("value out of range");
                }
                else
                {
                    lämpötila = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Lämpötila)));
                }
            }
        }

        private float kosteus;

        public event PropertyChangedEventHandler? PropertyChanged;

        public float Kosteus
        {
            get { return kosteus; }
            set 
            {
                if (value < 0 || value > 100)
                {
                    new ArgumentOutOfRangeException("value out of range");
                }
                else
                {
                    kosteus = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Kosteus)));
                }
            }
        }

        private bool lampotilaMuutos;

        public bool LampotilaMuutos
        {
            get { return lampotilaMuutos; }
            set { lampotilaMuutos = value; }
        }

        public MainWindow()
        {
            Paalla = false;
            InitializeComponent();
            this.DataContext = this;
        }

        private void numeroGrid_Click(object sender, RoutedEventArgs e)
        {
            //Nappi, jota painettiin (castataan napiksi jotta voidaan accessaa napin numero.)
            Button laskinBtn = (Button)e.OriginalSource;
            if (laskinBtn.Content.ToString() == "Enter")
            {
                return;
            }
            else if (laskinBtn.Content.ToString() == "<")
            {
                return;
            }
            kiuasInputTb.Text += laskinBtn.Content.ToString();
        }

        private void LaskinEnter_Click(object sender, RoutedEventArgs e)
        {
            if (lampotilaMuutos)
            {
                try
                {
                    Lämpötila = Convert.ToUInt64(kiuasInputTb.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    Kosteus = Convert.ToUInt64(kiuasInputTb.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            kiuasInputTb.Clear();
        }

        private void lämpötilaRb_Checked(object sender, RoutedEventArgs e)
        {
            if (!lampotilaMuutos)
            {
                lampotilaMuutos = true;
                kosteusRb.IsChecked = false;
                lämpötilaRb.IsChecked = true;
            }
        }

        private void kosteusRb_Checked(object sender, RoutedEventArgs e)
        {
            if (lampotilaMuutos)
            {
                lampotilaMuutos = false;
                kosteusRb.IsChecked = true;
                lämpötilaRb.IsChecked = false;
            }
        }

        private void paallaBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!Paalla)
            {
                Paalla = true;
                paallaBtn.Content = "Pois";
            }
            else
            {
                Paalla = false;
                paallaBtn.Content = "Päälle";
            }
        }
    }
}