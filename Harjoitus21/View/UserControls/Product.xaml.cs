using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
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

namespace Harjoitus21.View.UserControls
{
    /// <summary>
    /// Interaction logic for Product.xaml
    /// </summary>
    public partial class Product : UserControl, INotifyPropertyChanged
    {
        public Product()
        {
            InitializeComponent();
            this.DataContext = this;
            productName = "Product name";
            productPrice = "0";
        }
        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        private string productPrice;

        public string ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }
        private string productImageSource;

        public string ProductImageSource
        {
            get { return productImageSource; }
            set { productImageSource = value; }
        }

        private bool inCart;

        public bool InCart
        {
            get { return inCart; }
            set 
            { 
                inCart = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("InCart"));
            }
        }

        public static readonly RoutedEvent CheckEvent = EventManager.RegisterRoutedEvent
            ("Checked",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(Product));

        public event PropertyChangedEventHandler? PropertyChanged;

        public event RoutedEventHandler Checked
        {
            add { AddHandler(CheckEvent, value); }
            remove { RemoveHandler(CheckEvent, value); }
        }
        void RaiseCheckEvent()
        {
            RoutedEventArgs routedEventArgs = new RoutedEventArgs(Product.CheckEvent);
            RaiseEvent(routedEventArgs);
        }
        private void cartCb_Checked(object sender, RoutedEventArgs e)
        {
            RaiseCheckEvent();
            //RaiseEvent(e);
        }
    }
}
