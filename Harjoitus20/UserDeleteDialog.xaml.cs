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
using System.Windows.Shapes;

namespace Harjoitus20
{
    /// <summary>
    /// Interaction logic for UserDeleteDialog.xaml
    /// </summary>
    public partial class UserDeleteDialog : Window
    {
        public UserDeleteDialog(string kysymys1)
        {
            InitializeComponent();
            ensimmäinenLabel.Content = kysymys1;
        }
        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        public string Vastaus1
        {
            get { return ensimmäinenTb.Text; }
        }
    }
}
