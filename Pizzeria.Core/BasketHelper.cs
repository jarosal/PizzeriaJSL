using System.Windows.Forms;
using Pizzeria.Data.Models;

namespace Pizzeria.Core
{
    public static class BasketHelper
    {
        public static void UpdateBasket(TableLayoutPanel panel, Order order)
        {
            panel.Controls.Clear();


            foreach (Product product in order.Products)
            {
                var box = new CheckBox();
                box.Text = product.Name;
                box.Tag = product.Id;
                box.Dock = DockStyle.Fill;
                panel.Controls.Add(box);
            }

            panel.Invalidate();
        }

        public static void UpdatePrice(Label label, decimal price)
        {
            label.Text = price.ToString();
            label.Invalidate();
        }
    }
}