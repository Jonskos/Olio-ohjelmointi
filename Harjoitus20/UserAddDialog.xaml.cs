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

namespace Harjoitus20
{
    /// <summary>
    /// Interaction logic for UserAddDialog.xaml
    /// </summary>
    public partial class UserAddDialog : Window
    {
        public UserAddDialog(string kysymys1, string kysymys2, string kysymys3, string kysymys4, string kysymys5)
        {
            InitializeComponent();
            ensimmäinenLabel.Content = kysymys1;
            toinenLabel.Content = kysymys2;
            kolmasLabel.Content = kysymys3;
            neljäsLabel.Content = kysymys4;
            viidesLabel.Content = kysymys5;
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        public string Vastaus1
        {
            get { return ensimmäinenTb.Text; }
        }
        public string Vastaus2
        {
            get { return toinenTb.Text; }
        }
        public string Vastaus3
        {
            get { return kolmasTb.Text; }
        }
        public string Vastaus4
        {
            get { return neljäsTb.Text; }
        }
        public string Vastaus5
        {
            get { return viidesTb.Text; }
        }
    }
}
