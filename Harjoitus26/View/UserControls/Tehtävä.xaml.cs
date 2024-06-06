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

namespace Harjoitus26.View.UserControls
{
    /// <summary>
    /// Interaction logic for Tehtävä.xaml
    /// </summary>
    public partial class Tehtävä : UserControl
    {
        public Tehtävä()
        {
            InitializeComponent();
            this.DataContext = this;    
            TehtäväLista.Add(this);
        }
        public string Nimi { get; set; }
        public string Kuvaus { get; set; }
        public string Antaja {  get; set; }
        public bool Tehty { get; set; }
    }
}
