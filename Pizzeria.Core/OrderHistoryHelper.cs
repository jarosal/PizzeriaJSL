using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Pizzeria.Data;
using Pizzeria.Data.Models;

namespace Pizzeria.Core
{
    public class OrderHistoryHelper
    {
        public static void PopulateOrderHistory(TableLayoutPanel panel, User user)
        {
            using (var db = new DatabaseContext())
            {
                var orders = db.User
                    .Include(u => u.Orders)
                    .First(u => u.Login == user.Login)
                    .Orders;


                foreach (var order in orders)
                {
                    var lbl = new Label();
                    lbl.Dock = DockStyle.Fill;
                    lbl.Text = $"Numer zamówienia: {order.Id}, kwota: {order.TotalAmount} zł";
                    panel.Controls.Add(lbl);
                }
            }
        }
    }
}