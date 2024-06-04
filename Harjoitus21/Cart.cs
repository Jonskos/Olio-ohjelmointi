using Harjoitus21.View.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Harjoitus21
{
    public class Cart(StackPanel cartPanel)
    {
        private List<Product> cart = new List<Product>();
        StackPanel cartPanel = cartPanel;
        public void Cart_Add(Product product)
        {
            cart.Add(product);
            cartPanel.Children.Add(new TextBlock() { Text = product.ProductName } );
        }
        public void Cart_Remove(Product product)
        {
            cart.Remove(product);
            cartPanel.Children.Clear();
            foreach (Product p in cart)
            {
                cartPanel.Children.Add(new TextBlock() { Text = product.ProductName });
            }
        }
            public void Cart_Clear()
        {
            foreach (Product p in cart)
            {
                p.InCart = false;
            }
            cart.Clear();
            cartPanel.Children.Clear();
        }
        public List<Product> Cart_Get => cart;
    }
}
