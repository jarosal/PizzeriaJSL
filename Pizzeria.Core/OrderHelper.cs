using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Pizzeria.Data;
using Pizzeria.Data.Models;

namespace Pizzeria.Core
{
    public static class OrderHelper
    {
        public static void AddProductToOrder(Order order, GroupBox productBox)
        {
            var checkedButton = productBox.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            if (checkedButton != null)
            {
                Product product = new Product
                {
                    Name = checkedButton.Text, Price = Convert.ToDecimal(checkedButton.Tag.ToString())
                };

                order.Products.Add(product);
            }
        }

        public static void AddProductToOrder(Order order, GroupBox productBox, GroupBox additionsBox)
        {
            var checkedButton = productBox.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            if (checkedButton != null)
            {
                Product product = new Product
                {
                    Name = checkedButton.Text, Price = Convert.ToDecimal(checkedButton.Tag.ToString())
                };

                var checkedCheckbox = additionsBox.Controls.OfType<CheckBox>()
                    .Where(r => r.Checked);

                foreach (var box in checkedCheckbox)
                {
                    ProductAddition addition = new ProductAddition
                        {Name = box.Text, Price = Convert.ToDecimal(box.Tag.ToString())};
                    product.Additions.Add(addition);
                }

                order.Products.Add(product);
            }
        }

        public static decimal CalculatePrice(Order order)
        {
            decimal amount = new decimal();

            foreach (var product in order.Products)
            {
                foreach (var addition in product.Additions)
                {
                    amount += addition.Price;
                }

                amount += product.Price;
            }

            return amount;
        }

        public static void RemoveProduct(Order order, TableLayoutPanel panel)
        {
            var checkedCheckbox = panel.Controls.OfType<CheckBox>()
                .Where(r => r.Checked);

            List<Product> products = new List<Product>();

            foreach (var box in checkedCheckbox)
            {
                products.Add(order.Products.ElementAt(box.TabIndex));
            }

            foreach (var product in products)
            {
                order.Products.Remove(product);
            }
        }

        public static void PlaceOrder(User user, Order order)
        {
            order.TotalAmount = CalculatePrice(order);
            using (var db = new DatabaseContext())
            {
                user.Orders.Add(order);
                db.User.Update(user);
                db.SaveChanges();
            }
        }

        public static void AddNoteToOrder(Order order, String noteText)
        {
            Note note = new Note();
            note.Content = noteText;
            order.Note = note;
        }
    }
}