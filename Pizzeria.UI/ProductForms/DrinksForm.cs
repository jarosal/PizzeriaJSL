using System;
using System.Windows.Forms;
using Pizzeria.Core;
using Pizzeria.Data.Models;

namespace Pizzeria.UI.ProductForms
{
    public partial class DrinksForm : Form
    {
        private Order _order;

        public DrinksForm(Order order)
        {
            InitializeComponent();
            _order = order;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrderHelper.AddProductToOrder(_order, grpDrinks);
            this.Close();
        }
    }
}