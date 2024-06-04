using Harjoitus21.View.UserControls;
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
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;


namespace Harjoitus21
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Cart cart;
        public MainWindow()
        {
            InitializeComponent();
            cart = new Cart(cartPanel);
        }

        private void Product_CartCheckboxChecked(object sender, RoutedEventArgs e)
        {
            Product product = sender as Product;
            cart.Cart_Add(product);
            MessageBox.Show(product.productNameTb.Text);
            Trace.WriteLine(e.OriginalSource.ToString());
            Trace.WriteLine(sender.ToString());
            Trace.WriteLine("moi");
        }

        private void clearCartBtn_Click(object sender, RoutedEventArgs e)
        {
            cart.Cart_Clear();
        }
    }
}