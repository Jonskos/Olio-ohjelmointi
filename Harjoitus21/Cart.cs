using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Harjoitus21
{
    class Cart
    {
        private List<TextBox> cart;
        StackPanel cartPanel;
        public void Cart_Add(TextBox textBox)
        {
            cart.Add(textBox);
            cartPanel.Children.Add(textBox);
        }
        public void Cart_Remove(TextBox textBox)
        {
            cart.Remove(textBox);
            cartPanel.Children.Remove(textBox);
        }
        public void Cart_Clear()
        {
            cart.Clear();
            cartPanel.Children.Clear();
        }
        public List<TextBox> Cart_Get => cart;
        public Cart(StackPanel cartPanel)
        {
            this.cartPanel = cartPanel;
        }
    }
}
