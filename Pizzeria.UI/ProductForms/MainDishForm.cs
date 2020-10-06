using System;
using System.Windows.Forms;
using Pizzeria.Core;
using Pizzeria.Data.Models;

namespace Pizzeria.UI.ProductForms
{
    public partial class MainDishForm : Form
    {
        private Order _order;

        public MainDishForm(Order order)
        {
            InitializeComponent();
            _order = order;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrderHelper.AddProductToOrder(_order, grpMainDishes, grpAdditions);
            this.Close();
        }
    }
}